using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v2Framework.Uitls
{

        internal static class Elipse
        {
            [DllImport("Gdi32.dll")]
            private static extern IntPtr CreateRoundRectRgn(
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse);

            public static void Apply(Form Form, int _Elipse)
            {
                try
                {
                    Form.FormBorderStyle = FormBorderStyle.None;
                    Form.Region = Region.FromHrgn(Elipse.CreateRoundRectRgn(0, 0, Form.Width, Form.Height, _Elipse, _Elipse));
                }
                catch (Exception)
                {
                }
            }

            public static void Apply(Control ctrl, int elipse)
            {
                try
                {
                    ctrl.Region = Region.FromHrgn(Elipse.CreateRoundRectRgn(0, 0, ctrl.Width, ctrl.Height, elipse, elipse));
                }
                catch (Exception)
                {
                }
            }
        }
    
}
