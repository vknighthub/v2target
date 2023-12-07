using System;
using System.Windows.Forms;
using v2Framework.Models;

namespace v2Target.View.Trading
{
    public partial class Summary : UserControl
    {
        public Summary()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        public void updateData(TradingInformation tradingInformation)
        {
            double intrate = Properties.Settings.Default.INTRATE / 100;
            double target = Properties.Settings.Default.TARGET;
            double currentprice = tradingInformation.currentPrice;

            this.lblcurrentprice.Text = currentprice.ToString() + " USD";
            this.lblamounttrading.Text = Properties.Settings.Default.AMOUNT_TRADING.ToString() + " ADA";
            this.lblbinada.Text = double.Parse(tradingInformation.binanceAccount.ada.free) + " ADA";
            this.lblbinusdt.Text = double.Parse(tradingInformation.binanceAccount.usdt.free) + " USDT";
            this.LBLERROR.Text = tradingInformation.errortext;
        }

        public void updateWarning(string text)
        {
            lblWarning.Text = "";
        }
    }
}
