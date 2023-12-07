using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace v2Framework.Controls
{
    public partial class v2Textbox : TextBox
    {
        public v2Textbox()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}
