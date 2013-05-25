using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.filters
{
    class Rotate
    {
        internal static Bitmap employ(Bitmap sourceImage, float angle)
        {
            Bitmap returned = null;

            if (sourceImage != null)
            {
                if (angle != 0)
                {
                    returned = new Bitmap(sourceImage.Width, sourceImage.Height);
                    Graphics graphics = Graphics.FromImage(returned);
                    graphics.TranslateTransform((float)returned.Width / 2, (float)returned.Height / 2);
                    graphics.RotateTransform(angle);
                    graphics.TranslateTransform(-(float)returned.Width / 2, -(float)returned.Height / 2);
                    graphics.DrawImage(sourceImage, new Point(0, 0));
                }
                else
                {
                    returned = new Bitmap(sourceImage);
                }

                ManagerFilters.completeWork();
            }

            return returned;
        }
    }
}
