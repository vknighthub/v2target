using System;
using System.Windows.Forms;
using v2Framework.Models;
using v2Target.View.Trading;

namespace v2Target.View
{
    public partial class TradingForm : UserControl
    {
        private UserControl activeForm;

        Binance binance = new Binance();
        Summary summary = new Summary();

        public TradingForm()
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

        private void btnBinance_Click(object sender, EventArgs e)
        {
            OpenChildForm(this.binance);
        }

        public void UpdateDataBinance(TradingInformation tradingInformation, BinanceAccount binanceAccount)
        {
            this.lbltotalada.Text = double.Parse(tradingInformation.binanceAccount.ada.free) + " ADA";
            binance.updateData(binanceAccount);
            summary.updateData(tradingInformation);
        }

        public void BinanceLoadOrders(string orderpending, string orderscomplete)
        {
            binance.loadListOrder(orderpending, orderscomplete);
        }

        public void updateWarning(string text)
        {
            summary.updateWarning(text);
        }
    }
}
