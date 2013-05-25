using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.filters
{
    class Correction
    {
        internal static Bitmap employ(Bitmap sourceImage, Color baseColor, Color destinationColor)
        {
            Bitmap returned = null;

            if (sourceImage != null)
            {
                returned = (Bitmap)sourceImage.Clone();

                double rRed, rGreen, rBlue;
                rRed = (baseColor.R != 0) ? (1.0 * destinationColor.R / baseColor.R) : 0.0;
                rGreen = (baseColor.G != 0) ? (1.0 * destinationColor.G / baseColor.G) : 0.0;
                rBlue = (baseColor.B != 0) ? (1.0 * destinationColor.B / baseColor.B) : 0.0;

                Color currentPixel;
                int red, green, blue;
                for (int i = 0; i < sourceImage.Width; i++)
                {
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        currentPixel = sourceImage.GetPixel(i, j);
                        red = (int)(currentPixel.R * rRed);
                        red = (red >= 255) ? 255 : red;
                        green = (int)(currentPixel.G * rGreen);
                        green = (green >= 255) ? 255 : green;
                        blue = (int)(currentPixel.B * rBlue);
                        blue = (blue >= 255) ? 255 : blue;

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
