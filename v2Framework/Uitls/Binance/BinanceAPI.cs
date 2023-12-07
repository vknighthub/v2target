using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace v2Framework.Uitls.Binance
{
    public class BinanceAPI
    {
        public BinanceService binanceService;
        HttpClient httpClient;

        public BinanceAPI(string apiKey, string apiSecret, string baseUrl)
        {
            httpClient = new HttpClient();
            binanceService = new BinanceService(apiKey, apiSecret, baseUrl, (HttpClient)this.httpClient);
        }

        public async Task<Response> getAvgPrice(string symbols)
        {
            Response responseprice = await binanceService.SendPublicAsync("/api/v3/avgPrice?symbol=" + symbols, HttpMethod.Get);
            return responseprice;
        }


        public async Task<Response> getAccount()
        {
            Response response = await binanceService.SendSignedAsync("/api/v3/account", HttpMethod.Get);
            return response;
        }

        public async Task<Response> getAllListOrders(string symbols)
        {
            Dictionary<string, object> query = new Dictionary<string, object>();

            query.Add("symbol", symbols);

            Response allorder = await binanceService.SendSignedAsync("/api/v3/allOrders", HttpMethod.Get, query);

            return allorder;
        }

        public async Task<Response> get24hTicket()
        {
            Response response = await this.binanceService.SendPublicAsync("/api/v3/ticker/24hr", HttpMethod.Get);
            return response;
        }

        public async Task<Response> MarketBuy(string symbols, double quantity)
        {
            Dictionary<string, object> query = new Dictionary<string, object>();
            query.Add("symbol", symbols);
            query.Add("side", "BUY");
            query.Add("type", "MARKET");
            query.Add("quantity", quantity);
            Response response = await this.binanceService.SendSignedAsync("/api/v3/order", HttpMethod.Post, query);
            return response;
        }

        public async Task<Response> MarketSell(string symbols, double quantity)
        {
            Dictionary<string, object> query = new Dictionary<string, object>();
            query.Add("symbol", symbols);
            query.Add("side", "SELL");
            query.Add("type", "MARKET");
            query.Add("quantity", quantity);
            Response response = await this.binanceService.SendSignedAsync("/api/v3/order", HttpMethod.Post, query);
            return response;
        }

        public async Task<Response> LimitMarketBuy(string symbols, double quantity, double price)
        {
            Dictionary<string, object> query = new Dictionary<string, object>();
            query.Add("symbol", symbols);
            query.Add("side", "BUY");
            query.Add("type", "LIMIT_MAKER");
            query.Add("quantity", quantity);
            query.Add("price", price);
            Response response = await this.binanceService.SendSignedAsync("/api/v3/order", HttpMethod.Post, query);
            return response;
        }

        public async Task<Response> LimitMarketSell(string symbols, double quantity, double price)
        {
            Dictionary<string, object> query = new Dictionary<string, object>();
            query.Add("symbol", symbols);
            query.Add("side", "SELL");
            query.Add("type", "LIMIT_MAKER");
            query.Add("quantity", quantity);
            query.Add("price", price);
            Response response = await this.binanceService.SendSignedAsync("/api/v3/order", HttpMethod.Post, query);
            return response;
        }

        public async Task<Response> CancelAllOrder(string symbols)
        {
            Dictionary<string, object> query = new Dictionary<string, object>();
            query.Add("symbol", symbols);
            Response response = await this.binanceService.SendSignedAsync("/api/v3/openOrders", HttpMethod.Delete, query);
            return response;
        }

        public async Task<Response> GetDepositAddress(string coin)
        {
            Dictionary<string, object> query = new Dictionary<string, object>();
            query.Add("coin", coin);
            Response response = await this.binanceService.SendSignedAsync("/sapi/v1/capital/deposit/address", HttpMethod.Get, query);
            return response;
        }

        public async Task<Response> BinanceWithDraw(string coin, string withdrawaddress, double quantity)
        {
            Dictionary<string, object> query = new Dictionary<string, object>();
            query.Add("coin", coin);
            query.Add("address", withdrawaddress);
            query.Add("amount", quantity);
            Response response = await this.binanceService.SendSignedAsync("/sapi/v1/capital/withdraw/apply", HttpMethod.Post, query);
            return response;
        }

        public async Task<Response> GetOrderbyID(string symbols, long orderid)
        {
            Dictionary<string, object> query = new Dictionary<string, object>();
            query.Add("symbol", symbols);
            query.Add("orderId", orderid);
            Response response = await this.binanceService.SendSignedAsync("/api/v3/order", HttpMethod.Get, query);
            return response;
        }
    }
}
