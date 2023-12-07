using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace v2Framework.Models
{
    public class TradingInformation
    {
        public BinanceAccount binanceAccount { get; set; }
        public double currentPrice { get; set; } = 0;

        public JArray listOrderPending;
        public JArray listOrderComplete;

        public string errortext = "";

        public TradingInformation()
        {
        }

        public TradingInformation(BinanceAccount binanceAccount,double currentPrice)
        {
            this.binanceAccount = binanceAccount;
            this.currentPrice = currentPrice;
        }
    }
}
