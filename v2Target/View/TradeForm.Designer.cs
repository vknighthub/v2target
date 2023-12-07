
namespace v2Target.View
{
    partial class TradeForm
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
            this.pnContent = new v2Framework.Controls.v2Panel();
            this.lblMarketTrend = new v2Target.Component.v2Label();
            this.pBoxHeader = new System.Windows.Forms.PictureBox();
            this.v2TradeList = new v2Framework.Controls.v2DataView();
            this.pnContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.Transparent;
            this.pnContent.BackgroundImage = global::v2Target.Properties.Resources.Wallpaper;
            this.pnContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnContent.Controls.Add(this.lblMarketTrend);
            this.pnContent.Controls.Add(this.pBoxHeader);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContent.Location = new System.Drawing.Point(0, 0);
            this.pnContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(727, 141);
            this.pnContent.TabIndex = 10;
            // 
            // lblMarketTrend
            // 
            this.lblMarketTrend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarketTrend.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMarketTrend.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMarketTrend.Location = new System.Drawing.Point(0, 84);
            this.lblMarketTrend.Name = "lblMarketTrend";
            this.lblMarketTrend.Size = new System.Drawing.Size(727, 47);
            this.lblMarketTrend.TabIndex = 3;
            this.lblMarketTrend.Text = "Market Trend";
            this.lblMarketTrend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxHeader
            // 
            this.pBoxHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxHeader.BackgroundImage = global::v2Target.Properties.Resources.Logo;
            this.pBoxHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxHeader.Location = new System.Drawing.Point(0, 13);
            this.pBoxHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBoxHeader.Name = "pBoxHeader";
            this.pBoxHeader.Size = new System.Drawing.Size(727, 67);
            this.pBoxHeader.TabIndex = 2;
            this.pBoxHeader.TabStop = false;
            // 
            // v2TradeList
            // 
            this.v2TradeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v2TradeList.AutoSize = true;
            this.v2TradeList.BackGroundHeader = System.Drawing.Color.Transparent;
            this.v2TradeList.ColorHeader = System.Drawing.Color.White;
            this.v2TradeList.ColorText = System.Drawing.Color.White;
            this.v2TradeList.ColumnWidth = new int[] {
        33,
        33,
        34};
            this.v2TradeList.Colunm = 0;
            this.v2TradeList.EvenRowColor = System.Drawing.Color.Transparent;
            this.v2TradeList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.v2TradeList.FontHeader = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.v2TradeList.FontText = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.v2TradeList.Location = new System.Drawing.Point(0, 141);
            this.v2TradeList.Margin = new System.Windows.Forms.Padding(11, 4, 3, 4);
            this.v2TradeList.Name = "v2TradeList";
            this.v2TradeList.OddRowColor = System.Drawing.Color.Transparent;
            this.v2TradeList.Padding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.v2TradeList.Row = 0;
            this.v2TradeList.RowHighContent = 40;
            this.v2TradeList.RowHighHeader = 50;
            this.v2TradeList.Size = new System.Drawing.Size(727, 493);
            this.v2TradeList.TabIndex = 11;
            // 
            // TradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.v2TradeList);
            this.Controls.Add(this.pnContent);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TradeForm";
            this.Size = new System.Drawing.Size(727, 635);
            this.pnContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Component.v2Label lblMarketTrend;
        private System.Windows.Forms.PictureBox pBoxHeader;
        public v2Framework.Controls.v2DataView v2TradeList;
        private v2Framework.Controls.v2Panel pnContent;
    }
}
