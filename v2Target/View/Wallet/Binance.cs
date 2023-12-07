using System.Windows.Forms;
using v2Framework.Controls;
using v2Framework.Models;

namespace v2Target.View.Wallet
{
    public partial class Binance : UserControl
    {
        public Binance()
        {
            InitializeComponent(); 
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        public void updateData(BinanceAccount binanceAccount)
        {
            this.lblada.Text = double.Parse(binanceAccount.ada.free) + " ADA";
            this.lblusdt.Text = double.Parse(binanceAccount.usdt.free) + " USDT";
        }

        public void loadListOrder(string datapending, string datacomplete)
        {
            v2ListComplete.Data = datacomplete;
            v2ListPending.Data = datapending;
        }
    }
}
