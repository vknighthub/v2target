
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace v2Framework.Controls
{
    public partial class v2Button
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>


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
            this.components = new System.ComponentModel.Container();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.limage = new System.Windows.Forms.PictureBox();
            this.rimage = new System.Windows.Forms.PictureBox();
            this.txttext = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.limage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimage)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList_0
            // 
            this.imageList_0.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_0.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // limage
            // 
            this.limage.BackColor = System.Drawing.Color.Transparent;
            this.limage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.limage.Dock = System.Windows.Forms.DockStyle.Left;
            this.limage.Image = global::v2Framework.Properties.Resources.Logo;
            this.limage.Location = new System.Drawing.Point(0, 0);
            this.limage.Margin = new System.Windows.Forms.Padding(0);
            this.limage.Name = "limage";
            this.limage.Size = new System.Drawing.Size(80, 70);
            this.limage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.limage.TabIndex = 1;
            this.limage.TabStop = false;
            this.limage.Click += new System.EventHandler(this.txttext_Click);
            this.limage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BunifuFlatButton_MouseClick);
            this.limage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.limage_MouseDoubleClick);
            this.limage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txttext_MouseDown);
            this.limage.MouseEnter += new System.EventHandler(this.BunifuFlatButton_MouseEnter);
            this.limage.MouseLeave += new System.EventHandler(this.BunifuFlatButton_MouseLeave);
            this.limage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txttext_MouseUp);
            // 
            // rimage
            // 
            this.rimage.BackColor = System.Drawing.Color.Transparent;
            this.rimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rimage.Dock = System.Windows.Forms.DockStyle.Right;
            this.rimage.Location = new System.Drawing.Point(206, 0);
            this.rimage.Margin = new System.Windows.Forms.Padding(4);
            this.rimage.Name = "rimage";
            this.rimage.Size = new System.Drawing.Size(56, 70);
            this.rimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rimage.TabIndex = 3;
            this.rimage.TabStop = false;
            this.rimage.Click += new System.EventHandler(this.txttext_Click);
            this.rimage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BunifuFlatButton_MouseClick);
            this.rimage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txttext_MouseDown);
            this.rimage.MouseEnter += new System.EventHandler(this.BunifuFlatButton_MouseEnter);
            this.rimage.MouseLeave += new System.EventHandler(this.BunifuFlatButton_MouseLeave);
            this.rimage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txttext_MouseUp);
            // 
            // txttext
            // 
            this.txttext.AutoEllipsis = true;
            this.txttext.BackColor = System.Drawing.Color.Transparent;
            this.txttext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttext.ForeColor = System.Drawing.Color.White;
            this.txttext.Location = new System.Drawing.Point(80, 0);
            this.txttext.Margin = new System.Windows.Forms.Padding(0);
            this.txttext.Name = "txttext";
            this.txttext.Size = new System.Drawing.Size(126, 70);
            this.txttext.TabIndex = 4;
            this.txttext.Text = "Demo Button";
            this.txttext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txttext.Click += new System.EventHandler(this.txttext_Click);
            this.txttext.DoubleClick += new System.EventHandler(this.txttext_DoubleClick);
            this.txttext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BunifuFlatButton_MouseClick);
            this.txttext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txttext_MouseDown);
            this.txttext.MouseEnter += new System.EventHandler(this.BunifuFlatButton_MouseEnter);
            this.txttext.MouseLeave += new System.EventHandler(this.BunifuFlatButton_MouseLeave);
            this.txttext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txttext_MouseUp);
            // 
            // v2Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txttext);
            this.Controls.Add(this.limage);
            this.Controls.Add(this.rimage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "v2Button";
            this.Size = new System.Drawing.Size(262, 70);
            this.Load += new System.EventHandler(this.BunifuFlatButton_Load);
            this.DoubleClick += new System.EventHandler(this.BunifuFlatButton_DoubleClick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BunifuFlatButton_MouseClick);
            this.MouseEnter += new System.EventHandler(this.BunifuFlatButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.BunifuFlatButton_MouseLeave);
            this.Resize += new System.EventHandler(this.BunifuFlatButton_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.limage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private IContainer components = (IContainer)null;
        private ImageList imageList_0;
        public PictureBox limage;
        public PictureBox rimage;
        private Label txttext;
    }
}
