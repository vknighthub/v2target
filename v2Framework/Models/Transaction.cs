namespace v2Framework.Models
{
    public class Transaction
    {
        public string id { get; set; }
        public double amount { get; set; }
        public string side { get; set; }

        public Transaction(string id, double amount, string side)
        {
            this.id = id;
            this.amount = amount;
            this.side = side;
        }
    }
}
