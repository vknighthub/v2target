
using System.Windows.Forms;
using v2Framework.Controls;

namespace v2Target
{
    partial class ConfigurationTrading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationTrading));
            this.pnContent = new v2Framework.Controls.v2Panel();
            this.txbTradingRange = new System.Windows.Forms.NumericUpDown();
            this.btnAccept = new v2Target.Component.v2ImageButton();
            this.lblPriceTier = new System.Windows.Forms.Label();
            this.lblSecretkey = new System.Windows.Forms.Label();
            this.txbSecretkeytrading = new System.Windows.Forms.TextBox();
            this.lblAPIKEY = new System.Windows.Forms.Label();
            this.txbApikeyTrading = new System.Windows.Forms.TextBox();
            this.lblHeaderContent = new System.Windows.Forms.Label();
            this.pnTitle = new v2Framework.Controls.v2Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnRemoteButton = new v2Framework.Controls.v2Panel();
            this.imgCloseButton = new System.Windows.Forms.PictureBox();
            this.pnHeader = new v2Framework.Controls.v2Panel();
            this.txbAmountTrading = new System.Windows.Forms.TextBox();
            this.lblEstimateIncome = new System.Windows.Forms.Label();
            this.lblCurrentPair = new System.Windows.Forms.Label();
            this.cboEnableTrading = new System.Windows.Forms.ComboBox();
            this.pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbTradingRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).BeginInit();
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
            this.pnContent.Controls.Add(this.cboEnableTrading);
            this.pnContent.Controls.Add(this.txbTradingRange);
            this.pnContent.Controls.Add(this.btnAccept);
            this.pnContent.Controls.Add(this.lblPriceTier);
            this.pnContent.Controls.Add(this.lblEstimateIncome);
            this.pnContent.Controls.Add(this.txbAmountTrading);
            this.pnContent.Controls.Add(this.lblCurrentPair);
            this.pnContent.Controls.Add(this.lblSecretkey);
            this.pnContent.Controls.Add(this.txbSecretkeytrading);
            this.pnContent.Controls.Add(this.lblAPIKEY);
            this.pnContent.Controls.Add(this.txbApikeyTrading);
            this.pnContent.Controls.Add(this.lblHeaderContent);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnContent.Location = new System.Drawing.Point(0, 43);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(672, 404);
            this.pnContent.TabIndex = 12;
            // 
            // txbTradingRange
            // 
            this.txbTradingRange.DecimalPlaces = 2;
            this.txbTradingRange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbTradingRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txbTradingRange.Location = new System.Drawing.Point(270, 257);
            this.txbTradingRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTradingRange.Name = "txbTradingRange";
            this.txbTradingRange.Size = new System.Drawing.Size(317, 27);
            this.txbTradingRange.TabIndex = 32;
            this.txbTradingRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbTradingRange.ThousandsSeparator = true;
            this.txbTradingRange.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.Image = global::v2Target.Properties.Resources.tick;
            this.btnAccept.ImageActive = null;
            this.btnAccept.Location = new System.Drawing.Point(560, 317);
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
            this.lblPriceTier.Location = new System.Drawing.Point(65, 259);
            this.lblPriceTier.Name = "lblPriceTier";
            this.lblPriceTier.Size = new System.Drawing.Size(153, 21);
            this.lblPriceTier.TabIndex = 25;
            this.lblPriceTier.Text = "Trading Range (%)";
            // 
            // lblSecretkey
            // 
            this.lblSecretkey.AutoSize = true;
            this.lblSecretkey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecretkey.ForeColor = System.Drawing.Color.White;
            this.lblSecretkey.Location = new System.Drawing.Point(65, 118);
            this.lblSecretkey.Name = "lblSecretkey";
            this.lblSecretkey.Size = new System.Drawing.Size(91, 21);
            this.lblSecretkey.TabIndex = 17;
            this.lblSecretkey.Text = "Secret Key";
            // 
            // txbSecretkeytrading
            // 
            this.txbSecretkeytrading.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSecretkeytrading.Location = new System.Drawing.Point(270, 115);
            this.txbSecretkeytrading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSecretkeytrading.Name = "txbSecretkeytrading";
            this.txbSecretkeytrading.Size = new System.Drawing.Size(317, 27);
            this.txbSecretkeytrading.TabIndex = 16;
            this.txbSecretkeytrading.GotFocus += new System.EventHandler(this.scecretkey_FocusIn);
            this.txbSecretkeytrading.LostFocus += new System.EventHandler(this.scecretkey_FocusOut);
            // 
            // lblAPIKEY
            // 
            this.lblAPIKEY.AutoSize = true;
            this.lblAPIKEY.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAPIKEY.ForeColor = System.Drawing.Color.White;
            this.lblAPIKEY.Location = new System.Drawing.Point(65, 70);
            this.lblAPIKEY.Name = "lblAPIKEY";
            this.lblAPIKEY.Size = new System.Drawing.Size(68, 21);
            this.lblAPIKEY.TabIndex = 15;
            this.lblAPIKEY.Text = "API Key";
            // 
            // txbApikeyTrading
            // 
            this.txbApikeyTrading.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbApikeyTrading.Location = new System.Drawing.Point(270, 67);
            this.txbApikeyTrading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbApikeyTrading.Name = "txbApikeyTrading";
            this.txbApikeyTrading.Size = new System.Drawing.Size(317, 27);
            this.txbApikeyTrading.TabIndex = 14;
            this.txbApikeyTrading.GotFocus += new System.EventHandler(this.apikey_FocusIn);
            this.txbApikeyTrading.LostFocus += new System.EventHandler(this.apikey_FocusOut);
            // 
            // lblHeaderContent
            // 
            this.lblHeaderContent.AutoSize = true;
            this.lblHeaderContent.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderContent.ForeColor = System.Drawing.Color.White;
            this.lblHeaderContent.Location = new System.Drawing.Point(148, 17);
            this.lblHeaderContent.Name = "lblHeaderContent";
            this.lblHeaderContent.Size = new System.Drawing.Size(387, 32);
            this.lblHeaderContent.TabIndex = 0;
            this.lblHeaderContent.Text = "System configuration trading";
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
            this.pnRemoteButton.Location = new System.Drawing.Point(634, 0);
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
            this.pnHeader.Size = new System.Drawing.Size(672, 43);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // txbAmountTrading
            // 
            this.txbAmountTrading.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbAmountTrading.Location = new System.Drawing.Point(270, 206);
            this.txbAmountTrading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAmountTrading.Name = "txbAmountTrading";
            this.txbAmountTrading.Size = new System.Drawing.Size(317, 27);
            this.txbAmountTrading.TabIndex = 20;
            this.txbAmountTrading.Text = "100";
            this.txbAmountTrading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEstimateIncome
            // 
            this.lblEstimateIncome.AutoSize = true;
            this.lblEstimateIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstimateIncome.ForeColor = System.Drawing.Color.White;
            this.lblEstimateIncome.Location = new System.Drawing.Point(65, 209);
            this.lblEstimateIncome.Name = "lblEstimateIncome";
            this.lblEstimateIncome.Size = new System.Drawing.Size(192, 21);
            this.lblEstimateIncome.TabIndex = 21;
            this.lblEstimateIncome.Text = "Amount Trading (ADA)";
            // 
            // lblCurrentPair
            // 
            this.lblCurrentPair.AutoSize = true;
            this.lblCurrentPair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentPair.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPair.Location = new System.Drawing.Point(65, 163);
            this.lblCurrentPair.Name = "lblCurrentPair";
            this.lblCurrentPair.Size = new System.Drawing.Size(127, 21);
            this.lblCurrentPair.TabIndex = 19;
            this.lblCurrentPair.Text = "Enable Trading";
            // 
            // cboEnableTrading
            // 
            this.cboEnableTrading.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboEnableTrading.FormattingEnabled = true;
            this.cboEnableTrading.Location = new System.Drawing.Point(270, 160);
            this.cboEnableTrading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEnableTrading.Name = "cboEnableTrading";
            this.cboEnableTrading.Size = new System.Drawing.Size(319, 29);
            this.cboEnableTrading.TabIndex = 33;
            // 
            // ConfigurationTrackding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 447);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConfigurationTrackding";
            this.Text = "Configuration";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbTradingRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccept)).EndInit();
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
        private Label lblAPIKEY;
        private Label lblSecretkey;
        private Label lblPriceTier;
        private Component.v2ImageButton btnAccept;
        private TextBox txbApikeyTrading;
        private TextBox txbSecretkeytrading;
        private NumericUpDown txbTradingRange;
        private Label lblHeaderContent;
        private Label lblEstimateIncome;
        private TextBox txbAmountTrading;
        private Label lblCurrentPair;
        private ComboBox cboEnableTrading;
    }
}

