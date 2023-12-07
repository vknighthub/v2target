using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v2Framework.Uitls
{
    internal static class Styles
    {
        private static int int_0;
        private static int int_1;
        private static int int_2;
        private static int int_3;
        private static bool bool_0 = true;

        public static void onclick(Control pic) => Styles.ZoomOut(pic);

        public static void unclick(Control pic)
        {
        }

        public static void ZoomIn(Control pic, int by)
        {
            int num1 = 0;
            int num2 = 0;
            if (!Styles.bool_0)
            {
                while (num1 == num2)
                {
                    num2 = 1;
                    int num3 = num1;
                    num1 = 1;
                    if (1 > num3)
                        break;
                }
            }
            else
            {
                Styles.int_0 = pic.Height;
                Styles.int_1 = pic.Width;
                int int32_1 = Convert.ToInt32(Math.Round((double)by * 0.01 * (double)Styles.int_0) * 0.5);
                int int32_2 = Convert.ToInt32(Math.Round((double)by * 0.01 * (double)Styles.int_1) * 0.5);
                int num4 = Styles.int_0 + int32_1 * 2;
                int num5 = Styles.int_1 + int32_2 * 2;
                Styles.int_2 = int32_1;
                Styles.int_3 = int32_2;
                pic.Width = num5;
                pic.Height = num4;
                pic.Top -= Styles.int_2;
                pic.Left -= Styles.int_3;
                Styles.bool_0 = false;
            }
        }

        public static void ZoomOut(Control pic)
        {
            int num1 = 0;
            int num2 = 0;
            if (Styles.bool_0)
            {
                while (num1 == num2)
                {
                    num2 = 1;
                    int num3 = num1;
                    num1 = 1;
                    if (1 > num3)
                        break;
                }
            }
            else
            {
                pic.SuspendLayout();
                pic.Width = Styles.int_1;
                pic.Left += Styles.int_3;
                pic.Height = Styles.int_0;
                pic.Top += Styles.int_2;
                pic.ResumeLayout();
                Styles.bool_0 = true;
            }
        }

        public static System.Drawing.Image ResizeImage(System.Drawing.Image imgToResize, Size sizeImage, Size sizeBackgroud, Point point)
        {
            //Get the image current width  
            float sourceWidth = imgToResize.Width;
            //Get the image current height  
            float sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float) sizeBackgroud.Width / sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float) sizeBackgroud.Height / sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, new Rectangle(point.X, point.Y, sizeImage.Width, sizeImage.Height));
            g.Dispose();
            return (System.Drawing.Image)b;
        }
    }
}