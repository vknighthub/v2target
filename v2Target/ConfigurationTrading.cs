using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using v2Framework.Models;
using v2Framework.Uitls;
using v2Framework.Uitls.Cardano;


namespace v2Target
{
    public partial class ConfigurationTrading : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private string api_key_hide = "";
        private string secret_key_hide = "";
        private string api_key_show = "";
        private string secret_key_show = "";

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Dictionary<string, string> comboSource = new Dictionary<string, string>();

        bool thisdialog = false;

        public ConfigurationTrading()
        {
            InitializeComponent();
            this.txbAmountTrading.Focus();
            this.txbAmountTrading.Text = v2Target.Properties.Settings.Default.AMOUNT_TRADING.ToString();
            this.txbTradingRange.Value = (decimal)v2Target.Properties.Settings.Default.TRADING_RANGE;
            this.api_key_show = v2Target.Properties.Settings.Default.API_KEY_TRADING;
            this.secret_key_show = v2Target.Properties.Settings.Default.SECRET_KEY_TRADING;
            LoadCombobox();
            set_apikey_hide();
            set_secret_hide();
            this.txbApikeyTrading.Text = this.api_key_hide;
            this.txbSecretkeytrading.Text = this.secret_key_hide;
        }

        public void IsDialog()
        {
            this.thisdialog = true;
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
            if (this.thisdialog)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }

        }

        private void btnAddWallet_Click(object sender, EventArgs e)
        {
            AddWallet wallet = new AddWallet();
            wallet.ShowDialog();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.api_key_show.Equals("") || this.secret_key_show.Equals("") || this.txbAmountTrading.Text.Equals("") || this.txbTradingRange.Value.ToString().Equals(""))
            {
                MessageBox.Show("Please input all information before save!", "v2Target");
            }
            else
            {
                v2Target.Properties.Settings.Default.API_KEY_TRADING = this.api_key_show;
                v2Target.Properties.Settings.Default.SECRET_KEY_TRADING = this.secret_key_show;
                v2Target.Properties.Settings.Default.AMOUNT_TRADING = double.Parse(this.txbAmountTrading.Text);
                v2Target.Properties.Settings.Default.TRADING_RANGE = decimal.ToDouble(this.txbTradingRange.Value);

                String isEnable = this.cboEnableTrading.SelectedValue.ToString();

                if (isEnable.Equals("false")) {
                    v2Target.Properties.Settings.Default.ENABLE_TRADING = false;
                }
                else
                {
                    v2Target.Properties.Settings.Default.ENABLE_TRADING = true;
                }

                v2Target.Properties.Settings.Default.Save();

                if (this.thisdialog)
                {
                    this.Close();
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
        }

        public void LoadCombobox()
        {
            comboSource.Clear();
            comboSource.Add("true", "true");
            comboSource.Add("false", "false");
            cboEnableTrading.DataSource = new BindingSource(comboSource, null);
            cboEnableTrading.DisplayMember = "Value";
            cboEnableTrading.ValueMember = "Key";

            bool isEnable = v2Target.Properties.Settings.Default.ENABLE_TRADING;

            if (isEnable)
            {
                this.cboEnableTrading.SelectedValue = "true";
            }
            else
            {
                this.cboEnableTrading.SelectedValue = "false";
            }
        }

        private void set_apikey_hide()
        {
            if (this.api_key_show.Length > 3)
            {
                this.api_key_hide = this.api_key_show.Substring(0, 3) + "*********" + this.api_key_show.Substring(this.api_key_show.Length - 3);

            }
            else
            {
                this.api_key_hide = this.api_key_show;

            }
        }
        private void set_secret_hide()
        {
            if (this.secret_key_show.Length > 3)
            {
                this.secret_key_hide = this.secret_key_show.Substring(0, 3) + "*********" + this.secret_key_show.Substring(this.secret_key_show.Length - 3);

            }
            else
            {
                this.secret_key_hide = this.secret_key_show;

            }
        }

        private void apikey_FocusIn(object sender, EventArgs e)
        {
            this.txbApikeyTrading.Text = this.api_key_show;
            this.txbApikeyTrading.SelectionStart = this.txbApikeyTrading.Text.Length;
        }
        private void apikey_FocusOut(object sender, EventArgs e)
        {
            this.api_key_show = this.txbApikeyTrading.Text;
            set_apikey_hide();
            this.txbApikeyTrading.Text = this.api_key_hide;
        }
        private void scecretkey_FocusIn(object sender, EventArgs e)
        {
            this.txbSecretkeytrading.Text = this.secret_key_show;
            this.txbSecretkeytrading.SelectionStart = this.txbSecretkeytrading.Text.Length;
        }
        private void scecretkey_FocusOut(object sender, EventArgs e)
        {
            this.secret_key_show = this.txbSecretkeytrading.Text;
            set_secret_hide();
            this.txbSecretkeytrading.Text = this.secret_key_hide;
        }
    }
}
