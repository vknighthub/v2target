using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;

namespace v2Framework.Uitls
{
    public static class RestAPI
    {
        public static Response GET(string url)
        {
            Response strReturn = new Response();

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                using (Stream responseStream = httpWebRequest.GetResponse().GetResponseStream())

                    strReturn.result = new StreamReader(responseStream, Encoding.UTF8).ReadToEnd();

                strReturn = JsonConvert.DeserializeObject<Response>(strReturn.result);
                return strReturn;
            }
            catch (WebException ex1)
            {
                try
                {
                    strReturn.code = -9999;
                    strReturn.msg = ex1.Message.ToLower();

                    return strReturn;
                }
                catch (Exception ex2)
                {
                    strReturn.code = -9999;
                    strReturn.msg = ex2.Message.ToLower();

                    return strReturn;
                }
            }
        }

        public static Response POST(string url, string jsonContent)
        {
            Response strReturn = new Response();
            try
            {
                string str = "";
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    str = webClient.UploadString(url, nameof(POST), jsonContent);
                }
                strReturn.result = str;

                strReturn = JsonConvert.DeserializeObject<Response>(str);
                return strReturn;
            }
            catch (WebException exception)
            {
                string responseText;

                using (var reader = new StreamReader(exception.Response.GetResponseStream()))
                {
                    responseText = reader.ReadToEnd();
                }

                JObject error = JObject.Parse(responseText);

                strReturn.code = -9999;
                strReturn.msg = error.GetValue("message").ToString();
                return strReturn;
            }
            catch (Exception ex)
            {
                strReturn.code = -9999;
                strReturn.msg = ex.Message.ToLower();

                return strReturn;
            }
        }

        public static Response PATCH(string url, string jsonContent)
        {
            Response strReturn = new Response();
            try
            {
                string str = "";
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    str = webClient.UploadString(url, nameof(PATCH), jsonContent);
                }
                strReturn.result = str;
                return strReturn;
            }
            catch (Exception ex)
            {
                strReturn.code = -9999;
                strReturn.msg = ex.Message.ToLower();

                return strReturn;
            }
        }

        public static Response DELETE(string url, string jsonContent)
        {
            Response strReturn = new Response();
            try
            {
                string str = "";
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    str = webClient.UploadString(url, nameof(DELETE), jsonContent);
                }
                strReturn.result = str;
                return strReturn;
            }
            catch (Exception ex)
            {
                strReturn.code = -9999;
                strReturn.msg = ex.Message.ToLower();

                return strReturn;
            }
        }
    }
}