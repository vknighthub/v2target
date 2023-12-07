using System.Windows.Forms;

namespace v2Framework.Controls
{
    public class v2Panel : Panel
    {
        public v2Panel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
    }
}
