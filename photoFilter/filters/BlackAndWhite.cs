using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.filters
{
    internal class BlackAndWhite
    {
        private const int MONOCHROME_BORDER = 130;

        internal static Bitmap employ(Bitmap sourceImage)
        {
            Bitmap returned = new Bitmap(1, 1);

            if (sourceImage != null)
            {
                returned = new Bitmap(sourceImage);

                int component;
                Color currentPixel;
                for (int i = 0; i < returned.Width; i++)
                {
                    for (int j = 0; j < returned.Height; j++)
                    {
                        currentPixel = returned.GetPixel(i, j);
                        component = (int)(0.2126 * currentPixel.R + 0.7152 * currentPixel.G + 0.0722 * currentPixel.B);
                        component = (component >= BlackAndWhite.MONOCHROME_BORDER) ? 255 : 0;
                        returned.SetPixel(i, j, Color.FromArgb(component, component, component));
                    }
                }

            }

            return returned;
        }
    }
}
