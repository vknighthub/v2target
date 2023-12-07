
using System.Windows.Forms;
using v2Framework.Controls;

namespace v2Target
{
    partial class SyncForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyncForm));
            this.pnContent = new v2Framework.Controls.v2Panel();
            this.lblStatusDetail = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblHeaderContent = new System.Windows.Forms.Label();
            this.pnTitle = new v2Framework.Controls.v2Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnRemoteButton = new v2Framework.Controls.v2Panel();
            this.imgCloseButton = new System.Windows.Forms.PictureBox();
            this.pnHeader = new v2Framework.Controls.v2Panel();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.pnContent.SuspendLayout();
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
            this.pnContent.Controls.Add(this.lblStatusDetail);
            this.pnContent.Controls.Add(this.lblStatus);
            this.pnContent.Controls.Add(this.lblHeaderContent);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnContent.Location = new System.Drawing.Point(0, 57);
            this.pnContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(443, 202);
            this.pnContent.TabIndex = 12;
            // 
            // lblStatusDetail
            // 
            this.lblStatusDetail.AutoSize = true;
            this.lblStatusDetail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusDetail.ForeColor = System.Drawing.Color.White;
            this.lblStatusDetail.Location = new System.Drawing.Point(185, 93);
            this.lblStatusDetail.Name = "lblStatusDetail";
            this.lblStatusDetail.Size = new System.Drawing.Size(81, 41);
            this.lblStatusDetail.TabIndex = 2;
            this.lblStatusDetail.Text = "Init...";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStatus.Location = new System.Drawing.Point(24, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(105, 41);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            // 
            // lblHeaderContent
            // 
            this.lblHeaderContent.AutoSize = true;
            this.lblHeaderContent.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderContent.ForeColor = System.Drawing.Color.White;
            this.lblHeaderContent.Location = new System.Drawing.Point(24, 23);
            this.lblHeaderContent.Name = "lblHeaderContent";
            this.lblHeaderContent.Size = new System.Drawing.Size(247, 45);
            this.lblHeaderContent.TabIndex = 0;
            this.lblHeaderContent.Text = "Starting wallet";

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
            this.pnRemoteButton.Location = new System.Drawing.Point(290, 0);
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
            this.pnHeader.Size = new System.Drawing.Size(443, 57);
            this.pnHeader.TabIndex = 0;
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // SyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 259);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SyncForm";
            this.Text = "SyncForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SyncForm_Closing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
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
        private v2Panel pnRemoteButton;
        private PictureBox imgCloseButton;
        private v2Panel pnHeader;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private Label lblTitle;
        private Label lblStatus;
        private Label lblStatusDetail;
    }
}

