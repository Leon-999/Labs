﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.filters
{
    class VerticalWaves
    {
        private const int AMPLITUDE = 33;

        internal static Bitmap employ(Bitmap sourceImage)
        {
            Bitmap returned = null;

            if (sourceImage != null)
            {
                returned = (Bitmap)sourceImage.Clone();
                int shiftX, shiftY;

                for (int i = 0; i < sourceImage.Width; i++)
                {
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        shiftX = i;
                        shiftY = (int)(j + VerticalWaves.AMPLITUDE * Math.Sin(2 * 3.14 * i / 120));

                        if ((shiftX >= 0) && (shiftX < sourceImage.Width) && (shiftY >= 0) && (shiftY < sourceImage.Height))
                        {
                            returned.SetPixel(shiftX, shiftY, sourceImage.GetPixel(i, j));
                        }

                        ManagerFilters.featuredPixel();
                    }
                }

                ManagerFilters.completeWork();
            }

            return returned;
        }
    }
}
