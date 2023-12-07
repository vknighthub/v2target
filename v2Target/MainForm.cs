using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using v2Framework.Uitls;
using v2Framework.Uitls.Cardano;
using v2Target.Class;
using v2Target.View;

namespace v2Target
{
    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        WalletForm walletFrom = new WalletForm();
        TradeForm tradeform = new TradeForm();
        TradingForm tradingform = new TradingForm();
        DonateForm donetFrom = new DonateForm();
        bool tradeFormLoaded = false;

        BackgroundWorker bg;
        BackgroundTask task;

        bool isLoad = false;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public MainForm()
        {
            InitializeComponent();
            
            CardanoAPI cardanoAPI = new CardanoAPI("http://localhost:4002");
            OpenChildForm(walletFrom);
            task = new BackgroundTask();
            task.StartTask();

            bg = new BackgroundWorker();
            bg.DoWork += Bg_DoWork;
            bg.RunWorkerAsync();
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (isLoad)
                    UpdateFormInformation();
                Thread.Sleep(1000);
            }
        }


        public void UpdateFormInformation()
        {
                this.Invoke(new Action(() =>
                {
                    walletFrom.updateEoch(task.walletInformation.epoch, task.walletInformation.slot, task.walletInformation.nextepoch, task.walletInformation.date);

                    if (task.walletInformation.currentWallet != null && task.walletInformation.binanceAccount != null)
                    {
                        walletFrom.UpdateDataAll(task.walletInformation);
                        walletFrom.UpdateDataAda(task.walletInformation.currentWallet);
                        walletFrom.UpdateDataBinance(task.walletInformation.binanceAccount);
                        
                        if (task.walletInformation.listAddress != null && task.walletInformation.listAddress.Count > 0)
                            walletFrom.AdaLoadAddress(task.walletInformation.listAddress.ToString());
                        if (task.walletInformation.listOrderPending != null && task.walletInformation.listOrderComplete != null)
                            walletFrom.BinanceLoadOrders(task.walletInformation.listOrderPending.ToString(), task.walletInformation.listOrderComplete.ToString());
                        tradingform.BinanceLoadOrders(task.tradingInformation.listOrderPending.ToString(), task.tradingInformation.listOrderComplete.ToString());
                    }

                    if (task.tradingInformation.binanceAccount != null)
                    {
                        tradingform.UpdateDataBinance(task.tradingInformation, task.tradingInformation.binanceAccount);
                        if (task.tradingInformation.listOrderPending != null && task.tradingInformation.listOrderComplete != null)
                            tradingform.BinanceLoadOrders(task.tradingInformation.listOrderPending.ToString(), task.tradingInformation.listOrderComplete.ToString());
                    }

                    if (tradeFormLoaded)
                    {
                        if (task.walletInformation.tradeList != null && task.walletInformation.tradeList.Count > 0)
                            tradeform.LoadTradeList(task.walletInformation.tradeList.ToString());
                    }

                    if (task.walletInformation.currentWallet == null)
                    {
                        walletFrom.updateWarning("Cardano wallet didn't started or it already failed. Please restart it");
                    }else if (task.walletInformation.binanceAccount == null)
                    {
                        walletFrom.updateWarning("Connect to binance have an error. Please try again later or restart this app");
                    }else if (task.walletInformation.currentWallet != null && task.walletInformation.currentWallet.state.Equals("syncing"))
                    {
                        walletFrom.updateWarning("Cardano is in syncing state. Please wait until it synced 100%");
                    }
                    else
                    {
                        walletFrom.updateWarning("");
                    }
                }));
        }


        private void OpenChildForm(UserControl childForm)
        {
            childForm.Dock = DockStyle.Fill;
            childForm.Size = this.pnLeftMenu.Size;
            this.pnContent.Controls.Clear();
            this.pnContent.Controls.Add(childForm);
            this.pnContent.Tag = childForm;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }


        private void imgCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            OpenChildForm(this.walletFrom);
        }

        private void btnTrading_Click(object sender, EventArgs e)
        {
            OpenChildForm(this.tradingform);
            tradeFormLoaded = true;
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            OpenChildForm(this.tradeform);
            tradeFormLoaded = true;
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            OpenChildForm(this.donetFrom);
        }

        private void btnsupport_Click(object sender, EventArgs e)
        {
            Support support = new Support();
            support.ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Configuration config = new Configuration();
            config.IsDialog();
            config.ShowDialog();
        }

        private void btnConfigTrading_Click(object sender, EventArgs e)
        {
            ConfigurationTrading config = new ConfigurationTrading();
            config.IsDialog();
            config.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void btnMinimal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!isLoad)
                isLoad = true;
        }
    }
}
