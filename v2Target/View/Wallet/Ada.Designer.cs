
namespace v2Target.View.Wallet
{
    partial class Ada
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnHeader = new v2Framework.Controls.v2Panel();
            this.v2PanelGrid1 = new v2Framework.Controls.v2PanelGrid();
            this.imgCardano = new System.Windows.Forms.PictureBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblavai = new System.Windows.Forms.Label();
            this.lblreward = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblrewardbalance = new System.Windows.Forms.Label();
            this.lblavaibalance = new System.Windows.Forms.Label();
            this.lblttbalance = new System.Windows.Forms.Label();
            this.lblAccountStatus = new System.Windows.Forms.Label();
            this.pnGrid = new v2Framework.Controls.v2PanelGrid();
            this.lblListAddress = new v2Target.Component.v2Label();
            this.v2ListAddress = new v2Framework.Controls.v2DataView();
            this.pnHeader.SuspendLayout();
            this.v2PanelGrid1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCardano)).BeginInit();
            this.pnGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnHeader.Controls.Add(this.v2PanelGrid1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(636, 98);
            this.pnHeader.TabIndex = 0;
            // 
            // v2PanelGrid1
            // 
            this.v2PanelGrid1.ColumnCount = 4;
            this.v2PanelGrid1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v2PanelGrid1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.v2PanelGrid1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.v2PanelGrid1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.v2PanelGrid1.Controls.Add(this.imgCardano, 0, 1);
            this.v2PanelGrid1.Controls.Add(this.lbltotal, 3, 3);
            this.v2PanelGrid1.Controls.Add(this.lblttbalance, 2, 3);
            this.v2PanelGrid1.Controls.Add(this.lblrewardbalance, 2, 2);
            this.v2PanelGrid1.Controls.Add(this.lblreward, 3, 2);
            this.v2PanelGrid1.Controls.Add(this.lblavai, 3, 1);
            this.v2PanelGrid1.Controls.Add(this.lblavaibalance, 2, 1);
            this.v2PanelGrid1.Controls.Add(this.lblstatus, 1, 3);
            this.v2PanelGrid1.Controls.Add(this.lblAccountStatus, 0, 3);
            this.v2PanelGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v2PanelGrid1.Location = new System.Drawing.Point(0, 0);
            this.v2PanelGrid1.Name = "v2PanelGrid1";
            this.v2PanelGrid1.RowCount = 4;
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.v2PanelGrid1.Size = new System.Drawing.Size(636, 98);
            this.v2PanelGrid1.TabIndex = 9;
            // 
            // imgCardano
            // 
            this.imgCardano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.v2PanelGrid1.SetColumnSpan(this.imgCardano, 2);
            this.imgCardano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgCardano.Image = global::v2Target.Properties.Resources.CARDANO;
            this.imgCardano.Location = new System.Drawing.Point(3, 12);
            this.imgCardano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgCardano.Name = "imgCardano";
            this.v2PanelGrid1.SetRowSpan(this.imgCardano, 2);
            this.imgCardano.Size = new System.Drawing.Size(248, 54);
            this.imgCardano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCardano.TabIndex = 4;
            this.imgCardano.TabStop = false;
            // 
            // lblstatus
            // 
            this.lblstatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblstatus.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblstatus.Location = new System.Drawing.Point(157, 68);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(67, 18);
            this.lblstatus.TabIndex = 8;
            this.lblstatus.Text = "Syncing";
            // 
            // lblavai
            // 
            this.lblavai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblavai.AutoSize = true;
            this.lblavai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblavai.ForeColor = System.Drawing.Color.White;
            this.lblavai.Location = new System.Drawing.Point(511, 10);
            this.lblavai.Name = "lblavai";
            this.lblavai.Size = new System.Drawing.Size(57, 19);
            this.lblavai.TabIndex = 5;
            this.lblavai.Text = "0 ADA";
            // 
            // lblreward
            // 
            this.lblreward.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblreward.AutoSize = true;
            this.lblreward.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblreward.ForeColor = System.Drawing.Color.White;
            this.lblreward.Location = new System.Drawing.Point(511, 39);
            this.lblreward.Name = "lblreward";
            this.lblreward.Size = new System.Drawing.Size(57, 19);
            this.lblreward.TabIndex = 6;
            this.lblreward.Text = "0 ADA";
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltotal.ForeColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(511, 68);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(57, 19);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "0 ADA";
            // 
            // lblrewardbalance
            // 
            this.lblrewardbalance.AutoSize = true;
            this.lblrewardbalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblrewardbalance.ForeColor = System.Drawing.Color.White;
            this.lblrewardbalance.Location = new System.Drawing.Point(257, 39);
            this.lblrewardbalance.Name = "lblrewardbalance";
            this.lblrewardbalance.Size = new System.Drawing.Size(143, 19);
            this.lblrewardbalance.TabIndex = 2;
            this.lblrewardbalance.Text = "Reward balance:";
            // 
            // lblavaibalance
            // 
            this.lblavaibalance.AutoSize = true;
            this.lblavaibalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblavaibalance.ForeColor = System.Drawing.Color.White;
            this.lblavaibalance.Location = new System.Drawing.Point(257, 10);
            this.lblavaibalance.Name = "lblavaibalance";
            this.lblavaibalance.Size = new System.Drawing.Size(160, 19);
            this.lblavaibalance.TabIndex = 1;
            this.lblavaibalance.Text = "Available balance:";
            // 
            // lblttbalance
            // 
            this.lblttbalance.AutoSize = true;
            this.lblttbalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblttbalance.ForeColor = System.Drawing.Color.White;
            this.lblttbalance.Location = new System.Drawing.Point(257, 68);
            this.lblttbalance.Name = "lblttbalance";
            this.lblttbalance.Size = new System.Drawing.Size(120, 19);
            this.lblttbalance.TabIndex = 3;
            this.lblttbalance.Text = "Total balance:";
            // 
            // lblAccountStatus
            // 
            this.lblAccountStatus.AutoSize = true;
            this.lblAccountStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountStatus.ForeColor = System.Drawing.Color.White;
            this.lblAccountStatus.Location = new System.Drawing.Point(3, 68);
            this.lblAccountStatus.Name = "lblAccountStatus";
            this.lblAccountStatus.Size = new System.Drawing.Size(120, 18);
            this.lblAccountStatus.TabIndex = 0;
            this.lblAccountStatus.Text = "Account Status: ";
            // 
            // pnGrid
            // 
            this.pnGrid.BackgroundImage = global::v2Target.Properties.Resources.pncontains_2;
            this.pnGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnGrid.ColumnCount = 1;
            this.pnGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnGrid.Controls.Add(this.lblListAddress, 0, 0);
            this.pnGrid.Controls.Add(this.v2ListAddress, 0, 1);
            this.pnGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGrid.Location = new System.Drawing.Point(0, 98);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.RowCount = 2;
            this.pnGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnGrid.Size = new System.Drawing.Size(636, 231);
            this.pnGrid.TabIndex = 0;
            // 
            // lblListAddress
            // 
            this.lblListAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListAddress.ForeColor = System.Drawing.Color.White;
            this.lblListAddress.Location = new System.Drawing.Point(3, 0);
            this.lblListAddress.Name = "lblListAddress";
            this.lblListAddress.Size = new System.Drawing.Size(630, 30);
            this.lblListAddress.TabIndex = 0;
            this.lblListAddress.Text = "List Address";
            this.lblListAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v2ListAddress
            // 
            this.v2ListAddress.BackGroundHeader = System.Drawing.Color.LightGray;
            this.v2ListAddress.ColorHeader = System.Drawing.Color.Black;
            this.v2ListAddress.ColorText = System.Drawing.Color.White;
            this.v2ListAddress.ColumnWidth = new int[] {
        90,
        10};
            this.v2ListAddress.Colunm = 0;
            this.v2ListAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v2ListAddress.EvenRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.v2ListAddress.FontHeader = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.v2ListAddress.FontText = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.v2ListAddress.Location = new System.Drawing.Point(0, 30);
            this.v2ListAddress.Margin = new System.Windows.Forms.Padding(0);
            this.v2ListAddress.Name = "v2ListAddress";
            this.v2ListAddress.OddRowColor = System.Drawing.Color.Transparent;
            this.v2ListAddress.Row = 0;
            this.v2ListAddress.RowHighContent = 35;
            this.v2ListAddress.RowHighHeader = 20;
            this.v2ListAddress.Size = new System.Drawing.Size(636, 201);
            this.v2ListAddress.TabIndex = 1;
            // 
            // Ada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnGrid);
            this.Controls.Add(this.pnHeader);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Ada";
            this.Size = new System.Drawing.Size(636, 329);
            this.pnHeader.ResumeLayout(false);
            this.v2PanelGrid1.ResumeLayout(false);
            this.v2PanelGrid1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCardano)).EndInit();
            this.pnGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private v2Framework.Controls.v2DataView v2ListAddress;
        private System.Windows.Forms.Label lblAccountStatus;
        private System.Windows.Forms.Label lblttbalance;
        private System.Windows.Forms.PictureBox imgCardano;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblreward;
        private System.Windows.Forms.Label lblavai;
        private System.Windows.Forms.Label lblstatus;
        private Component.v2Label lblListAddress;
        private System.Windows.Forms.Label lblrewardbalance;
        private System.Windows.Forms.Label lblavaibalance;
        private v2Framework.Controls.v2Panel pnHeader;
        private v2Framework.Controls.v2PanelGrid pnGrid;
        private v2Framework.Controls.v2PanelGrid v2PanelGrid1;
    }
}
