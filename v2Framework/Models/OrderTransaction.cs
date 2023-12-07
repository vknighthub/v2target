using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2Framework.Models
{
    public class OrderTransaction
    {
        public string symbol { get; set; }
        public int orderId { get; set; }
        public int orderListId { get; set; }
        public string clientOrderId { get; set; }
        public long transactTime { get; set; }
        public string price { get; set; }
        public double origQty { get; set; }
        public string executedQty { get; set; }
        public string cummulativeQuoteQty { get; set; }
        public string status { get; set; }
        public string timeInForce { get; set; }
        public string type { get; set; }
        public string side { get; set; }

        public List<ListBuy> fills { get; set; }
    }



    public class ListBuy
    {
        public string price { get; set; }
        public string qty { get; set; }
        public string commission { get; set; }
        public string commissionAsset { get; set; }
    }
}
