using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using v2Framework.Models;
using v2Framework.Uitls;
using v2Framework.Uitls.Cardano;

namespace v2Target
{
    public partial class AddWallet : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        CardanoAPI cardanoAPI;

        public AddWallet()
        {
            InitializeComponent();
            cardanoAPI = new CardanoAPI("http://localhost:4002");
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void imgCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void v2ImageButton5_ClickAsync(object sender, EventArgs e)
        {
            Response response = cardanoAPI.addWallet(txbWalletName.Text, txbPassword.Text, txbPassphare.Text);
               
            if (response.code != 0)
            {
                MessageBox.Show(response.msg, "Add/Restore Wallet");
            }
            else
            {
                this.Close();
            }
        }
    }
}
