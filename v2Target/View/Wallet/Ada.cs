using System.Windows.Forms;
using v2Framework.Controls;
using v2Framework.Models;

namespace v2Target.View.Wallet
{
    public partial class Ada : UserControl
    {
        public Ada()
        {
            InitializeComponent(); 
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        public void updateData(WalletItem walletItem)
        {
            this.lblavai.Text = (walletItem.balance.available.quantity / 1000000).ToString() + " ADA";
            this.lblreward.Text = (walletItem.balance.reward.quantity / 1000000).ToString() + " ADA";
            this.lbltotal.Text = (walletItem.balance.total.quantity / 1000000).ToString() + " ADA";
            this.lblstatus.Text = walletItem.state.status;
        }

        public void loadListAddress(string data)
        {
            v2ListAddress.Data = data;
        }
    }
}
