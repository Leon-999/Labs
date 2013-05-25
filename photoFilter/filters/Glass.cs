using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.filters
{
    class Glass
    {
        private const int DIFFUSENESS = 9;

        internal static Bitmap employ(Bitmap sourceImage)
        {
            Bitmap returned = null;

            if (sourceImage != null)
            {
                Random randomize = new Random();
                returned = (Bitmap)sourceImage.Clone();
                int shiftX, shiftY;

                for (int i = 0; i < sourceImage.Width; i++)
                {
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        shiftX = i + (int)((randomize.NextDouble() - 0.9) * Glass.DIFFUSENESS);
                        shiftY = j + (int)((randomize.NextDouble() - 0.9) * Glass.DIFFUSENESS);

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
