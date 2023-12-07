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
    public partial class Configuration : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private string api_key_hide = "";
        private string secret_key_hide = "";
        private string api_key_show = "";
        private string secret_key_show = "";
        CardanoAPI cardanoAPI;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Dictionary<string, string> comboSource = new Dictionary<string, string>();

        bool thisdialog = false;
        public Configuration()
        {
            InitializeComponent();
            cardanoAPI = new CardanoAPI("http://localhost:4002");
            UpdateCombobox();
            this.txbWalletPass.Text = v2Target.Properties.Settings.Default.PASSWALLET;
            this.txbEstimateIncome.Text = v2Target.Properties.Settings.Default.TARGET.ToString();
            this.txbReward.Value = (decimal)v2Target.Properties.Settings.Default.INTRATE;
            this.txbPriceChange.Value = (decimal)v2Target.Properties.Settings.Default.EXRATECHANGE;
            this.api_key_show = v2Target.Properties.Settings.Default.API_KEY;
            this.secret_key_show = v2Target.Properties.Settings.Default.SECRET_KEY;
            set_apikey_hide();
            set_secret_hide();
            this.txbApikey.Text = this.api_key_hide;
            this.txbSecretkey.Text = this.secret_key_hide;
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
            if (this.api_key_show.Equals("") || this.secret_key_show.Equals("") || this.txbWalletPass.Text.Equals("")
                || this.txbEstimateIncome.Text.Equals("") || this.txbReward.Value.ToString().Equals("") || this.txbPriceChange.Value.ToString().Equals(""))
            {
                MessageBox.Show("Please input all information before save!", "v2Target");
            }
            else
            {
                if (this.cboWalletid.Items.Count <= 1 || (this.cboWalletid.SelectedIndex != -1 && this.cboWalletid.SelectedValue.ToString().Equals("-")))
                {
                    MessageBox.Show("Please import your wallet!", "v2Target");
                }
                else
                {
                    //v2Target.Properties.Settings.Default.API_KEY = this.apikey.Text;
                    v2Target.Properties.Settings.Default.API_KEY = this.api_key_show;
                    v2Target.Properties.Settings.Default.SECRET_KEY = this.secret_key_show;
                    v2Target.Properties.Settings.Default.PASSWALLET = this.txbWalletPass.Text;
                    v2Target.Properties.Settings.Default.WALLETID = this.cboWalletid.SelectedValue.ToString();
                    v2Target.Properties.Settings.Default.TARGET = double.Parse(this.txbEstimateIncome.Text);
                    v2Target.Properties.Settings.Default.INTRATE = decimal.ToDouble(this.txbReward.Value);
                    v2Target.Properties.Settings.Default.EXRATECHANGE = decimal.ToDouble(this.txbPriceChange.Value);
                    v2Target.Properties.Settings.Default.isconfig = true;
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
        }

        public void UpdateCombobox()
        {
            Response response = cardanoAPI.getListWallet();
            if (response.code != 0)
            {
                MessageBox.Show("Can't connect to Cardano wallet. Please check you connection", "v2Target");
                Application.Exit();
            }
            else
            {
                JArray array = JArray.Parse(response.result);
                JObject reponse = new JObject();
                reponse.Add("walletlist", array);
                ListWallet list = JsonConvert.DeserializeObject<ListWallet>(reponse.ToString());

                comboSource.Clear();
                comboSource.Add("-", "Select your wallet");
                for (int i = 0; i < list.walletlist.Count; i++)
                {
                    comboSource.Add(list.walletlist[i].id, list.walletlist[i].name);
                }
                cboWalletid.DataSource = new BindingSource(comboSource, null);
                cboWalletid.DisplayMember = "Value";
                cboWalletid.ValueMember = "Key";

                this.cboWalletid.SelectedValue = v2Target.Properties.Settings.Default.WALLETID;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateCombobox();
        }

        private void apikey_FocusIn(object sender, EventArgs e)
        {
            this.txbApikey.Text = this.api_key_show;
            this.txbApikey.SelectionStart = this.txbApikey.Text.Length;
        }
        private void apikey_FocusOut(object sender, EventArgs e)
        {
            this.api_key_show = this.txbApikey.Text;
            set_apikey_hide();
            this.txbApikey.Text = this.api_key_hide;
        }
        private void scecretkey_FocusIn(object sender, EventArgs e)
        {
            this.txbSecretkey.Text = this.secret_key_show;
            this.txbSecretkey.SelectionStart = this.txbSecretkey.Text.Length;
        }
        private void scecretkey_FocusOut(object sender, EventArgs e)
        {
            this.secret_key_show = this.txbSecretkey.Text;
            set_secret_hide();
            this.txbSecretkey.Text = this.secret_key_hide;
        }
    }
}
