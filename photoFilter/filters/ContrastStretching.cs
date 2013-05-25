using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.filters
{
    class ContrastStretching
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
                int minRed, minGreen, minBlue;

                maxRed = currentPixel.R;
                maxGreen = currentPixel.G;
                maxBlue = currentPixel.B;
                minRed = currentPixel.R;
                minGreen = currentPixel.G;
                minBlue = currentPixel.B;

                for (int i = 0; i < sourceImage.Width; i++)
                {
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        currentPixel = sourceImage.GetPixel(i, j);
                        if (currentPixel.R > maxRed) maxRed = currentPixel.R;
                        if (currentPixel.G > maxGreen) maxGreen = currentPixel.G;
                        if (currentPixel.B > maxBlue) maxBlue = currentPixel.B;
                        if (currentPixel.R < minRed) minRed = currentPixel.R;
                        if (currentPixel.G < minGreen) minGreen = currentPixel.G;
                        if (currentPixel.B < minBlue) minBlue = currentPixel.B;

                        ManagerFilters.featuredPixel();
                    }
                }
                for (int i = 0; i < sourceImage.Width; i++)
                {
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        currentPixel = sourceImage.GetPixel(i, j);
                        red = ((maxRed - minRed) != 0) ? ((int)(1.0 * (currentPixel.R - minRed) / (maxRed - minRed) * 255)) : 0;
                        green = ((maxGreen - minGreen) != 0) ? ((int)(1.0 * (currentPixel.G - minGreen) / (maxGreen - minGreen) * 255)) : 0;
                        blue = ((maxBlue - minBlue) != 0) ? ((int)(1.0 * (currentPixel.B - minBlue) / (maxBlue - minBlue) * 255)) : 0;
                        
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
