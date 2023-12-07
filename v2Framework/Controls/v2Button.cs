using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using v2Framework.Uitls;

namespace v2Framework.Controls
{
    [DefaultEvent("Click")]
    public partial class v2Button : UserControl
    {
        private bool bool_0;
        private int int_0;
        private int int_1;
        private int int_2;
        private Padding int_padding_1;
        private Padding int_padding_2;
        private double double_1;
        private bool bool_2;
        public Color colbackground = Color.FromArgb(29, 202, (int)byte.MaxValue);
        public Color colhover = Color.FromArgb(0, 172, 237);
        public Color colselected = Color.FromArgb(0, 132, 180);
        private bool bool_1 = true;
        private Color color_0 = Color.Gray;
        private Color color_1 = Color.Transparent;
        private double double_0 = 90.0;
        private Color color_2 = Color.White;
        private Color color_3 = Color.White;
        private Image image_1;
        private Image image_2;
        private Image imagerightSelected;
        private Point pointRightSelected;
        public v2Button()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.O9Button_Load);
            if (!this.selected)
                return;
            this.selected = true;
        }


        private void O9Button_Load(object sender, EventArgs e) => this.SetToolTip(this.txttext.Text.Trim());

        public void SetToolTip(string text)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 0;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 0;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip((Control)this.txttext, text);
            toolTip.SetToolTip((Control)this.limage, text);
            toolTip.SetToolTip((Control)this.rimage, text);
            toolTip.SetToolTip((Control)this, text);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ButtonText
        {
            get => this.txttext.Text;
            set => this.txttext.Text = value;
        }

        [Bindable(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override string Text
        {
            get => this.ButtonText;
            set => this.ButtonText = value;
        }

        [Bindable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new bool Enabled
        {
            get => this.bool_1;
            set
            {
                this.bool_1 = value;
                if (value)
                    this.BackColor = this.Normalcolor;
                else
                    this.BackColor = this.color_0;
            }
        }

        public Point PointRightSelected
        {
            get => this.pointRightSelected;
            set => this.pointRightSelected = value;
        }

        public Color DisabledColor
        {
            get => this.color_0;
            set => this.color_0 = value;
        }

        public ContentAlignment TextAlign
        {
            get => this.txttext.TextAlign;
            set => this.txttext.TextAlign = value;
        }

        public int BorderRadius
        {
            get => this.int_0;
            set
            {
                if (value < 8)
                {
                    this.int_0 = value;
                    Elipse.Apply((Control)this, this.int_0);
                }
                else
                {
                    int num1 = 0;
                    int num2 = 0;
                    while (num2 == num1)
                    {
                        num1 = 1;
                        int num3 = 1;
                        int num4 = num2;
                        num2 = num3;
                        if (1 > num4)
                            break;
                    }
                }
            }
        }

        public Color Iconcolor
        {
            get => this.limage.BackColor;
            set
            {
                this.color_1 = value;
                this.limage.BackColor = value;
            }
        }

        public bool IsTab
        {
            get => this.bool_0;
            set => this.bool_0 = value;
        }

        public Image Iconimage
        {
            get => this.limage.Image;
            set
            {
                this.limage.Image = value;
                this.image_1 = value;
                this.OnResize(new EventArgs());
            }
        }

        public bool IconVisible
        {
            get => this.limage.Visible;
            set
            {
                this.limage.Visible = value;
                this.method_0();
            }
        }

        private void method_0()
        {
            if (this.limage.Visible)
                this.txttext.Left = this.limage.Right;
            else
                this.txttext.Left = 0;
            if (this.rimage.Visible && this.rimage.Image != null)
                this.txttext.Width = this.rimage.Left - this.txttext.Left;
            else
                this.txttext.Width = this.Width - this.txttext.Left;
        }

        public bool IconRightVisible
        {
            get => this.rimage.Visible;
            set
            {
                this.rimage.Visible = value;
                this.method_0();
            }
        }

        public int IconMarginLeft
        {
            get => this.int_1;
            set
            {
                this.int_1 = value;
                this.BunifuFlatButton_Resize((object)this, new EventArgs());
            }
        }

        public int IconMarginRight
        {
            get => this.int_2;
            set
            {
                this.int_2 = value;
                this.BunifuFlatButton_Resize((object)this, new EventArgs());
            }
        }

        public Padding IconPaddingLeft
        {
            get => this.int_padding_1;
            set
            {
                this.int_padding_1 = value;
                this.limage.Padding = this.int_padding_1;
            }
        }

        public Padding IconPaddingRight
        {
            get => this.int_padding_2;
            set
            {
                this.int_padding_2 = value;
                this.rimage.Padding = this.int_padding_2;
            }
        }

        public Image Iconimage_Selected
        {
            get => (Image)this.limage.Tag;
            set
            {
                this.limage.Tag = (object)value;
                this.OnResize(new EventArgs());
            }
        }

        public Image Iconimage_right
        {
            get => this.rimage.Image;
            set
            {
                this.rimage.Image = value;
                this.image_2 = value;
                this.OnResize(new EventArgs());
            }
        }

        public Image Iconimage_right_Selected
        {
            get => (Image)this.rimage.Tag;
            set
            {
                this.rimage.Tag = (object)value;
                this.OnResize(new EventArgs());
            }
        }

        public Font TextFont
        {
            get => this.txttext.Font;
            set
            {
                this.txttext.Font = value;
                this.method_0();
            }
        }

        public Color Textcolor
        {
            get => this.txttext.ForeColor;
            set
            {
                this.color_3 = value;
                this.txttext.ForeColor = value;
            }
        }

        public Color Normalcolor
        {
            get => this.colbackground;
            set
            {
                this.BackColor = value;
                this.colbackground = value;
            }
        }

        public double IconZoom
        {
            get => this.double_0;
            set
            {
                this.double_0 = value;
                this.method_1();
            }
        }

        public double IconRightZoom
        {
            get => this.double_1;
            set
            {
                this.double_1 = value;
                this.method_2();
            }
        }

        private void method_1()
        {
            PictureBox limage = this.limage;
            PictureBox rimage = this.rimage;
            double num1 = Math.Round(this.double_0 / 100.0 * (double)this.Height, 0);
            int num2;
            int num3 = num2 = int.Parse(num1.ToString());
            rimage.Height = num2;
            int num4 = num3;
            limage.Height = num4;
            this.OnResize(new EventArgs());
        }

        private void method_2()
        {
            PictureBox rimage1 = this.rimage;
            PictureBox rimage2 = this.rimage;
            double num1 = Math.Round(this.double_1 / 100.0 * (double)this.Height, 0);
            int num2;
            int num3 = num2 = int.Parse(num1.ToString());
            rimage2.Height = num2;
            int num4 = num3;
            rimage1.Height = num4;
            this.OnResize(new EventArgs());
        }

        public Color OnHovercolor
        {
            get => this.colhover;
            set => this.colhover = value;
        }

        public Color Activecolor
        {
            get => this.colselected;
            set => this.colselected = value;
        }

        public bool selected
        {
            get => this.bool_2;
            set
            {
                this.bool_2 = value;
                if (this.bool_2)
                {
                    this.BackColor = this.colselected;
                    if (this.Iconimage_Selected != null)
                        this.limage.Image = this.Iconimage_Selected;
                    if (this.Iconimage_right_Selected != null)
                    {
                        imagerightSelected = Styles.ResizeImage(this.Iconimage_right_Selected, new Size(this.Iconimage_right_Selected.Width, this.Iconimage_right_Selected.Height), new Size(this.Iconimage_right_Selected.Width, this.Iconimage_right_Selected.Height), PointRightSelected);
                        this.rimage.Image = imagerightSelected;
                        return;
                    }
                }
                else
                {
                    this.BackColor = this.colbackground;
                    if (this.Iconimage_Selected != null)
                        this.limage.Image = this.image_1;
                    if (this.Iconimage_right_Selected != null)
                    {
                        this.rimage.Image = this.image_2;
                        this.image_2 = null;
                        return;
                    }
                }
                int num1 = 0;
                int num2 = 0;
                while (num2 == num1)
                {
                    num1 = 1;
                    int num3 = 1;
                    int num4 = num2;
                    num2 = num3;
                    if (1 > num4)
                        break;
                }
            }
        }

        public Color OnHoverTextColor
        {
            get => this.color_2;
            set => this.color_2 = value;
        }

        public void reset()
        {
            this.bool_2 = false;
            this.BackColor = this.colbackground;
        }

        private void BunifuFlatButton_Load(object sender, EventArgs e)
        {
            if (this.bool_1)
                this.BackColor = this.Normalcolor;
            else
                this.BackColor = this.DisabledColor;
            if (this.IsTab && this.selected)
            {
                this.selected = true;
            }
            else
            {
                int num1 = 0;
                int num2 = 0;
                while (num2 == num1)
                {
                    num1 = 1;
                    int num3 = 1;
                    int num4 = num2;
                    num2 = num3;
                    if (1 > num4)
                        break;
                }
            }
        }

        private void BunifuFlatButton_MouseEnter(object sender, EventArgs e)
        {
            if (!this.bool_1)
            {
                this.BackColor = this.DisabledColor;
            }
            else
            {
                this.txttext.ForeColor = this.color_2;
                this.BackColor = this.colhover;
                this.limage.BackColor = Color.Transparent;
                this.rimage.BackColor = Color.Transparent;
            }
        }

        private void BunifuFlatButton_MouseLeave(object sender, EventArgs e)
        {
            if (!this.bool_1)
            {
                this.BackColor = this.DisabledColor;
            }
            else
            {
                if (this.bool_0)
                {
                    if (this.bool_2)
                    {
                        this.BackColor = this.colselected;
                        if (this.Iconimage_Selected != null)
                            this.limage.Image = this.Iconimage_Selected;
                        if (this.Iconimage_right_Selected != null)
                        {
                            imagerightSelected = Styles.ResizeImage(this.Iconimage_right_Selected, new Size(this.Iconimage_right_Selected.Width, this.Iconimage_right_Selected.Height), new Size(this.Iconimage_right_Selected.Width, this.Iconimage_right_Selected.Height), PointRightSelected);
                            this.rimage.Image = imagerightSelected;
                        }
                    }
                    else
                    {
                        this.BackColor = this.colbackground;
                        if (this.Iconimage_Selected != null)
                            this.limage.Image = this.image_1;
                        if (this.Iconimage_right_Selected != null)
                            this.rimage.Image = this.image_2;
                            this.image_2 = null;
                    }
                }
                else
                    this.BackColor = this.colbackground;
                this.txttext.ForeColor = this.color_3;
                this.limage.BackColor = this.color_1;
            }
            this.BunifuFlatButton_Resize((object)this, new EventArgs());
        }

        private void BunifuFlatButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (!this.bool_1)
                return;
            this.bool_2 = true;
            this.BackColor = this.colselected;
            if (this.Iconimage_right_Selected != null)
            {
                imagerightSelected = Styles.ResizeImage(this.Iconimage_right_Selected, new Size(this.Iconimage_right_Selected.Width, this.Iconimage_right_Selected.Height), new Size(this.Iconimage_right_Selected.Width, this.Iconimage_right_Selected.Height), PointRightSelected);
                this.rimage.Image = imagerightSelected;
            }
            this.BunifuFlatButton_Resize((object)this, new EventArgs());
            this.method_5();
        }

        private void method_3(object sender, PaintEventArgs e)
        {
        }

        private void BunifuFlatButton_Resize(object sender, EventArgs e)
        {
            if (this.limage.Image == null)
            {
                this.limage.Width = 0;
            }
            else
            {
                this.limage.Width = this.limage.Height;
                this.txttext.Location = new Point(this.limage.Width, 0);
            }
            if (this.rimage.Image == null)
                this.rimage.Width = 0;
            else
                this.rimage.Width = this.rimage.Height;
            this.rimage.Top = this.Height / 2 - this.rimage.Height / 2;
            this.limage.Top = this.rimage.Top;
            if (this.IconMarginLeft > 0)
                this.limage.Left = this.IconMarginLeft;
            else
                this.limage.Left = this.limage.Top;
            if (this.IconMarginRight > 0)
                this.rimage.Left = this.IconMarginRight;
            else
                this.rimage.Left = this.Width - this.rimage.Width - this.rimage.Top;
            this.txttext.Top = this.Height / 2 - this.txttext.Height / 2;
            this.method_0();
            Elipse.Apply((Control)this, this.int_0);
        }

        private void txttext_Click(object sender, EventArgs e)
        {
            if (!this.bool_1)
                return;
            this.OnClick(e);
        }

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public event EventHandler MouseDown;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        private void txttext_MouseDown(object sender, MouseEventArgs e)
        {
            if (!this.bool_1 || this.MouseDown == null)
                return;
            this.MouseDown((object)this, (EventArgs)e);
        }

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public event EventHandler MouseUp;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        private void txttext_MouseUp(object sender, MouseEventArgs e)
        {
            if (!this.bool_1 || this.MouseUp == null)
                return;
            this.MouseUp((object)this, (EventArgs)e);
        }

        private void txttext_DoubleClick(object sender, EventArgs e)
        {
            if (!this.bool_1)
                return;
            this.OnDoubleClick(e);
        }

        private void BunifuFlatButton_DoubleClick(object sender, EventArgs e)
        {
        }

        private void limage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void method_5()
        {
            foreach (Control control in (ArrangedElementCollection)this.Parent.Controls)
            {
                if (control.GetType() == typeof(v2Button) && ((v2Button)control).IsTab && control.Name != this.Name && this.Parent == control.Parent && ((v2Button)control).Enabled)
                    ((v2Button)control).selected = false;
            }
        }

    }
}
