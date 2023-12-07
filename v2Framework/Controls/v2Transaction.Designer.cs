
namespace v2Framework.Controls
{
    partial class v2Transaction
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
            this.lbDate = new v2Target.Component.v2Label();
            this.pbType = new System.Windows.Forms.PictureBox();
            this.lbtype = new v2Target.Component.v2Label();
            this.lbtime = new v2Target.Component.v2Label();
            this.lbAmount = new v2Target.Component.v2Label();
            this.v2Panel1 = new v2Framework.Controls.v2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).BeginInit();
            this.v2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AllowDrop = true;
            this.lbDate.AutoEllipsis = true;
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(10, 3);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(95, 20);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "30/09/2021";
            // 
            // pbType
            // 
            this.pbType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbType.Image = global::v2Framework.Properties.Resources.transaction_out;
            this.pbType.Location = new System.Drawing.Point(23, 25);
            this.pbType.Name = "pbType";
            this.pbType.Size = new System.Drawing.Size(38, 34);
            this.pbType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbType.TabIndex = 1;
            this.pbType.TabStop = false;
            // 
            // lbtype
            // 
            this.lbtype.AllowDrop = true;
            this.lbtype.AutoEllipsis = true;
            this.lbtype.AutoSize = true;
            this.lbtype.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtype.ForeColor = System.Drawing.Color.White;
            this.lbtype.Location = new System.Drawing.Point(73, 25);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(69, 20);
            this.lbtype.TabIndex = 2;
            this.lbtype.Text = "ADA sell";
            // 
            // lbtime
            // 
            this.lbtime.AllowDrop = true;
            this.lbtime.AutoEllipsis = true;
            this.lbtime.AutoSize = true;
            this.lbtime.ForeColor = System.Drawing.Color.White;
            this.lbtime.Location = new System.Drawing.Point(80, 44);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(163, 15);
            this.lbtime.TabIndex = 3;
            this.lbtime.Text = "ADA transaction, 05:28:41 AM";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoEllipsis = true;
            this.lbAmount.AutoSize = true;
            this.lbAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAmount.ForeColor = System.Drawing.Color.White;
            this.lbAmount.Location = new System.Drawing.Point(64, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAmount.Size = new System.Drawing.Size(108, 20);
            this.lbAmount.TabIndex = 4;
            this.lbAmount.Text = "40000000000";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // v2Panel1
            // 
            this.v2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v2Panel1.Controls.Add(this.lbAmount);
            this.v2Panel1.Location = new System.Drawing.Point(271, 44);
            this.v2Panel1.Name = "v2Panel1";
            this.v2Panel1.Size = new System.Drawing.Size(172, 25);
            this.v2Panel1.TabIndex = 5;
            // 
            // v2Transaction
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.v2Panel1);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.lbtype);
            this.Controls.Add(this.pbType);
            this.Controls.Add(this.lbDate);
            this.Name = "v2Transaction";
            this.Size = new System.Drawing.Size(463, 69);
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).EndInit();
            this.v2Panel1.ResumeLayout(false);
            this.v2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private v2Target.Component.v2Label lbDate;
        private System.Windows.Forms.PictureBox pbType;
        private v2Target.Component.v2Label lbtype;
        private v2Target.Component.v2Label lbtime;
        private v2Target.Component.v2Label lbAmount;
        private v2Panel v2Panel1;
    }
}
