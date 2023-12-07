using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v2Framework.Controls
{
    public partial class v2Transaction : UserControl
    {
        public v2Transaction()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Dock = DockStyle.Top;
            InitializeComponent();
        }
        public v2Transaction(string text1, string text2, string text3, string text4, int type)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Dock = DockStyle.Top;
            InitializeComponent();

            this.lbDate.Text = text1;
            this.lbtype.Text = text2;
            this.lbtime.Text = text3;
            this.lbAmount.Text = text4;

            if (type == 0)
            {
                this.pbType.Image = global::v2Framework.Properties.Resources.transaction_out;
            }
            else
            {
                this.pbType.Image = global::v2Framework.Properties.Resources.transaction_in;
            }
        }


        public Font Font1
        {
            get => this.lbDate.Font;
            set => this.lbDate.Font = value;
        }
        public Color ForeColor1
        {
            get => this.lbDate.ForeColor;
            set => this.lbDate.ForeColor = value;
        }
        public Font Font2
        {
            get => this.lbtype.Font;
            set => this.lbtype.Font = value;
        }
        public Color ForeColor2
        {
            get => this.lbtype.ForeColor;
            set => this.lbtype.ForeColor = value;
        }
        public Font Font3
        {
            get => this.lbtime.Font;
            set => this.lbtime.Font = value;
        }
        public Color ForeColor3
        {
            get => this.lbtime.ForeColor;
            set => this.lbtime.ForeColor = value;
        }
        public Font Font4
        {
            get => this.lbAmount.Font;
            set => this.lbAmount.Font = value;
        }
        public Color ForeColor4
        {
            get => this.lbAmount.ForeColor;
            set => this.lbAmount.ForeColor = value;
        }
        public Image ImageLeft
        {
            get => this.pbType.Image;
            set => this.pbType.Image = value;
        }

        public String text1
        {
            get => this.lbDate.Text;
            set => this.lbDate.Text = value;
        }
        public String text2
        {
            get => this.lbtype.Text;
            set => this.lbtype.Text = value;
        }
        public String text3
        {
            get => this.lbtime.Text;
            set => this.lbtime.Text = value;
        }
        public String text4
        {
            get => this.lbAmount.Text;
            set => this.lbAmount.Text = value;
        }
    }
}
