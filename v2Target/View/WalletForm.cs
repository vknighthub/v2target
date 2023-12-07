using System;
using System.Windows.Forms;
using v2Framework.Models;
using v2Target.View.Wallet;

namespace v2Target.View
{
    public partial class WalletForm : UserControl
    {
        private UserControl activeForm;

        Binance binance = new Binance();
        Ada ada = new Ada();
        Summary summary = new Summary();

        public WalletForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            OpenChildForm(this.summary);
        }
        private void OpenChildForm(UserControl childForm)
        {
            activeForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.Size = this.pnContains.Size;
            this.pnContains.Controls.Clear();
            this.pnContains.Controls.Add(childForm);
            this.pnContains.Tag = childForm;
        }

        private void btnSummany_Click(object sender, EventArgs e)
        {
            OpenChildForm(this.summary);
        }

        private void btnAda_Click(object sender, EventArgs e)
        {
            OpenChildForm(this.ada);
        }

        private void btnBinance_Click(object sender, EventArgs e)
        {
            OpenChildForm(this.binance);
        }

        public void UpdateDataAda(WalletItem walletItem)
        {
            ada.updateData(walletItem);
        }

        public void UpdateDataBinance(BinanceAccount binanceAccount)
        {
            binance.updateData(binanceAccount);
        }

        public void UpdateDataAll(WalletInformation walletInformation)
        {
            summary.updateData(walletInformation);
            this.lbltotalada.Text = (walletInformation.currentWallet.balance.total.quantity/1000000) + double.Parse(walletInformation.binanceAccount.ada.free) + " ADA";
        }

        public void BinanceLoadOrders(string orderpending, string orderscomplete)
        {
            binance.loadListOrder(orderpending, orderscomplete);
        }

        public void AdaLoadAddress(string data)
        {
            ada.loadListAddress(data);
        }

        public void updateWarning(string text)
        {
            summary.updateWarning(text);
        }

        public void updateEoch(string epoch, string slot, string nextepoch, string date)
        {
            summary.updateSlotandEpoch(epoch, slot, nextepoch, date);
        }
    }
}
