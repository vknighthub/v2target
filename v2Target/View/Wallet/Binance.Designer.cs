
namespace v2Target.View.Wallet
{
    partial class Binance
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
            this.v2Panel1 = new v2Framework.Controls.v2Panel();
            this.v2PanelGrid2 = new v2Framework.Controls.v2PanelGrid();
            this.imgBinance = new System.Windows.Forms.PictureBox();
            this.lblusdt = new System.Windows.Forms.Label();
            this.lblada = new System.Windows.Forms.Label();
            this.lblusdtBalance = new System.Windows.Forms.Label();
            this.lblCardanoBalance = new System.Windows.Forms.Label();
            this.v2PanelGrid1 = new v2Framework.Controls.v2PanelGrid();
            this.v2ListComplete = new v2Framework.Controls.v2DataView();
            this.lblHodingTrans = new v2Target.Component.v2Label();
            this.lblCompltedTrans = new v2Target.Component.v2Label();
            this.v2ListPending = new v2Framework.Controls.v2DataView();
            this.v2Panel1.SuspendLayout();
            this.v2PanelGrid2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBinance)).BeginInit();
            this.v2PanelGrid1.SuspendLayout();
            this.SuspendLayout();
            // 
            // v2Panel1
            // 
            this.v2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.v2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.v2Panel1.Controls.Add(this.v2PanelGrid2);
            this.v2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.v2Panel1.Location = new System.Drawing.Point(0, 0);
            this.v2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.v2Panel1.Name = "v2Panel1";
            this.v2Panel1.Size = new System.Drawing.Size(636, 72);
            this.v2Panel1.TabIndex = 0;
            // 
            // v2PanelGrid2
            // 
            this.v2PanelGrid2.ColumnCount = 3;
            this.v2PanelGrid2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.v2PanelGrid2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.v2PanelGrid2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.v2PanelGrid2.Controls.Add(this.imgBinance, 0, 1);
            this.v2PanelGrid2.Controls.Add(this.lblusdt, 2, 2);
            this.v2PanelGrid2.Controls.Add(this.lblada, 2, 1);
            this.v2PanelGrid2.Controls.Add(this.lblusdtBalance, 1, 2);
            this.v2PanelGrid2.Controls.Add(this.lblCardanoBalance, 1, 1);
            this.v2PanelGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v2PanelGrid2.Location = new System.Drawing.Point(0, 0);
            this.v2PanelGrid2.Name = "v2PanelGrid2";
            this.v2PanelGrid2.RowCount = 3;
            this.v2PanelGrid2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.v2PanelGrid2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.v2PanelGrid2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.v2PanelGrid2.Size = new System.Drawing.Size(636, 72);
            this.v2PanelGrid2.TabIndex = 10;
            // 
            // imgBinance
            // 
            this.imgBinance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBinance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBinance.Image = global::v2Target.Properties.Resources.binance_coin_bnb_logo;
            this.imgBinance.Location = new System.Drawing.Point(3, 12);
            this.imgBinance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgBinance.Name = "imgBinance";
            this.v2PanelGrid2.SetRowSpan(this.imgBinance, 2);
            this.imgBinance.Size = new System.Drawing.Size(206, 58);
            this.imgBinance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBinance.TabIndex = 7;
            this.imgBinance.TabStop = false;
            // 
            // lblusdt
            // 
            this.lblusdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblusdt.AutoSize = true;
            this.lblusdt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblusdt.ForeColor = System.Drawing.Color.White;
            this.lblusdt.Location = new System.Drawing.Point(501, 41);
            this.lblusdt.Name = "lblusdt";
            this.lblusdt.Size = new System.Drawing.Size(58, 19);
            this.lblusdt.TabIndex = 9;
            this.lblusdt.Text = "0 USDT";
            // 
            // lblada
            // 
            this.lblada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblada.AutoSize = true;
            this.lblada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblada.ForeColor = System.Drawing.Color.White;
            this.lblada.Location = new System.Drawing.Point(501, 10);
            this.lblada.Name = "lblada";
            this.lblada.Size = new System.Drawing.Size(57, 19);
            this.lblada.TabIndex = 8;
            this.lblada.Text = "0 ADA";
            // 
            // lblusdtBalance
            // 
            this.lblusdtBalance.AutoSize = true;
            this.lblusdtBalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblusdtBalance.ForeColor = System.Drawing.Color.White;
            this.lblusdtBalance.Location = new System.Drawing.Point(215, 41);
            this.lblusdtBalance.Name = "lblusdtBalance";
            this.lblusdtBalance.Size = new System.Drawing.Size(120, 19);
            this.lblusdtBalance.TabIndex = 6;
            this.lblusdtBalance.Text = "USDT balance:";
            // 
            // lblCardanoBalance
            // 
            this.lblCardanoBalance.AutoSize = true;
            this.lblCardanoBalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardanoBalance.ForeColor = System.Drawing.Color.White;
            this.lblCardanoBalance.Location = new System.Drawing.Point(215, 10);
            this.lblCardanoBalance.Name = "lblCardanoBalance";
            this.lblCardanoBalance.Size = new System.Drawing.Size(154, 19);
            this.lblCardanoBalance.TabIndex = 5;
            this.lblCardanoBalance.Text = "Cardano balance:";
            // 
            // v2PanelGrid1
            // 
            this.v2PanelGrid1.BackgroundImage = global::v2Target.Properties.Resources.pncontains_2;
            this.v2PanelGrid1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.v2PanelGrid1.ColumnCount = 2;
            this.v2PanelGrid1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.40715F));
            this.v2PanelGrid1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.59285F));
            this.v2PanelGrid1.Controls.Add(this.v2ListComplete, 1, 1);
            this.v2PanelGrid1.Controls.Add(this.lblHodingTrans, 0, 0);
            this.v2PanelGrid1.Controls.Add(this.lblCompltedTrans, 1, 0);
            this.v2PanelGrid1.Controls.Add(this.v2ListPending, 0, 1);
            this.v2PanelGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v2PanelGrid1.Location = new System.Drawing.Point(0, 72);
            this.v2PanelGrid1.Name = "v2PanelGrid1";
            this.v2PanelGrid1.RowCount = 2;
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.v2PanelGrid1.Size = new System.Drawing.Size(636, 212);
            this.v2PanelGrid1.TabIndex = 0;
            // 
            // v2ListComplete
            // 
            this.v2ListComplete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.v2ListComplete.BackGroundHeader = System.Drawing.Color.Gray;
            this.v2ListComplete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v2ListComplete.ColorHeader = System.Drawing.Color.White;
            this.v2ListComplete.ColorText = System.Drawing.Color.White;
            this.v2ListComplete.ColumnWidth = new int[] {
        25,
        25,
        25,
        25};
            this.v2ListComplete.Colunm = 0;
            this.v2ListComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v2ListComplete.EvenRowColor = System.Drawing.Color.Transparent;
            this.v2ListComplete.FontHeader = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.v2ListComplete.FontText = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.v2ListComplete.Location = new System.Drawing.Point(336, 33);
            this.v2ListComplete.Name = "v2ListComplete";
            this.v2ListComplete.OddRowColor = System.Drawing.Color.DimGray;
            this.v2ListComplete.Row = 0;
            this.v2ListComplete.RowHighContent = 50;
            this.v2ListComplete.RowHighHeader = 25;
            this.v2ListComplete.Size = new System.Drawing.Size(297, 176);
            this.v2ListComplete.TabIndex = 3;
            // 
            // lblHodingTrans
            // 
            this.lblHodingTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHodingTrans.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHodingTrans.ForeColor = System.Drawing.Color.White;
            this.lblHodingTrans.Location = new System.Drawing.Point(3, 0);
            this.lblHodingTrans.Name = "lblHodingTrans";
            this.lblHodingTrans.Size = new System.Drawing.Size(327, 30);
            this.lblHodingTrans.TabIndex = 0;
            this.lblHodingTrans.Text = "Holding Transaction";
            this.lblHodingTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompltedTrans
            // 
            this.lblCompltedTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompltedTrans.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompltedTrans.ForeColor = System.Drawing.Color.White;
            this.lblCompltedTrans.Location = new System.Drawing.Point(336, 0);
            this.lblCompltedTrans.Name = "lblCompltedTrans";
            this.lblCompltedTrans.Size = new System.Drawing.Size(297, 30);
            this.lblCompltedTrans.TabIndex = 1;
            this.lblCompltedTrans.Text = "Completed Transaction";
            this.lblCompltedTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v2ListPending
            // 
            this.v2ListPending.BackGroundHeader = System.Drawing.Color.Silver;
            this.v2ListPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.v2ListPending.ColorHeader = System.Drawing.Color.White;
            this.v2ListPending.ColorText = System.Drawing.Color.White;
            this.v2ListPending.ColumnWidth = new int[] {
        25,
        25,
        25,
        25};
            this.v2ListPending.Colunm = 0;
            this.v2ListPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v2ListPending.EvenRowColor = System.Drawing.Color.Transparent;
            this.v2ListPending.FontHeader = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.v2ListPending.FontText = null;
            this.v2ListPending.Location = new System.Drawing.Point(3, 33);
            this.v2ListPending.Name = "v2ListPending";
            this.v2ListPending.OddRowColor = System.Drawing.Color.DimGray;
            this.v2ListPending.Row = 0;
            this.v2ListPending.RowHighContent = 50;
            this.v2ListPending.RowHighHeader = 25;
            this.v2ListPending.Size = new System.Drawing.Size(327, 176);
            this.v2ListPending.TabIndex = 4;
            // 
            // Binance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.v2PanelGrid1);
            this.Controls.Add(this.v2Panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Binance";
            this.Size = new System.Drawing.Size(636, 284);
            this.v2Panel1.ResumeLayout(false);
            this.v2PanelGrid2.ResumeLayout(false);
            this.v2PanelGrid2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBinance)).EndInit();
            this.v2PanelGrid1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private v2Framework.Controls.v2Panel v2Panel1;
        private v2Framework.Controls.v2PanelGrid v2PanelGrid1;
        private v2Framework.Controls.v2DataView v2ListPending;
        private v2Framework.Controls.v2DataView v2ListComplete;
        private System.Windows.Forms.PictureBox imgBinance;
        private System.Windows.Forms.Label lblada;
        private System.Windows.Forms.Label lblusdt;
        private Component.v2Label lblHodingTrans;
        private Component.v2Label lblCompltedTrans;
        private System.Windows.Forms.Label lblusdtBalance;
        private System.Windows.Forms.Label lblCardanoBalance;
        private v2Framework.Controls.v2PanelGrid v2PanelGrid2;
    }
}
