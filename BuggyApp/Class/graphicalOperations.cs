using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuggyApp.Class
{
    static class graphicalOperations
    {
        public static Bitmap ResizeImage(System.Drawing.Bitmap imgToResize, Size size)
        {
            try
            {
                System.Drawing.Bitmap b = new System.Drawing.Bitmap(size.Width, size.Height);
                using (Graphics g = Graphics.FromImage((Image)b))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                    g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
                }
                return b;
            }
            catch
            {
                Console.WriteLine("Bitmap could not be resized");
                return imgToResize;
            }
        }

        static public void AddBitmapToPictureBox(PictureBox pb, Bitmap bitmap, int upscaleFactor)
        {
            Size newSize = new Size(bitmap.Size.Width * upscaleFactor, bitmap.Size.Width * upscaleFactor);

            if (pb.Image != null)
            {
                pb.Image.Dispose();
            }
            else
            {
                pb.Size = newSize;
            }

            pb.Image = graphicalOperations.ResizeImage(bitmap, newSize);
        }

    }
}
