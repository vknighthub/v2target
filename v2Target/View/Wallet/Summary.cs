using System;
using System.Windows.Forms;
using v2Framework.Models;

namespace v2Target.View.Wallet
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

        private void v2Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void updateData(WalletInformation walletInformation)
        {
            double intrate = Properties.Settings.Default.INTRATE / 100;
            double target = Properties.Settings.Default.TARGET;
            double currentprice = walletInformation.currentPrice;

            double coinneed = (target * 12) / (intrate * currentprice);
            double estcoin = (walletInformation.currentWallet.balance.total.quantity / 1000000 * currentprice) * intrate / 12;

            this.lblwallet.Text = (walletInformation.currentWallet.balance.total.quantity / 1000000).ToString() + " ADA";
            this.lblstatus.Text = walletInformation.currentWallet.state.status;
            this.lblcurrentprice.Text = currentprice.ToString() + " USD";
            this.lbltarget.Text = Properties.Settings.Default.TARGET.ToString() + " USD";
            this.lblbinada.Text = double.Parse(walletInformation.binanceAccount.ada.free) + " ADA";
            this.lblbinusdt.Text = double.Parse(walletInformation.binanceAccount.usdt.free) + " USDT";
            this.lblneedbalance.Text = Math.Round(coinneed * currentprice, 4).ToString() + " USD";
            this.lblestbalance.Text = Math.Round(estcoin, 4).ToString() + " USD";
        }

        private void v2Label1_Click(object sender, System.EventArgs e)
        {

        }

        public void updateWarning(string text)
        {
            lblWarning.Text = text;
        }

        public void updateSlotandEpoch(string epoch, string slot, string nextepoch, string date)
        {
            this.lblEpoch.Text = epoch;
            this.lblSlot.Text = slot + " / 432000";
            this.lblnextepoch.Text = nextepoch;
            this.lblstartepoch.Text = date;
        }
    }
}
