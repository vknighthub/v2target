
using System.Windows.Forms;
using v2Framework.Controls;

namespace v2Target
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnHeader = new v2Framework.Controls.v2Panel();
            this.pnRemoteButton = new v2Framework.Controls.v2Panel();
            this.btnMinimal = new System.Windows.Forms.PictureBox();
            this.imgCloseButton = new System.Windows.Forms.PictureBox();
            this.pnTitle = new v2Framework.Controls.v2Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnLeftMenu = new v2Framework.Controls.v2Panel();
            this.btnTrading = new v2Target.Component.v2ImageButton();
            this.btnDonate = new v2Target.Component.v2ImageButton();
            this.btnTrade = new v2Target.Component.v2ImageButton();
            this.btnWallet = new v2Target.Component.v2ImageButton();
            this.pnContent = new v2Framework.Controls.v2Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnHeader.SuspendLayout();
            this.pnRemoteButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseButton)).BeginInit();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.mnMainMenu.SuspendLayout();
            this.pnLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDonate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWallet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackgroundImage = global::v2Target.Properties.Resources.Header;
            this.pnHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnHeader.Controls.Add(this.pnRemoteButton);
            this.pnHeader.Controls.Add(this.pnTitle);
            this.pnHeader.Controls.Add(this.mnMainMenu);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1129, 48);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // pnRemoteButton
            // 
            this.pnRemoteButton.BackColor = System.Drawing.Color.Transparent;
            this.pnRemoteButton.Controls.Add(this.btnMinimal);
            this.pnRemoteButton.Controls.Add(this.imgCloseButton);
            this.pnRemoteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRemoteButton.Location = new System.Drawing.Point(995, 0);
            this.pnRemoteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnRemoteButton.Name = "pnRemoteButton";
            this.pnRemoteButton.Size = new System.Drawing.Size(134, 48);
            this.pnRemoteButton.TabIndex = 5;
            this.pnRemoteButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // btnMinimal
            // 
            this.btnMinimal.BackgroundImage = global::v2Target.Properties.Resources.minus;
            this.btnMinimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimal.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimal.Location = new System.Drawing.Point(79, 8);
            this.btnMinimal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimal.Name = "btnMinimal";
            this.btnMinimal.Size = new System.Drawing.Size(20, 35);
            this.btnMinimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimal.TabIndex = 1;
            this.btnMinimal.TabStop = false;
            this.btnMinimal.Click += new System.EventHandler(this.btnMinimal_Click);
            // 
            // imgCloseButton
            // 
            this.imgCloseButton.BackgroundImage = global::v2Target.Properties.Resources.multiply;
            this.imgCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgCloseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgCloseButton.Location = new System.Drawing.Point(105, 9);
            this.imgCloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgCloseButton.Name = "imgCloseButton";
            this.imgCloseButton.Size = new System.Drawing.Size(18, 20);
            this.imgCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCloseButton.TabIndex = 0;
            this.imgCloseButton.TabStop = false;
            this.imgCloseButton.Click += new System.EventHandler(this.imgCloseButton_Click);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnTitle.Controls.Add(this.imgLogo);
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(872, 28);
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
            // mnMainMenu
            // 
            this.mnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mnMainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mnMainMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.mnMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.mnMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnMainMenu.Location = new System.Drawing.Point(2, 28);
            this.mnMainMenu.Name = "mnMainMenu";
            this.mnMainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnMainMenu.Size = new System.Drawing.Size(173, 23);
            this.mnMainMenu.TabIndex = 1;
            this.mnMainMenu.Text = "v2Target";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(63, 19);
            this.fileToolStripMenuItem.Text = "&v2Target";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 19);
            this.toolStripMenuItem1.Text = "&Settings";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem2.Text = "Configuration";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem3.Text = "Configuration Trading";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.btnConfigTrading_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem});
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.supportToolStripMenuItem.Text = "Support";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.btnsupport_Click);
            // 
            // pnLeftMenu
            // 
            this.pnLeftMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnLeftMenu.BackgroundImage = global::v2Target.Properties.Resources.background;
            this.pnLeftMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLeftMenu.Controls.Add(this.btnTrading);
            this.pnLeftMenu.Controls.Add(this.btnDonate);
            this.pnLeftMenu.Controls.Add(this.btnTrade);
            this.pnLeftMenu.Controls.Add(this.btnWallet);
            this.pnLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeftMenu.Location = new System.Drawing.Point(0, 48);
            this.pnLeftMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnLeftMenu.Name = "pnLeftMenu";
            this.pnLeftMenu.Size = new System.Drawing.Size(124, 476);
            this.pnLeftMenu.TabIndex = 11;
            // 
            // btnTrading
            // 
            this.btnTrading.BackColor = System.Drawing.Color.Transparent;
            this.btnTrading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTrading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrading.Image = global::v2Target.Properties.Resources.cost;
            this.btnTrading.ImageActive = global::v2Target.Properties.Resources.tick_left;
            this.btnTrading.Location = new System.Drawing.Point(0, 106);
            this.btnTrading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrading.Name = "btnTrading";
            this.btnTrading.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.btnTrading.PointImageActive = new System.Drawing.Point(0, 60);
            this.btnTrading.Size = new System.Drawing.Size(124, 87);
            this.btnTrading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTrading.TabIndex = 3;
            this.btnTrading.TabStop = false;
            this.btnTrading.Zoom = 10;
            this.btnTrading.Click += new System.EventHandler(this.btnTrading_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.Transparent;
            this.btnDonate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonate.Image = global::v2Target.Properties.Resources.Donate;
            this.btnDonate.ImageActive = global::v2Target.Properties.Resources.tick_left;
            this.btnDonate.Location = new System.Drawing.Point(0, 280);
            this.btnDonate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.btnDonate.PointImageActive = new System.Drawing.Point(0, 60);
            this.btnDonate.Size = new System.Drawing.Size(124, 87);
            this.btnDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDonate.TabIndex = 0;
            this.btnDonate.TabStop = false;
            this.btnDonate.Zoom = 10;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // btnTrade
            // 
            this.btnTrade.BackColor = System.Drawing.Color.Transparent;
            this.btnTrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrade.Image = global::v2Target.Properties.Resources.stock_market;
            this.btnTrade.ImageActive = global::v2Target.Properties.Resources.tick_left;
            this.btnTrade.Location = new System.Drawing.Point(0, 193);
            this.btnTrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.btnTrade.PointImageActive = new System.Drawing.Point(0, 60);
            this.btnTrade.Size = new System.Drawing.Size(124, 87);
            this.btnTrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTrade.TabIndex = 2;
            this.btnTrade.TabStop = false;
            this.btnTrade.Zoom = 10;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // btnWallet
            // 
            this.btnWallet.BackColor = System.Drawing.Color.Transparent;
            this.btnWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWallet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWallet.Image = global::v2Target.Properties.Resources.wallet;
            this.btnWallet.ImageActive = global::v2Target.Properties.Resources.tick_left;
            this.btnWallet.Location = new System.Drawing.Point(0, 19);
            this.btnWallet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWallet.Name = "btnWallet";
            this.btnWallet.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.btnWallet.PointImageActive = new System.Drawing.Point(0, 60);
            this.btnWallet.Size = new System.Drawing.Size(124, 87);
            this.btnWallet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnWallet.TabIndex = 1;
            this.btnWallet.TabStop = false;
            this.btnWallet.Zoom = 10;
            this.btnWallet.Click += new System.EventHandler(this.btnWallet_Click);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.Transparent;
            this.pnContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnContent.Location = new System.Drawing.Point(124, 48);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1005, 476);
            this.pnContent.TabIndex = 12;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "v2Target";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::v2Target.Properties.Resources.background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 524);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnLeftMenu);
            this.Controls.Add(this.pnHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnMainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "v2Target";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnRemoteButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseButton)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.mnMainMenu.ResumeLayout(false);
            this.mnMainMenu.PerformLayout();
            this.pnLeftMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnTrading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDonate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWallet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem1;
        private v2Panel pnRemoteButton;
        private v2Panel pnHeader;
        private v2Panel pnTitle;
        private PictureBox imgLogo;
        private PictureBox imgCloseButton;
        private MenuStrip mnMainMenu;
        private v2Panel pnLeftMenu;
        private Component.v2ImageButton btnDonate;
        private Component.v2ImageButton btnTrade;
        private Component.v2ImageButton btnWallet;
        private v2Panel pnContent;
        private ToolStripMenuItem supportToolStripMenuItem;
        private Label lblTitle;
        private ToolStripMenuItem toolStripMenuItem2;
        private NotifyIcon notifyIcon1;
        private PictureBox btnMinimal;
        private ToolStripMenuItem toolStripMenuItem3;
        private Component.v2ImageButton btnTrading;
    }
}

