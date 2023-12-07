using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2Framework.Models
{
    public class BinanceAccount
    {
        public double makerCommission { get; set; }
        public double takerCommission { get; set; }
        public double buyerCommission { get; set; }
        public double sellerCommission { get; set; }
        public bool canTrade { get; set; }
        public bool canWithdraw { get; set; }
        public bool canDeposit { get; set; }
        public long updateTime { get; set; }
        public string accountType { get; set; }
        public List<Balances> balances { get; set; }
        

        public Balances ada { get; set; }
        public Balances usdt { get; set; }

        public void getBalance()
        {
            this.ada = new Balances ();
            this.ada.free = "0";
            this.usdt = new Balances();
            this.usdt.free = "0";
            for (int i = 0; i < balances.Count; i++)
            {
                if (balances[i].asset.Equals("ADA"))
                {
                    this.ada = balances[i];
                }
                if (balances[i].asset.Equals("USDT"))
                {
                    this.usdt = balances[i];
                }
            }
        }

    }

    public class Balances
    {
        public string asset { get; set; }
        public string free { get; set; }
        public string locked { get; set; }

    }


}
