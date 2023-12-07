
using System.Windows.Forms;
using v2Framework.Controls;

namespace v2Target
{
    partial class AddWallet
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
            this.pnContent = new v2Framework.Controls.v2Panel();
            this.btnAccept = new v2Target.Component.v2ImageButton();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassphare = new System.Windows.Forms.TextBox();
            this.lblPassPhare = new System.Windows.Forms.Label();
            this.txbWalletName = new System.Windows.Forms.TextBox();
            this.lblWalletName = new System.Windows.Forms.Label();
            this.lblHeaderContent = new System.Windows.Forms.Label();
            this.pnTitle = new v2Framework.Controls.v2Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnRemoteButton = new v2Framework.Controls.v2Panel();
            this.imgCloseButton = new System.Windows.Forms.PictureBox();
            this.pnHeader = new v2Framework.Controls.v2Panel();
            this.pnContent.SuspendLayout();
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
            this.pnContent.Controls.Add(this.btnAccept);
            this.pnContent.Controls.Add(this.txbPassword);
            this.pnContent.Controls.Add(this.lblPassword);
            this.pnContent.Controls.Add(this.txbPassphare);
            this.pnContent.Controls.Add(this.lblPassPhare);
            this.pnContent.Controls.Add(this.txbWalletName);
            this.pnContent.Controls.Add(this.lblWalletName);
            this.pnContent.Controls.Add(this.lblHeaderContent);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnContent.Location = new System.Drawing.Point(0, 57);
            this.pnContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(767, 459);
            this.pnContent.TabIndex = 12;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.Image = global::v2Target.Properties.Resources.tick;
            this.btnAccept.ImageActive = null;
            this.btnAccept.Location = new System.Drawing.Point(645, 356);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.PointImageActive = new System.Drawing.Point(0, 0);
            this.btnAccept.Size = new System.Drawing.Size(87, 69);
            this.btnAccept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAccept.TabIndex = 7;
            this.btnAccept.TabStop = false;
            this.btnAccept.Zoom = 10;
            this.btnAccept.Click += new System.EventHandler(this.v2ImageButton5_ClickAsync);
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPassword.Location = new System.Drawing.Point(259, 165);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(471, 38);
            this.txbPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(22, 169);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(240, 28);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Spending password";
            // 
            // txbPassphare
            // 
            this.txbPassphare.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbPassphare.Location = new System.Drawing.Point(259, 229);
            this.txbPassphare.Multiline = true;
            this.txbPassphare.Name = "txbPassphare";
            this.txbPassphare.Size = new System.Drawing.Size(471, 103);
            this.txbPassphare.TabIndex = 6;
            // 
            // lblPassPhare
            // 
            this.lblPassPhare.AutoSize = true;
            this.lblPassPhare.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassPhare.ForeColor = System.Drawing.Color.White;
            this.lblPassPhare.Location = new System.Drawing.Point(22, 232);
            this.lblPassPhare.Name = "lblPassPhare";
            this.lblPassPhare.Size = new System.Drawing.Size(143, 28);
            this.lblPassPhare.TabIndex = 3;
            this.lblPassPhare.Text = "Passphrase";
            // 
            // txbWalletName
            // 
            this.txbWalletName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbWalletName.Location = new System.Drawing.Point(259, 105);
            this.txbWalletName.Name = "txbWalletName";
            this.txbWalletName.Size = new System.Drawing.Size(471, 38);
            this.txbWalletName.TabIndex = 2;
            // 
            // lblWalletName
            // 
            this.lblWalletName.AutoSize = true;
            this.lblWalletName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWalletName.ForeColor = System.Drawing.Color.White;
            this.lblWalletName.Location = new System.Drawing.Point(22, 108);
            this.lblWalletName.Name = "lblWalletName";
            this.lblWalletName.Size = new System.Drawing.Size(159, 28);
            this.lblWalletName.TabIndex = 1;
            this.lblWalletName.Text = "Wallet name";
            // 
            // lblHeaderContent
            // 
            this.lblHeaderContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderContent.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderContent.ForeColor = System.Drawing.Color.White;
            this.lblHeaderContent.Location = new System.Drawing.Point(0, 27);
            this.lblHeaderContent.Name = "lblHeaderContent";
            this.lblHeaderContent.Size = new System.Drawing.Size(767, 43);
            this.lblHeaderContent.TabIndex = 0;
            this.lblHeaderContent.Text = "Add/ Restore wallet";
            this.lblHeaderContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnTitle.Controls.Add(this.imgLogo);
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(371, 39);
            this.pnTitle.TabIndex = 3;
            this.pnTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = global::v2Target.Properties.Resources.Logo_White;
            this.imgLogo.Location = new System.Drawing.Point(2, 9);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(53, 28);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(56, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "v2Target (V1.0.0)";
            // 
            // pnRemoteButton
            // 
            this.pnRemoteButton.BackColor = System.Drawing.Color.Transparent;
            this.pnRemoteButton.Controls.Add(this.imgCloseButton);
            this.pnRemoteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRemoteButton.Location = new System.Drawing.Point(614, 0);
            this.pnRemoteButton.Name = "pnRemoteButton";
            this.pnRemoteButton.Size = new System.Drawing.Size(153, 57);
            this.pnRemoteButton.TabIndex = 5;
            this.pnRemoteButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // imgCloseButton
            // 
            this.imgCloseButton.BackgroundImage = global::v2Target.Properties.Resources.multiply;
            this.imgCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgCloseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgCloseButton.Location = new System.Drawing.Point(120, 12);
            this.imgCloseButton.Name = "imgCloseButton";
            this.imgCloseButton.Size = new System.Drawing.Size(21, 27);
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
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(767, 57);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // AddWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 516);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddWallet";
            this.Text = "AddWallet";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
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
        private Label lblHeaderContent;
        private v2Panel pnTitle;
        private PictureBox imgLogo;
        private Label lblTitle;
        private v2Panel pnRemoteButton;
        private PictureBox imgCloseButton;
        private v2Panel pnHeader;
        private Label lblWalletName;
        private Label lblPassword;
        private Label lblPassPhare;
        private TextBox txbWalletName;
        private TextBox txbPassword;
        private TextBox txbPassphare;
        private Component.v2ImageButton btnAccept;
    }
}

