
namespace v2Target.View.Trading
{
    partial class Summary
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
            this.v2PanelGrid1 = new v2Framework.Controls.v2PanelGrid();
            this.lblWarning = new v2Target.Component.v2Label();
            this.lblbinanceusdt = new v2Target.Component.v2Label();
            this.lblbinanceada = new v2Target.Component.v2Label();
            this.lblbinusdt = new v2Target.Component.v2Label();
            this.lblbinada = new v2Target.Component.v2Label();
            this.lblTargetText = new v2Target.Component.v2Label();
            this.lblCurrentPriceText = new v2Target.Component.v2Label();
            this.lblamounttrading = new v2Target.Component.v2Label();
            this.lblcurrentprice = new v2Target.Component.v2Label();
            this.LBLERROR = new v2Target.Component.v2Label();
            this.pnContent.SuspendLayout();
            this.v2PanelGrid1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContent
            // 
            this.pnContent.AllowDrop = true;
            this.pnContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContent.BackColor = System.Drawing.Color.Transparent;
            this.pnContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnContent.Controls.Add(this.v2PanelGrid1);
            this.pnContent.Location = new System.Drawing.Point(0, 0);
            this.pnContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(616, 294);
            this.pnContent.TabIndex = 1;
            // 
            // v2PanelGrid1
            // 
            this.v2PanelGrid1.AutoSize = true;
            this.v2PanelGrid1.ColumnCount = 4;
            this.v2PanelGrid1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.v2PanelGrid1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.v2PanelGrid1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.v2PanelGrid1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.v2PanelGrid1.Controls.Add(this.lblbinanceusdt, 0, 3);
            this.v2PanelGrid1.Controls.Add(this.lblbinanceada, 0, 2);
            this.v2PanelGrid1.Controls.Add(this.lblbinusdt, 1, 3);
            this.v2PanelGrid1.Controls.Add(this.lblbinada, 1, 2);
            this.v2PanelGrid1.Controls.Add(this.lblTargetText, 2, 3);
            this.v2PanelGrid1.Controls.Add(this.lblCurrentPriceText, 2, 2);
            this.v2PanelGrid1.Controls.Add(this.lblamounttrading, 3, 3);
            this.v2PanelGrid1.Controls.Add(this.lblcurrentprice, 3, 2);
            this.v2PanelGrid1.Controls.Add(this.lblWarning, 0, 8);
            this.v2PanelGrid1.Controls.Add(this.LBLERROR, 0, 7);
            this.v2PanelGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.v2PanelGrid1.Location = new System.Drawing.Point(0, 0);
            this.v2PanelGrid1.Name = "v2PanelGrid1";
            this.v2PanelGrid1.RowCount = 9;
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.v2PanelGrid1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.v2PanelGrid1.Size = new System.Drawing.Size(616, 294);
            this.v2PanelGrid1.TabIndex = 12;
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWarning.AutoSize = true;
            this.v2PanelGrid1.SetColumnSpan(this.lblWarning, 4);
            this.lblWarning.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(308, 270);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 19);
            this.lblWarning.TabIndex = 20;
            // 
            // lblbinanceusdt
            // 
            this.lblbinanceusdt.AutoSize = true;
            this.lblbinanceusdt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblbinanceusdt.ForeColor = System.Drawing.Color.White;
            this.lblbinanceusdt.Location = new System.Drawing.Point(3, 88);
            this.lblbinanceusdt.Name = "lblbinanceusdt";
            this.lblbinanceusdt.Size = new System.Drawing.Size(148, 38);
            this.lblbinanceusdt.TabIndex = 4;
            this.lblbinanceusdt.Text = "Binance balance (USDT)";
            // 
            // lblbinanceada
            // 
            this.lblbinanceada.AutoSize = true;
            this.lblbinanceada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblbinanceada.ForeColor = System.Drawing.Color.White;
            this.lblbinanceada.Location = new System.Drawing.Point(3, 49);
            this.lblbinanceada.Name = "lblbinanceada";
            this.lblbinanceada.Size = new System.Drawing.Size(148, 38);
            this.lblbinanceada.TabIndex = 1;
            this.lblbinanceada.Text = "Binance balance (ADA)";
            // 
            // lblbinusdt
            // 
            this.lblbinusdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblbinusdt.AutoSize = true;
            this.lblbinusdt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblbinusdt.ForeColor = System.Drawing.Color.White;
            this.lblbinusdt.Location = new System.Drawing.Point(202, 88);
            this.lblbinusdt.Name = "lblbinusdt";
            this.lblbinusdt.Size = new System.Drawing.Size(58, 19);
            this.lblbinusdt.TabIndex = 7;
            this.lblbinusdt.Text = "0 USDT";
            // 
            // lblbinada
            // 
            this.lblbinada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblbinada.AutoSize = true;
            this.lblbinada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblbinada.ForeColor = System.Drawing.Color.White;
            this.lblbinada.Location = new System.Drawing.Point(202, 49);
            this.lblbinada.Name = "lblbinada";
            this.lblbinada.Size = new System.Drawing.Size(57, 19);
            this.lblbinada.TabIndex = 6;
            this.lblbinada.Text = "0 ADA";
            // 
            // lblTargetText
            // 
            this.lblTargetText.AutoSize = true;
            this.lblTargetText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTargetText.ForeColor = System.Drawing.Color.White;
            this.lblTargetText.Location = new System.Drawing.Point(311, 88);
            this.lblTargetText.Name = "lblTargetText";
            this.lblTargetText.Size = new System.Drawing.Size(138, 38);
            this.lblTargetText.TabIndex = 10;
            this.lblTargetText.Text = "Amount Trading (ADA)";
            // 
            // lblCurrentPriceText
            // 
            this.lblCurrentPriceText.AutoSize = true;
            this.lblCurrentPriceText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentPriceText.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPriceText.Location = new System.Drawing.Point(311, 49);
            this.lblCurrentPriceText.Name = "lblCurrentPriceText";
            this.lblCurrentPriceText.Size = new System.Drawing.Size(106, 19);
            this.lblCurrentPriceText.TabIndex = 8;
            this.lblCurrentPriceText.Text = "Market price";
            // 
            // lblamounttrading
            // 
            this.lblamounttrading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblamounttrading.AutoSize = true;
            this.lblamounttrading.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblamounttrading.ForeColor = System.Drawing.Color.White;
            this.lblamounttrading.Location = new System.Drawing.Point(513, 88);
            this.lblamounttrading.Name = "lblamounttrading";
            this.lblamounttrading.Size = new System.Drawing.Size(51, 19);
            this.lblamounttrading.TabIndex = 11;
            this.lblamounttrading.Text = "0 USD";
            // 
            // lblcurrentprice
            // 
            this.lblcurrentprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcurrentprice.AutoSize = true;
            this.lblcurrentprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcurrentprice.ForeColor = System.Drawing.Color.White;
            this.lblcurrentprice.Location = new System.Drawing.Point(513, 49);
            this.lblcurrentprice.Name = "lblcurrentprice";
            this.lblcurrentprice.Size = new System.Drawing.Size(51, 19);
            this.lblcurrentprice.TabIndex = 9;
            this.lblcurrentprice.Text = "0 USD";
            // 
            // LBLERROR
            // 
            this.LBLERROR.AutoSize = true;
            this.v2PanelGrid1.SetColumnSpan(this.LBLERROR, 4);
            this.LBLERROR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLERROR.ForeColor = System.Drawing.Color.Red;
            this.LBLERROR.Location = new System.Drawing.Point(3, 244);
            this.LBLERROR.Name = "LBLERROR";
            this.LBLERROR.Size = new System.Drawing.Size(0, 19);
            this.LBLERROR.TabIndex = 21;
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnContent);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Summary";
            this.Size = new System.Drawing.Size(616, 294);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.v2PanelGrid1.ResumeLayout(false);
            this.v2PanelGrid1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private v2Framework.Controls.v2Panel pnContent;
        private Component.v2Label lblbinanceada;
        private Component.v2Label lblbinanceusdt;
        private Component.v2Label lblcurrentprice;
        private Component.v2Label lblbinada;
        private Component.v2Label lblbinusdt;
        private Component.v2Label lblamounttrading;
        private Component.v2Label lblTargetText;
        private Component.v2Label lblCurrentPriceText;
        private v2Framework.Controls.v2PanelGrid v2PanelGrid1;
        private Component.v2Label lblWarning;
        private Component.v2Label LBLERROR;
    }
}
