using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.filters
{
    class IdealReflector
    {
        internal static Bitmap employ(Bitmap sourceImage)
        {
            Bitmap returned = null;

            if (sourceImage != null)
            {
                returned = (Bitmap)sourceImage.Clone();

                Color currentPixel = sourceImage.GetPixel(0, 0);
                int red, green, blue;
                int maxRed, maxGreen, maxBlue;

                maxRed = currentPixel.R;
                maxGreen = currentPixel.G;
                maxBlue = currentPixel.B;

                for (int i = 0; i < sourceImage.Width; i++)
                {
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        currentPixel = sourceImage.GetPixel(i, j);
                        if (currentPixel.R > maxRed) maxRed = currentPixel.R;
                        if (currentPixel.G > maxGreen) maxGreen = currentPixel.G;
                        if (currentPixel.B > maxBlue) maxBlue = currentPixel.B;

                        ManagerFilters.featuredPixel();
                    }
                }
                for (int i = 0; i < sourceImage.Width; i++)
                {
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        currentPixel = sourceImage.GetPixel(i, j);
                        red = ((maxRed) != 0) ? ((int)(1.0 * currentPixel.R * 255 / maxRed)) : 0;
                        green = ((maxGreen) != 0) ? ((int)(1.0 * currentPixel.G * 255 / maxGreen)) : 0;
                        blue = ((maxBlue) != 0) ? ((int)(1.0 * currentPixel.B * 255 / maxBlue)) : 0;

                        returned.SetPixel(i, j, Color.FromArgb(red, green, blue));

                        ManagerFilters.featuredPixel();
                    }
                }

                ManagerFilters.completeWork();
            }

            return returned;
        }
    }
}
