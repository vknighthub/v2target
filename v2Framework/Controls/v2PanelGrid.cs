using System.Windows.Forms;

namespace v2Framework.Controls
{
    public class v2PanelGrid : TableLayoutPanel
    {
        public v2PanelGrid()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
    }
}
