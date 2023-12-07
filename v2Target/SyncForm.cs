using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using v2Framework.Uitls;
using v2Framework.Uitls.Cardano;

namespace v2Target
{
    public partial class SyncForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static int cmdnodeid;
        public static int cmdwalletid;
        Cmd cmdnode;
        Cmd cmdwallet;
        public bool issync = false;
        CardanoAPI cardanoAPI;
        public SyncForm()
        {
            InitializeComponent();
            cardanoAPI = new CardanoAPI("http://localhost:4002");

            if (!IsProcessOpen("cardano-node"))
            {
                cmdnode = new Cmd();
                string cardanonode = "run --config " + Application.StartupPath + "spec\\mainnet\\mainnet-config.json --topology " + Application.StartupPath + "spec\\mainnet\\mainnet-topology.json --database-path " + Application.StartupPath + "Database --socket-path \\\\.\\pipe\\cardano-node-mainnet";
                SyncForm.cmdnodeid = cmdnode.ExecuteProcess(Application.StartupPath + "cardano-node.exe", cardanonode, true);
            }
            if (!IsProcessOpen("cardano-wallet"))
            {
                cmdwallet = new Cmd();
                string cardanowalletstr = "serve --node-socket \\\\.\\pipe\\cardano-node-mainnet --mainnet --database " + Application.StartupPath + "Walletdb";
                SyncForm.cmdwalletid = cmdwallet.ExecuteProcess(Application.StartupPath + "cardano-wallet.exe", cardanowalletstr, true);
            }
            this.bgWorker.RunWorkerAsync(2000);
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
            Application.Exit();
        }


        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (!issync)
            {
                TimeConsumingOperation();
                Thread.Sleep(10000);
            }
        }

        private void TimeConsumingOperation()
        {

            Response response = cardanoAPI.getNetworkInformation();

            if (response.code != 0)
            {

            }
            else
            {
                JObject sync = JObject.Parse(JObject.Parse(response.result).GetValue("sync_progress").ToString());
                string status = sync.GetValue("status").ToString();
                JObject processsync = JObject.Parse(sync.GetValue("progress").ToString());

                string syncpro = processsync.GetValue("quantity").ToString();

                lblStatusDetail.Invoke(new Action(() =>
                {
                    lblStatusDetail.Text = status + " (" + syncpro + "%)";
                }));
                if (double.Parse(syncpro) >= 100)
                {
                    issync = true;
                }
            }
        }

        private void SyncForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit app?", "v2Target", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cmd.KillProcessAndChildren(SyncForm.cmdwalletid);
                Cmd.KillProcessAndChildren(SyncForm.cmdnodeid);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (v2Target.Properties.Settings.Default.isconfig)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                Configuration configuration = new Configuration();
                configuration.Show();
            }

            this.Hide();
        }

        public bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
