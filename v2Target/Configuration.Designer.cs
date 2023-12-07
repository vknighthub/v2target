
using System.Windows.Forms;
using v2Framework.Controls;

namespace v2Target
{
    partial class Configuration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.pnContent = new v2Framework.Controls.v2Panel();
            this.txbReward = new System.Windows.Forms.NumericUpDown();
            this.txbPriceChange = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new v2Target.Component.v2ImageButton();
            this.btnAccept = new v2Target.Component.v2ImageButton();
            this.lblPriceTier = new System.Windows.Forms.Label();
            this.lblReward = new System.Windows.Forms.Label();
            this.lblEstimateIncome = new System.Windows.Forms.Label();
            this.txbEstimateIncome = new System.Windows.Forms.TextBox();
            this.lblCurrentPair = new System.Windows.Forms.Label();
            this.txbCurrentCoin = new System.Windows.Forms.TextBox();
            this.lblSecretkey = new System.Windows.Forms.Label();
            this.txbSecretkey = new System.Windows.Forms.TextBox();
            this.lblAPIKEY = new System.Windows.Forms.Label();
            this.txbApikey = new System.Windows.Forms.TextBox();
            this.lblSpendingPass = new System.Windows.Forms.Label();
            this.txbWalletPass = new System.Windows.Forms.TextBox();
            this.lblChooseWallet = new System.Windows.Forms.Label();
            this.btnAddWallet = new v2Target.Component.v2ImageButton();
            this.cboWalletid = new System.Windows.Forms.ComboBox();
            this.lblHeaderContent = new System.Windows.Forms.Label();
            this.pnTitle = new v2Framework.Controls.v2Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnRemoteButton = new v2Framework.Controls.v2Panel();
            this.imgCloseButton = new System.Windows.Forms.PictureBox();
            this.pnHeader = new v2Framework.Controls.v2Panel();
            this.pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbReward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPriceChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddWallet)).BeginInit();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnRemoteButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseButton)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.Transparent;
            this.pnContent.BackgroundImage = global::v2Target.Properties.Resources.background_1;
            this.pnContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnContent.Controls.Add(this.txbReward);
            this.pnContent.Controls.Add(this.txbPriceChange);
            this.pnContent.Controls.Add(this.btnRefresh);
            this.pnContent.Controls.Add(this.btnAccept);
            this.pnContent.Controls.Add(this.lblPriceTier);
            this.pnContent.Controls.Add(this.lblReward);
            this.pnContent.Controls.Add(this.lblEstimateIncome);
            this.pnContent.Controls.Add(this.txbEstimateIncome);
            this.pnContent.Controls.Add(this.lblCurrentPair);
            this.pnContent.Controls.Add(this.txbCurrentCoin);
            this.pnContent.Controls.Add(this.lblSecretkey);
            this.pnContent.Controls.Add(this.txbSecretkey);
            this.pnContent.Controls.Add(this.lblAPIKEY);
            this.pnContent.Controls.Add(this.txbApikey);
            this.pnContent.Controls.Add(this.lblSpendingPass);
            this.pnContent.Controls.Add(this.txbWalletPass);
            this.pnContent.Controls.Add(this.lblChooseWallet);
            this.pnContent.Controls.Add(this.btnAddWallet);
            this.pnContent.Controls.Add(this.cboWalletid);
            this.pnContent.Controls.Add(this.lblHeaderContent);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnContent.Location = new System.Drawing.Point(0, 43);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(925, 325);
            this.pnContent.TabIndex = 12;
            // 
            // txbReward
            // 
            this.txbReward.DecimalPlaces = 2;
            this.txbReward.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbReward.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txbReward.Location = new System.Drawing.Point(705, 110);
            this.txbReward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbReward.Name = "txbReward";
            this.txbReward.Size = new System.Drawing.Size(190, 27);
            this.txbReward.TabIndex = 31;
            this.txbReward.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbReward.ThousandsSeparator = true;
            this.txbReward.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // txbPriceChange
            // 
            this.txbPriceChange.DecimalPlaces = 2;
            this.txbPriceChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPriceChange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txbPriceChange.Location = new System.Drawing.Point(705, 155);
            this.txbPriceChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPriceChange.Name = "txbPriceChange";
            this.txbPriceChange.Size = new System.Drawing.Size(190, 27);
            this.txbPriceChange.TabIndex = 32;
            this.txbPriceChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbPriceChange.ThousandsSeparator = true;
            this.txbPriceChange.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.Location = new System.Drawing.Point(402, 65);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PointImageActive = new System.Drawing.Point(0, 0);
            this.btnRefresh.Size = new System.Drawing.Size(35, 24);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Zoom = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.Image = global::v2Target.Properties.Resources.tick;
            this.btnAccept.ImageActive = null;
            this.btnAccept.Location = new System.Drawing.Point(824, 263);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.PointImageActive = new System.Drawing.Point(0, 0);
            this.btnAccept.Size = new System.Drawing.Size(71, 51);
            this.btnAccept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAccept.TabIndex = 28;
            this.btnAccept.TabStop = false;
            this.btnAccept.Zoom = 10;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblPriceTier
            // 
            this.lblPriceTier.AutoSize = true;
            this.lblPriceTier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriceTier.ForeColor = System.Drawing.Color.White;
            this.lblPriceTier.Location = new System.Drawing.Point(520, 158);
            this.lblPriceTier.Name = "lblPriceTier";
            this.lblPriceTier.Size = new System.Drawing.Size(170, 21);
            this.lblPriceTier.TabIndex = 25;
            this.lblPriceTier.Text = "Price change tier (%)";
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReward.ForeColor = System.Drawing.Color.White;
            this.lblReward.Location = new System.Drawing.Point(520, 113);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(157, 21);
            this.lblReward.TabIndex = 23;
            this.lblReward.Text = "Reward rate / year";
            // 
            // lblEstimateIncome
            // 
            this.lblEstimateIncome.AutoSize = true;
            this.lblEstimateIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstimateIncome.ForeColor = System.Drawing.Color.White;
            this.lblEstimateIncome.Location = new System.Drawing.Point(520, 68);
            this.lblEstimateIncome.Name = "lblEstimateIncome";
            this.lblEstimateIncome.Size = new System.Drawing.Size(123, 21);
            this.lblEstimateIncome.TabIndex = 21;
            this.lblEstimateIncome.Text = "Est. income ($)";
            // 
            // txbEstimateIncome
            // 
            this.txbEstimateIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbEstimateIncome.Location = new System.Drawing.Point(705, 65);
            this.txbEstimateIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEstimateIncome.Name = "txbEstimateIncome";
            this.txbEstimateIncome.Size = new System.Drawing.Size(190, 27);
            this.txbEstimateIncome.TabIndex = 20;
            this.txbEstimateIncome.Text = "100";
            this.txbEstimateIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCurrentPair
            // 
            this.lblCurrentPair.AutoSize = true;
            this.lblCurrentPair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentPair.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPair.Location = new System.Drawing.Point(22, 248);
            this.lblCurrentPair.Name = "lblCurrentPair";
            this.lblCurrentPair.Size = new System.Drawing.Size(113, 21);
            this.lblCurrentPair.TabIndex = 19;
            this.lblCurrentPair.Text = "Currency Pair";
            // 
            // txbCurrentCoin
            // 
            this.txbCurrentCoin.Enabled = false;
            this.txbCurrentCoin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCurrentCoin.Location = new System.Drawing.Point(205, 245);
            this.txbCurrentCoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCurrentCoin.Name = "txbCurrentCoin";
            this.txbCurrentCoin.Size = new System.Drawing.Size(274, 27);
            this.txbCurrentCoin.TabIndex = 18;
            this.txbCurrentCoin.Text = "ADA/USDT";
            // 
            // lblSecretkey
            // 
            this.lblSecretkey.AutoSize = true;
            this.lblSecretkey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecretkey.ForeColor = System.Drawing.Color.White;
            this.lblSecretkey.Location = new System.Drawing.Point(22, 203);
            this.lblSecretkey.Name = "lblSecretkey";
            this.lblSecretkey.Size = new System.Drawing.Size(91, 21);
            this.lblSecretkey.TabIndex = 17;
            this.lblSecretkey.Text = "Secret Key";
            // 
            // txbSecretkey
            // 
            this.txbSecretkey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSecretkey.Location = new System.Drawing.Point(205, 200);
            this.txbSecretkey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSecretkey.Name = "txbSecretkey";
            this.txbSecretkey.Size = new System.Drawing.Size(274, 27);
            this.txbSecretkey.TabIndex = 16;
            this.txbSecretkey.GotFocus += new System.EventHandler(this.scecretkey_FocusIn);
            this.txbSecretkey.LostFocus += new System.EventHandler(this.scecretkey_FocusOut);
            // 
            // lblAPIKEY
            // 
            this.lblAPIKEY.AutoSize = true;
            this.lblAPIKEY.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAPIKEY.ForeColor = System.Drawing.Color.White;
            this.lblAPIKEY.Location = new System.Drawing.Point(22, 158);
            this.lblAPIKEY.Name = "lblAPIKEY";
            this.lblAPIKEY.Size = new System.Drawing.Size(68, 21);
            this.lblAPIKEY.TabIndex = 15;
            this.lblAPIKEY.Text = "API Key";
            // 
            // txbApikey
            // 
            this.txbApikey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbApikey.Location = new System.Drawing.Point(205, 155);
            this.txbApikey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbApikey.Name = "txbApikey";
            this.txbApikey.Size = new System.Drawing.Size(274, 27);
            this.txbApikey.TabIndex = 14;
            this.txbApikey.GotFocus += new System.EventHandler(this.apikey_FocusIn);
            this.txbApikey.LostFocus += new System.EventHandler(this.apikey_FocusOut);
            // 
            // lblSpendingPass
            // 
            this.lblSpendingPass.AutoSize = true;
            this.lblSpendingPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSpendingPass.ForeColor = System.Drawing.Color.White;
            this.lblSpendingPass.Location = new System.Drawing.Point(22, 113);
            this.lblSpendingPass.Name = "lblSpendingPass";
            this.lblSpendingPass.Size = new System.Drawing.Size(162, 21);
            this.lblSpendingPass.TabIndex = 13;
            this.lblSpendingPass.Text = "Spending password";
            // 
            // txbWalletPass
            // 
            this.txbWalletPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbWalletPass.Location = new System.Drawing.Point(205, 110);
            this.txbWalletPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbWalletPass.Name = "txbWalletPass";
            this.txbWalletPass.Size = new System.Drawing.Size(274, 27);
            this.txbWalletPass.TabIndex = 4;
            this.txbWalletPass.UseSystemPasswordChar = true;
            // 
            // lblChooseWallet
            // 
            this.lblChooseWallet.AutoSize = true;
            this.lblChooseWallet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseWallet.ForeColor = System.Drawing.Color.White;
            this.lblChooseWallet.Location = new System.Drawing.Point(22, 68);
            this.lblChooseWallet.Name = "lblChooseWallet";
            this.lblChooseWallet.Size = new System.Drawing.Size(121, 21);
            this.lblChooseWallet.TabIndex = 3;
            this.lblChooseWallet.Text = "Choose wallet";
            // 
            // btnAddWallet
            // 
            this.btnAddWallet.BackColor = System.Drawing.Color.Transparent;
            this.btnAddWallet.Image = global::v2Target.Properties.Resources.wallet;
            this.btnAddWallet.ImageActive = null;
            this.btnAddWallet.Location = new System.Drawing.Point(442, 65);
            this.btnAddWallet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddWallet.Name = "btnAddWallet";
            this.btnAddWallet.PointImageActive = new System.Drawing.Point(0, 0);
            this.btnAddWallet.Size = new System.Drawing.Size(37, 24);
            this.btnAddWallet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddWallet.TabIndex = 2;
            this.btnAddWallet.TabStop = false;
            this.btnAddWallet.Zoom = 10;
            this.btnAddWallet.Click += new System.EventHandler(this.btnAddWallet_Click);
            // 
            // cboWalletid
            // 
            this.cboWalletid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboWalletid.FormattingEnabled = true;
            this.cboWalletid.Location = new System.Drawing.Point(205, 65);
            this.cboWalletid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboWalletid.Name = "cboWalletid";
            this.cboWalletid.Size = new System.Drawing.Size(192, 29);
            this.cboWalletid.TabIndex = 1;
            // 
            // lblHeaderContent
            // 
            this.lblHeaderContent.AutoSize = true;
            this.lblHeaderContent.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderContent.ForeColor = System.Drawing.Color.White;
            this.lblHeaderContent.Location = new System.Drawing.Point(359, 9);
            this.lblHeaderContent.Name = "lblHeaderContent";
            this.lblHeaderContent.Size = new System.Drawing.Size(286, 32);
            this.lblHeaderContent.TabIndex = 0;
            this.lblHeaderContent.Text = "System configuration";
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnTitle.Controls.Add(this.imgLogo);
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(895, 29);
            this.pnTitle.TabIndex = 3;
            this.pnTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = global::v2Target.Properties.Resources.Logo_White;
            this.imgLogo.Location = new System.Drawing.Point(2, 7);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(46, 21);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            this.imgLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(49, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "v2Target (V1.0.0)";
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // pnRemoteButton
            // 
            this.pnRemoteButton.BackColor = System.Drawing.Color.Transparent;
            this.pnRemoteButton.Controls.Add(this.imgCloseButton);
            this.pnRemoteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRemoteButton.Location = new System.Drawing.Point(887, 0);
            this.pnRemoteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnRemoteButton.Name = "pnRemoteButton";
            this.pnRemoteButton.Size = new System.Drawing.Size(38, 43);
            this.pnRemoteButton.TabIndex = 5;
            this.pnRemoteButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // imgCloseButton
            // 
            this.imgCloseButton.BackgroundImage = global::v2Target.Properties.Resources.multiply;
            this.imgCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgCloseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgCloseButton.Location = new System.Drawing.Point(14, 6);
            this.imgCloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgCloseButton.Name = "imgCloseButton";
            this.imgCloseButton.Size = new System.Drawing.Size(18, 20);
            this.imgCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCloseButton.TabIndex = 0;
            this.imgCloseButton.TabStop = false;
            this.imgCloseButton.Click += new System.EventHandler(this.imgCloseButton_Click);
            // 
            // pnHeader
            // 
            this.pnHeader.BackgroundImage = global::v2Target.Properties.Resources.Header;
            this.pnHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnHeader.Controls.Add(this.pnRemoteButton);
            this.pnHeader.Controls.Add(this.pnTitle);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(925, 43);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 368);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbReward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPriceChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddWallet)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnRemoteButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseButton)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private v2Panel pnContent;
        private v2Panel pnTitle;
        private PictureBox imgLogo;
        private Label lblTitle;
        private v2Panel pnRemoteButton;
        private PictureBox imgCloseButton;
        private v2Panel pnHeader;
        private Label lblChooseWallet;
        private Component.v2ImageButton btnAddWallet;
        private ComboBox cboWalletid;
        private Label lblSpendingPass;
        private Label lblAPIKEY;
        private Label lblSecretkey;
        private Label lblCurrentPair;
        private Label lblPriceTier;
        private Label lblReward;
        private Label lblEstimateIncome;
        private Component.v2ImageButton btnRefresh;
        private Component.v2ImageButton btnAccept;
        private TextBox txbWalletPass;
        private TextBox txbApikey;
        private TextBox txbSecretkey;
        private TextBox txbCurrentCoin;
        private TextBox txbEstimateIncome;
        private NumericUpDown txbReward;
        private NumericUpDown txbPriceChange;
        private Label lblHeaderContent;
    }
}

