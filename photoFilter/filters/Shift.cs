using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.filters
{
    internal class Shift
    {
        internal static Bitmap employ(Bitmap sourceImage, int dX, int dY)
        {
            Bitmap returned = new Bitmap(1, 1);

            if (sourceImage != null)
            {
                returned = new Bitmap(sourceImage);

                if (dX != 0 || dY != 0)
                {
                    int shiftX, shiftY;

                    for (int i = 0; i < returned.Width; i++)
                    {
                        for (int j = 0; j < returned.Height; j++)
                        {
                            shiftX = i + dX;
                            shiftY = j + dY;
                            if ((shiftX >= 0) && (shiftX < returned.Width) && (shiftY >= 0) && (shiftY < returned.Height))
                            {
                                returned.SetPixel(shiftX, shiftY, sourceImage.GetPixel(i, j));
                            }
                        }
                    }
                }
            }

            return returned;
        }
    }
}
