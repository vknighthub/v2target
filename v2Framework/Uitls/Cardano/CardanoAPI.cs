using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using v2Framework.Models;

namespace v2Framework.Uitls.Cardano
{
    public class CardanoAPI
    {
        string baseUrl;

        public CardanoAPI(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public Response getNetworkInformation()
        {
            return RestAPI.GET(baseUrl + "/v2/networkinformation");
        }

        public Response getWalletbyID(string walletId)
        {
            JObject request = new JObject();
            request.Add("walletId", walletId);
            return RestAPI.POST(baseUrl + "/v2/getWalletbyID", request.ToString());
        }

        public Response getListWallet()
        {
            return RestAPI.GET(baseUrl + "/v2/getListWallet");
        }

        public Response addWallet(string walletName, string password, string passphare)
        {
            JObject request = new JObject();
            request.Add("walletName", walletName);
            request.Add("password", password);
            request.Add("passphare", passphare);

            return RestAPI.POST(baseUrl + "/v2/addWallet", request.ToString());
        }

        public Response getAddressListAsync(string walletId)
        {
            JObject request = new JObject();
            request.Add("walletId", walletId);
            return RestAPI.POST(baseUrl + "/v2/getAddressListAsync", request.ToString());
        }

        public Response Transfer(string walletid, string passphare, string adddress, double amount)
        {
            JObject request = new JObject();
            request.Add("walletid", walletid);
            request.Add("passphare", passphare);
            request.Add("adddress", adddress);
            request.Add("amount", amount);
            return RestAPI.POST(baseUrl + "/v2/Transfer", request.ToString());
        }

        public Response GetListTransfer(string walletid, string transactionid)
        {
            JObject request = new JObject();
            request.Add("walletid", walletid);
            request.Add("transactionid", transactionid);
            return RestAPI.POST(baseUrl + "/v2/GetListTransfer", request.ToString());
        }
    }
}
