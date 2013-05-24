﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.filters
{
    internal class Gray
    {
        internal static Bitmap employ(Bitmap sourceImage)
        {
            Bitmap returned = new Bitmap(1,1);
            int countFeaturedPixels = 0;

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
                        returned.SetPixel(i, j, Color.FromArgb(component, component, component));

                        countFeaturedPixels++;
                        if (countFeaturedPixels == ManagerFilters.SIZE_PART)
                        {
                            countFeaturedPixels = 0;
                            ManagerFilters.completePartWork();
                        }
                    }
                }

                ManagerFilters.completeWork();
            }

            return returned;
        }
    }
}
