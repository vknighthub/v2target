using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace v2Framework.Uitls.Binance
{ 
        public sealed class BinanceService
    {
            private string baseUrl;
            private string apiKey;
            private string apiSecret;
            private HttpClient httpClient;

            public BinanceService(string apiKey, string apiSecret, string baseUrl, HttpClient httpClient)
            {
                this.apiKey = apiKey;
                this.apiSecret = apiSecret;
                this.baseUrl = baseUrl;
                this.httpClient = httpClient;
            }

            private async Task<Response> SendAsync(string requestUri, HttpMethod httpMethod, object content = null)
            {
                Response strReturn = new Response();
                Console.WriteLine(requestUri);
                using (var request = new HttpRequestMessage(httpMethod, this.baseUrl + requestUri))
                {
                request.Headers.Add("X-MBX-APIKEY", this.apiKey);

                if (!(content is null))
                    request.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
                try
                {
                    HttpResponseMessage response = await this.httpClient.SendAsync(request);

                    using (HttpContent responseContent = response.Content)
                    {
                        string jsonString = await responseContent.ReadAsStringAsync();

                        JObject job = new JObject();

                        try
                        {
                            job = JObject.Parse(jsonString);
                            if (job.ContainsKey("code"))
                            {
                                strReturn.code = int.Parse(job.GetValue("code").ToString());
                                strReturn.msg = job.GetValue("msg").ToString();
                            }
                            else
                            {
                                strReturn.result = jsonString;
                            }
                        }
                        catch (Exception)
                        {
                            strReturn.result = jsonString;
                        }

                        return strReturn;
                    }
                }
                catch (Exception ex)
                {
                    var w32ex = ex as Win32Exception;
                    int code = -9999;
                    if (w32ex == null)
                    {
                        w32ex = ex.InnerException as Win32Exception;
                    }
                    if (w32ex != null)
                    {
                        code = w32ex.ErrorCode;
                    }

                    strReturn.code = code;
                    strReturn.msg = ex.Message;

                    return strReturn;
                }
                }
            }

            public async Task<Response> SendPublicAsync(string requestUri, HttpMethod httpMethod, Dictionary<string, object> query = null, object content = null)
            {
                if (!(query is null))
                {
                    string queryString = string.Join("&", query.Where(kvp => !string.IsNullOrWhiteSpace(kvp.Value?.ToString())).Select(kvp => string.Format("{0}={1}", kvp.Key, HttpUtility.UrlEncode(kvp.Value.ToString()))));

                    if (!string.IsNullOrWhiteSpace(queryString))
                    {
                        requestUri += "?" + queryString;
                    }
                }

                return await this.SendAsync(requestUri, httpMethod, content);
            }

            public async Task<Response> SendSignedAsync(string requestUri, HttpMethod httpMethod, Dictionary<string, object> query = null, object content = null)
            {
                StringBuilder queryStringBuilder = new StringBuilder();

                if (!(query is null))
                {
                    string queryParameterString = string.Join("&", query.Where(kvp => !string.IsNullOrWhiteSpace(kvp.Value?.ToString())).Select(kvp => string.Format("{0}={1}", kvp.Key, HttpUtility.UrlEncode(kvp.Value.ToString()))));
                    queryStringBuilder.Append(queryParameterString);
                }

                if (queryStringBuilder.Length > 0)
                    queryStringBuilder.Append("&");

                long now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                queryStringBuilder.Append("timestamp=").Append(now);

                string signature = SignatureHelper.Sign(queryStringBuilder.ToString(), this.apiSecret);
                queryStringBuilder.Append("&signature=").Append(signature);

                StringBuilder requestUriBuilder = new StringBuilder(requestUri);
                requestUriBuilder.Append("?").Append(queryStringBuilder.ToString());

                return await this.SendAsync(requestUriBuilder.ToString(), httpMethod, content);
            }
        }
    }
