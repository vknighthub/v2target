using System.Drawing;
using System.Windows.Forms;

namespace v2Target.Component
{
    public class v2Label : Label
    {
        public v2Label()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Enabled)
            {
                base.OnPaint(e);
            }
            else
            {
                SolidBrush solidBrush = new SolidBrush(this.ForeColor);
                e.Graphics.DrawString(this.Text, this.Font, (Brush)solidBrush, 0.0f, 0.0f);
            }
        }
    }
}