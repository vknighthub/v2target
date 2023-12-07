using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace v2Framework.Models
{
    public class WalletInformation
    {
        public WalletItem currentWallet { get; set; }
        public BinanceAccount binanceAccount { get; set; }
        public double currentPrice { get; set; } = 0;
        public List<OrderTransaction> listBuy = new List<OrderTransaction>();
        public List<CardanoAddress> cardanoAddresses;
        public JArray listAddress;
        public JArray tradeList;

        public JArray listOrderPending;
        public JArray listOrderComplete;
        public string epoch = "-";
        public string slot = "-";
        public string nextepoch = "-";
        public string date = "-";

        public WalletInformation()
        {
        }

        public WalletInformation(WalletItem walletItem, BinanceAccount binanceAccount,double currentPrice)
        {
            this.currentWallet = walletItem;
            this.binanceAccount = binanceAccount;
            this.currentPrice = currentPrice;
        }
    }
}
