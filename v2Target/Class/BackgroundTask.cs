using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using v2Framework.Models;
using v2Framework.Uitls;
using v2Framework.Uitls.Binance;
using v2Framework.Uitls.Cardano;

namespace v2Target.Class
{
    public class BackgroundTask
    {
        public BinanceAPI binanceAPI;
        public BinanceAPI binanceAPITrading;
        public CardanoAPI cardanoAPI;
        private Boolean isEnableTrading;

        private double currentprice = 0;

        BackgroundWorker bg;
        public WalletInformation walletInformation;
        public TradingInformation tradingInformation;

        int tick = 0;
        string side = "NONE";


        string txtLogs = "";

        public BackgroundTask()
        {
            cardanoAPI = new CardanoAPI("http://localhost:4002");
            binanceAPI = new BinanceAPI(Properties.Settings.Default.API_KEY, Properties.Settings.Default.SECRET_KEY, "https://api.binance.com");
            walletInformation = new WalletInformation();
            tradingInformation = new TradingInformation();
            bg = new BackgroundWorker();
            bg.DoWork += Bg_DoWork;
        }


        public void StartTask()
        {
            bg.RunWorkerAsync();
        }


        public void StopTask()
        {
            bg.CancelAsync();
        }


        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            while (true)
            {
                if (i == 0)
                {
                    CalculateWallet();
                    CalculateTrading();
                    LoadListOrders();
                    LoadTradeList();
                }
                LoadEpoch();
                i++;
                if (i > 15)
                    i = 0;
                Thread.Sleep(1000);
            }
        }

        public async void CalculateWallet()
        {
            double firstprice = Properties.Settings.Default.FIRSTPRICE;

            string dptaddress = Properties.Settings.Default.DPTADDRESS;

            Response accountBinance = await binanceAPI.getAccount();
            if (accountBinance.code != 0)
            {
                UpdateLog(accountBinance.msg);
            }
            else
            {
                walletInformation.binanceAccount = JsonConvert.DeserializeObject<BinanceAccount>(accountBinance.result.ToString());
                walletInformation.binanceAccount.getBalance();
            }

            Response responsewallet = cardanoAPI.getWalletbyID(Properties.Settings.Default.WALLETID);
            if (responsewallet.code != 0)
            {
                UpdateLog(responsewallet.msg);
            }
            else
            {
                walletInformation.currentWallet = JsonConvert.DeserializeObject<WalletItem>(responsewallet.result.ToString());
            }

            if (dptaddress.Equals("") || dptaddress.Length <= 1)
            {
                Response res = await binanceAPI.GetDepositAddress("ADA");
                if (res.code != 0)
                {
                    UpdateLog("Can't get Deposit ADA Address in Binance account");
                    return;
                }
                else
                {
                    dptaddress = JObject.Parse(res.result).GetValue("address").ToString();
                    Properties.Settings.Default.DPTADDRESS = dptaddress;
                    Properties.Settings.Default.Save();
                }
            }

            Response avgprice = await binanceAPI.getAvgPrice("ADAUSDT");
            if (avgprice.code != 0)
            {
                UpdateLog(avgprice.msg);
                return;
            }

            currentprice = Math.Round(double.Parse(JObject.Parse(avgprice.result).GetValue("price").ToString()), 4);

            if (firstprice == 0)
            {
                v2Target.Properties.Settings.Default.FIRSTPRICE = currentprice;
                v2Target.Properties.Settings.Default.Save();
                firstprice = currentprice;
            }

            if (walletInformation.cardanoAddresses == null || walletInformation.cardanoAddresses.Count == 0)
            {
                walletInformation.cardanoAddresses = LoadAddressWalletAsync();
                if (walletInformation.cardanoAddresses == null || walletInformation.cardanoAddresses.Count == 0)
                    return;
            }

            walletInformation.currentPrice = currentprice;

            if (side.Equals("SELL") && double.Parse(walletInformation.binanceAccount.ada.free) > 10)
            {
                Response res = await binanceAPI.MarketSell("ADAUSDT", double.Parse(walletInformation.binanceAccount.ada.free));
                if (res.code == 0)
                {
                    UpdateLog("Order Sell ADA successfull");
                    UpdateLog(res.result.ToString());
                    side = "NONE";
                }
                else
                {
                    UpdateLog("Cannot sell ADA. System will try again later.");
                }
            }
            else if (side.Equals("BUY"))
            {
                for (int i = walletInformation.listBuy.Count - 1; i >= 0; i--)
                {
                    Response res = await binanceAPI.GetOrderbyID("ADAUSDT", walletInformation.listBuy[i].orderId);
                    if (res.code != 0)
                    {
                        UpdateLog("Can't check order id: " + walletInformation.listBuy[i].orderId + " in Binance");
                    }
                    else
                    {
                        OrderTransaction order = JsonConvert.DeserializeObject<OrderTransaction>(res.result.ToString());
                        if ("FILLED|CANCELED|REJECTED|EXPIRED".Contains(order.status))
                        {
                            walletInformation.listBuy.RemoveAt(i);
                        }
                    }
                }

                if (walletInformation.listBuy.Count == 0)
                {
                    if (double.Parse(walletInformation.binanceAccount.ada.free) > 12)
                    {
                        try
                        {
                            string withdrawaddress = walletInformation.cardanoAddresses[0].id;
                            Response res = await binanceAPI.BinanceWithDraw("ADA", withdrawaddress, double.Parse(walletInformation.binanceAccount.ada.free) - 2);
                            if (res.code != 0)
                            {
                                UpdateLog("Can't withdraw amount to wallet");
                                UpdateLog("Can't withdraw amount to wallet " + res.msg + " " + walletInformation.cardanoAddresses[0].id);
                            }
                            else
                            {
                                UpdateLog("Withdraw amount to wallet success");
                                UpdateLog(res.result.ToString());
                            }
                        }
                        catch (Exception ex)
                        {

                            UpdateLog("Cannot withdraw because error: " + ex.Message.ToString());
                        }

                    }
                    side = "NONE";
                }
            }

            double target = Properties.Settings.Default.TARGET;
            double intrate = Properties.Settings.Default.INTRATE / 100;
            double currintrate = Properties.Settings.Default.INTRATE;
            double exratechange = Properties.Settings.Default.EXRATECHANGE / 100;
            double currentAda = (walletInformation.currentWallet.balance.available.quantity / 1000000);
            double rate = Math.Round(((currentprice - firstprice) / firstprice), 4);
            double estimateamt = (currentAda * intrate * currentprice) / 12;

            if (walletInformation.currentWallet.state.status.Equals("ready") && (tick % 10 == 0) && target > 0)
            {
                double estchange = Math.Abs(((estimateamt - target) / target) * 100);
                if (estimateamt < target && estchange >= 5 && walletInformation.listBuy.Count == 0)
                {
                    double coinneed = (target * 12) / (intrate * currentprice);
                    double coinbuy = Math.Round(coinneed - currentAda, 4);

                    UpdateLog("Current ADA is not enough. System need more: " + coinbuy + " ADA");
                    UpdateLog("Current ADA in binance is: " + double.Parse(walletInformation.binanceAccount.ada.free) + " ADA");
                    UpdateLog("Current USDT in binance is: " + double.Parse(walletInformation.binanceAccount.usdt.free) + " USDT");

                    double coinneddbuy = coinbuy - double.Parse(walletInformation.binanceAccount.ada.free);

                    if (coinneddbuy > 0)
                    {
                        if ((coinneddbuy * Math.Round(currentprice, 2)) <= double.Parse(walletInformation.binanceAccount.usdt.free))
                        {
                            UpdateLog("System will buy: " + coinneddbuy + " ADA in Binance");
                            Response res = await binanceAPI.MarketBuy("ADAUSDT", coinneddbuy);

                            if (res.code != 0)
                            {
                                UpdateLog(res.msg);
                            }
                            else
                            {
                                OrderTransaction orderTransaction = JsonConvert.DeserializeObject<OrderTransaction>(res.result.ToString());
                                Properties.Settings.Default.FIRSTPRICE = currentprice;
                                Properties.Settings.Default.Save();
                                walletInformation.listBuy.Add(orderTransaction);
                                side = "BUY";
                                UpdateLog("Order buy successful");
                                UpdateLog(res.result.ToString());
                            }
                        }
                        else
                        {
                            UpdateLog("Not have enough USDT to order more ADA. System will checking and move current ADA available in binance to wallet.");
                            if (double.Parse(walletInformation.binanceAccount.ada.free) > 12)
                            {
                                UpdateLog("System will move " + (double.Parse(walletInformation.binanceAccount.ada.free) - 2) + " to wallet.");
                                side = "BUY";
                            }
                        }
                    }
                    else
                    {
                        UpdateLog("System will move " + coinbuy + " to wallet.");
                        side = "BUY";
                    }
                }
                else
                {
                    if (rate > 0 && rate >= exratechange)
                    {
                        if (estimateamt > target && estchange >= 5)
                        {
                            double coinneed = (target * 12) / (intrate * currentprice);
                            double coinsell = Math.Round(currentAda - coinneed, 4);
                            UpdateLog("Price ADA is up. System will try move some ADA from wallet to Binance account");

                            Response res = cardanoAPI.Transfer(Properties.Settings.Default.WALLETID, Properties.Settings.Default.PASSWALLET, dptaddress, coinsell);
                            if (res.code != 0)
                            {
                                UpdateLog("cannot transfer ADA from wallet to binance to sell");
                            }
                            else
                            {
                                Properties.Settings.Default.FIRSTPRICE = currentprice;
                                Properties.Settings.Default.Save();
                                side = "SELL";
                            }
                        }
                    }
                    else if (rate < 0 && Math.Abs(rate) >= exratechange)
                    {
                        if (estimateamt < target && estchange >= 5 && walletInformation.listBuy.Count == 0)
                        {
                            double coinneed = (target * 12) / (intrate * currentprice);
                            double coinbuy = Math.Round(coinneed - currentAda, 4);

                            UpdateLog("Price of ADA is down. System will buy more: " + coinbuy + " ADA");
                            UpdateLog("Current USDT in binance is: " + double.Parse(walletInformation.binanceAccount.usdt.free) + " USDT");
                            UpdateLog("USDT estimate need: " + ((coinbuy - double.Parse(walletInformation.binanceAccount.ada.free)) * Math.Round(currentprice, 2)) + " USDT");

                            double coinneddbuy = coinbuy - double.Parse(walletInformation.binanceAccount.ada.free);
                            if (coinneddbuy > 0)
                            {
                                if ((coinneddbuy * Math.Round(currentprice, 2)) <= double.Parse(walletInformation.binanceAccount.usdt.free))
                                {
                                    UpdateLog("System will buy: " + coinneddbuy + " ADA in Binance");
                                    Response res = await binanceAPI.MarketBuy("ADAUSDT", coinneddbuy);

                                    if (res.code != 0)
                                    {
                                        UpdateLog(res.msg);
                                    }
                                    else
                                    {
                                        OrderTransaction orderTransaction = JsonConvert.DeserializeObject<OrderTransaction>(res.result.ToString());
                                        Properties.Settings.Default.FIRSTPRICE = currentprice;
                                        Properties.Settings.Default.Save();
                                        walletInformation.listBuy.Add(orderTransaction);
                                        side = "BUY";
                                        UpdateLog("Order buy successful");
                                        UpdateLog(res.result.ToString());
                                    }
                                }
                                else
                                {
                                    UpdateLog("Not have enough USDT to order more ADA. System will checking and move current ADA available in binance to wallet.");
                                    if (double.Parse(walletInformation.binanceAccount.ada.free) > 12)
                                    {
                                        UpdateLog("System will move " + (double.Parse(walletInformation.binanceAccount.ada.free) - 2) + " to wallet.");
                                        side = "BUY";
                                    }
                                }
                            }
                            else
                            {
                                UpdateLog("System will move " + coinbuy + " to wallet.");
                                side = "BUY";
                            }
                            UpdateLog("End one round.");
                        }
                    }

                }
            }
                        
            UpdateLog("--------------------------------------------");
            if (tick >= 10)
            {
                WriteLog();
                tick = 0;
            }
            tick++;
        }

        public async void CalculateTrading()
        {

            isEnableTrading = Properties.Settings.Default.ENABLE_TRADING;

            if (isEnableTrading || ! Properties.Settings.Default.API_KEY_TRADING.Equals(""))
            {
                binanceAPITrading = new BinanceAPI(Properties.Settings.Default.API_KEY_TRADING, Properties.Settings.Default.SECRET_KEY_TRADING, "https://api.binance.com");
                
                Response accountBinance = await binanceAPITrading.getAccount();
                
                if (accountBinance.code != 0)
                {
                    UpdateLog(accountBinance.msg);
                }
                else
                {
                    tradingInformation.binanceAccount = JsonConvert.DeserializeObject<BinanceAccount>(accountBinance.result.ToString());
                    tradingInformation.binanceAccount.getBalance();
                }

                Response avgprice = await binanceAPITrading.getAvgPrice("ADAUSDT");
                if (avgprice.code != 0)
                {
                    UpdateLog(avgprice.msg);
                    return;
                }

                currentprice = Math.Round(double.Parse(JObject.Parse(avgprice.result).GetValue("price").ToString()), 4);
            }

            double priceTrading = Properties.Settings.Default.TRADING_PRICE;

            if (priceTrading == 0 && isEnableTrading)
            {
                v2Target.Properties.Settings.Default.TRADING_PRICE = currentprice;
                v2Target.Properties.Settings.Default.Save();
                priceTrading = currentprice;
            }


            if (isEnableTrading)
            {
                int resultloadinglist = await LoadListOrdersTrading();
                if (resultloadinglist == 1 || tradingInformation.listOrderPending != null)
                {
                    double tradingRange = Properties.Settings.Default.TRADING_RANGE;
                    double lowerprice = Math.Round(currentprice - (currentprice * tradingRange / 100),2);
                    double upperprice = Math.Round(currentprice + (currentprice * tradingRange / 100),2);

                    if (tradingInformation.listOrderPending.Count == 0)
                    {
                        Response buy = await binanceAPITrading.LimitMarketBuy("ADAUSDT", Properties.Settings.Default.AMOUNT_TRADING, lowerprice);
                        Response sell = await binanceAPITrading.LimitMarketSell("ADAUSDT", Properties.Settings.Default.AMOUNT_TRADING, upperprice);

                        if (buy.code != 0)
                        {
                            tradingInformation.errortext = buy.msg;
                        }else if (sell.code != 0)
                        {
                            tradingInformation.errortext = sell.msg;
                        }
                        else
                        {
                            tradingInformation.errortext = "";
                            tradingInformation.listOrderPending.Clear();
                            await LoadListOrdersTrading();
                        }
                    }
                    else if (tradingInformation.listOrderPending.Count < 2)
                    {
                        Response resultcancel = await binanceAPITrading.CancelAllOrder("ADAUSDT");
                        if (resultcancel.code == 0)
                        {
                            Response buy = await binanceAPITrading.LimitMarketBuy("ADAUSDT", Properties.Settings.Default.AMOUNT_TRADING, lowerprice);
                            Response sell = await binanceAPITrading.LimitMarketSell("ADAUSDT", Properties.Settings.Default.AMOUNT_TRADING, upperprice);

                            if (buy.code != 0)
                            {
                                tradingInformation.errortext = buy.msg;
                            }
                            else if (sell.code != 0)
                            {
                                tradingInformation.errortext = sell.msg;
                            }
                            else
                            {
                                tradingInformation.errortext = "";
                                tradingInformation.listOrderPending.Clear();
                                await LoadListOrdersTrading();
                            }
                        }
                        else
                        {
                            tradingInformation.errortext = resultcancel.msg;
                        }

                    }
                }
            }
        }

        private async Task<int> LoadListOrdersTrading()
        {
            if (!Properties.Settings.Default.API_KEY_TRADING.Equals("") && !Properties.Settings.Default.SECRET_KEY_TRADING.Equals(""))
            {
                Response responseOrder = await this.binanceAPITrading.getAllListOrders("ADAUSDT");

                if (responseOrder.code != 0)
                {
                    UpdateLog(responseOrder.msg);
                    return 0;
                }

                if (responseOrder.result != null && responseOrder.result.Length > 1)
                {
                    var jsondata = JsonDocument.Parse(responseOrder.result);

                    var rows = jsondata.RootElement.EnumerateArray();

                    JArray listOrderPending = new JArray();
                    JArray listOrderComplete = new JArray();

                    while (rows.MoveNext())
                    {
                        var rowsconten = rows.Current;
                        JObject job = JObject.Parse(rowsconten.ToString());
                        JObject jobContent = new JObject();

                        if ("FILLED|CANCELED|REJECTED|EXPIRED".Contains(job["status"].ToString()))
                        {
                            var jobject = rowsconten.EnumerateObject();

                            while (jobject.MoveNext())
                            {
                                if (jobject.Current.Name == "origQty")
                                {
                                    jobContent.Add("Amount", "$ " + double.Parse(jobject.Current.Value.ToString()));
                                }
                                if (jobject.Current.Name == "price")
                                {
                                    jobContent.Add("Price", "$ " + Math.Round(double.Parse(jobject.Current.Value.ToString()), 4));
                                }
                                if (jobject.Current.Name == "status")
                                {
                                    jobContent.Add("Status", jobject.Current.Value.ToString());
                                }
                                if (jobject.Current.Name == "side")
                                {
                                    jobContent.Add("Side", jobject.Current.Value.ToString());
                                }
                            }
                            listOrderComplete.Add(jobContent);
                        }
                        else
                        {
                            var jobject = rowsconten.EnumerateObject();

                            while (jobject.MoveNext())
                            {
                                if (jobject.Current.Name == "origQty")
                                {
                                    jobContent.Add("Amount", "$ " + double.Parse(jobject.Current.Value.ToString()));
                                }
                                if (jobject.Current.Name == "price")
                                {
                                    jobContent.Add("Price", "$ " + Math.Round(double.Parse(jobject.Current.Value.ToString()), 4));
                                }
                                if (jobject.Current.Name == "status")
                                {
                                    jobContent.Add("Status", jobject.Current.Value.ToString());
                                }
                                if (jobject.Current.Name == "side")
                                {
                                    jobContent.Add("Side", jobject.Current.Value.ToString());
                                }
                            }
                            listOrderPending.Add(jobContent);
                        }
                    }

                    tradingInformation.listOrderPending = listOrderPending;
                    tradingInformation.listOrderComplete = listOrderComplete;
                }
            }
            return 1;
        }

        private async void LoadListOrders()
        {
            Response responseOrder = await this.binanceAPI.getAllListOrders("ADAUSDT");
            if (responseOrder.code != 0)
            {
                UpdateLog(responseOrder.msg);
                return;
            }

            if (responseOrder.result != null && responseOrder.result.Length > 1)
            {
                var jsondata = JsonDocument.Parse(responseOrder.result);

                var rows = jsondata.RootElement.EnumerateArray();

                JArray listOrderPending = new JArray();
                JArray listOrderComplete = new JArray();

                while (rows.MoveNext())
                {
                    var rowsconten = rows.Current;
                    JObject job = JObject.Parse(rowsconten.ToString());
                    JObject jobContent = new JObject();

                    if ("FILLED|CANCELED|REJECTED|EXPIRED".Contains(job["status"].ToString()))
                    {
                        var jobject = rowsconten.EnumerateObject();

                        while (jobject.MoveNext())
                        {
                            if (jobject.Current.Name == "origQty")
                            {
                                jobContent.Add("Amount", "$ " + double.Parse(jobject.Current.Value.ToString()));
                            }
                            if (jobject.Current.Name == "price")
                            {
                                jobContent.Add("Price", "$ " + Math.Round(double.Parse(jobject.Current.Value.ToString()), 4));
                            }
                            if (jobject.Current.Name == "status")
                            {
                                jobContent.Add("Status", jobject.Current.Value.ToString());
                            }
                            if (jobject.Current.Name == "side")
                            {
                                jobContent.Add("Side", jobject.Current.Value.ToString());
                            }
                        }
                        listOrderComplete.Add(jobContent);
                    }
                    else
                    {
                        var jobject = rowsconten.EnumerateObject();

                        while (jobject.MoveNext())
                        {
                            if (jobject.Current.Name == "origQty")
                            {
                                jobContent.Add("Amount", "$ " + double.Parse(jobject.Current.Value.ToString()));
                            }
                            if (jobject.Current.Name == "price")
                            {
                                jobContent.Add("Price", "$ " + Math.Round(double.Parse(jobject.Current.Value.ToString()), 4));
                            }
                            if (jobject.Current.Name == "status")
                            {
                                jobContent.Add("Status", jobject.Current.Value.ToString());
                            }
                            if (jobject.Current.Name == "side")
                            {
                                jobContent.Add("Side", jobject.Current.Value.ToString());
                            }
                        }
                        listOrderPending.Add(jobContent);
                    }
                }

                walletInformation.listOrderPending = listOrderPending;
                walletInformation.listOrderComplete = listOrderComplete;
            }
        }

        private List<CardanoAddress> LoadAddressWalletAsync()
        {
            JArray listAddress = new JArray();
            List<CardanoAddress> cardanoAddresses = new List<CardanoAddress>();
            Response result = cardanoAPI.getAddressListAsync(Properties.Settings.Default.WALLETID);
            if (result.code != 0)
            {
                UpdateLog(result.msg);
                return null;
            }

            if (result.result != null && result.result.Length >= 1)
            {
                cardanoAddresses = JsonConvert.DeserializeObject<List<CardanoAddress>>(result.result);

                var jsondata = JsonDocument.Parse(result.result);

                var rows = jsondata.RootElement.EnumerateArray();

                while (rows.MoveNext())
                {
                    var rowsconten = rows.Current;
                    JObject jobContent = new JObject();

                    var jobject = rowsconten.EnumerateObject();

                    while (jobject.MoveNext())
                    {
                        if (jobject.Current.Name == "id")
                        {
                            jobContent.AddFirst(new JProperty("Address", jobject.Current.Value.ToString()));

                        }
                        if (jobject.Current.Name == "state")
                        {
                            jobContent.Add("State", jobject.Current.Value.ToString());
                        }
                    }
                    listAddress.Add(jobContent);
                }
            }
            walletInformation.listAddress = listAddress;
            return cardanoAddresses;
        }

        public void LoadEpoch()
        {
            Response response = cardanoAPI.getNetworkInformation();
            try
            {
                if (response.code == 0)
                {
                    JObject nodetip = JObject.Parse(JObject.Parse(response.result).GetValue("network_tip").ToString());
                    string epouch = nodetip.GetValue("epoch_number").ToString();
                    string currentSlot = nodetip.GetValue("slot_number").ToString();


                    JObject next_epoch = JObject.Parse(JObject.Parse(response.result).GetValue("next_epoch").ToString());
                    string epoch_start_time = next_epoch.GetValue("epoch_start_time").ToString();
                    string epoch_number = next_epoch.GetValue("epoch_number").ToString();

                    DateTime dt = Convert.ToDateTime(epoch_start_time);

                    walletInformation.epoch = epouch;
                    walletInformation.slot = currentSlot;
                    walletInformation.nextepoch = epoch_number;
                    walletInformation.date = epoch_start_time;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private async void LoadTradeList()
        {
            Response response = await this.binanceAPI.get24hTicket();

            if (response.code != 0)
            {
                UpdateLog(response.msg);
                return;
            }

            var jsondata = JsonDocument.Parse(response.result);

            var rows = jsondata.RootElement.EnumerateArray();

            JArray newList = new JArray();

            while (rows.MoveNext())
            {
                var rowsconten = rows.Current;
                JObject job = JObject.Parse(rowsconten.ToString());
                JObject jobContent = new JObject();

                if ("BNBUSDT|ADAUSDT|BTCUSDT|ETHUSDT".Contains(job["symbol"].ToString()))
                {
                    var jobject = rowsconten.EnumerateObject();

                    while (jobject.MoveNext())
                    {
                        if (jobject.Current.Name == "symbol")
                        {
                            jobContent.Add("Name", jobject.Current.Value.ToString());
                        }
                        if (jobject.Current.Name == "lastPrice")
                        {
                            jobContent.Add("Last price", "$ " + Math.Round(decimal.Parse(jobject.Current.Value.ToString()), 4));
                        }
                        if (jobject.Current.Name == "priceChangePercent")
                        {
                            double amount = Math.Round(double.Parse(jobject.Current.Value.ToString()), 2);
                            string change = null;
                            if (amount >= 0)
                            {
                                change = "+" + amount + "%";
                            }
                            else
                            {
                                change = amount + "%";
                            }
                            jobContent.Add("24h Change", change);
                        }
                    }
                    newList.Add(jobContent);
                }
            }

            walletInformation.tradeList = newList;
        }

        public void UpdateLog(string logs)
        {
            txtLogs = txtLogs + logs + "\r\n";
        }


        public void WriteLog()
        {
           File.WriteAllTextAsync(Application.StartupPath + "logs\\" + DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + ".log", txtLogs);
        }
    }
}
