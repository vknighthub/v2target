using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using v2Framework.Uitls;

namespace v2Target.Component
{
    [DefaultEvent("Click")]
    public class v2ImageButton : PictureBox
    {
        private int int_0 = 10;
        private Image image_0;
        private Image image_1;
        private Image image_3;
        private Point pointImageActive;
        private Image defaultbackgroud;

        public Image ImageActive
        {
            get => this.image_3;
            set => this.image_3 = value;
        }

        public Point PointImageActive
        {
            get => this.pointImageActive;
            set => this.pointImageActive = value;
        }

        public int Zoom
        {
            get => this.int_0;
            set => this.int_0 = value;
        }

        public v2ImageButton()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.method_0();
            this.image_0 = this.Image;
            this.defaultbackgroud = base.BackgroundImage;
        }

        private void method_0()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(v2ImageButton));
            ((ISupportInitialize)this).BeginInit();
            this.SuspendLayout();
            this.BackColor = Color.Transparent;
            this.Size = new Size(71, 71);
            this.SizeMode = PictureBoxSizeMode.Zoom;
            ((ISupportInitialize)this).EndInit();
            this.ResumeLayout(false);
        }

        protected override void OnClick(EventArgs e)
        {
            if (this.image_0 != null)
                this.Image = this.image_1;
            //Styles.ZoomOut((Control)this);
           // UnActiveButton();
          //  ActiveButton();
            base.OnClick(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (this.image_0 != null)
            {
                this.image_1 = this.Image;
                this.Image = this.image_0;
            }
            Styles.ZoomIn((Control)this, this.int_0);
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (this.image_0 != null)
                this.Image = this.image_1;
            Styles.ZoomOut((Control)this);
            base.OnMouseLeave(e);
        }

        public void ActiveButton()
        {
            if (this.image_3 != null)
            {
                Image image_active = Styles.ResizeImage(this.image_3, new Size(this.image_3.Width, this.image_3.Height), new Size(this.Width, this.Height), pointImageActive);
                this.BackgroundImage = image_active;
                this.BackgroundImageLayout = ImageLayout.None;
            }
            this.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void UnActiveButton()
        {
            foreach (Control control in (ArrangedElementCollection)this.Parent.Controls)
            {
                if (control.GetType() == typeof(v2ImageButton) && control.Name != this.Name && this.Parent == control.Parent && ((v2ImageButton)control).Enabled)                   
                if(this.image_3 != null)
                {
                    ((v2ImageButton)control).BackColor = Color.Transparent;
                    ((v2ImageButton)control).BackgroundImage = this.defaultbackgroud;
                }
            }
        }

    }
}
