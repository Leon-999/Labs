using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.filters
{
    class StatisticalCorrection
    {
        internal static Bitmap employ(Bitmap sourceImage, Bitmap  targetImage)
        {
            Bitmap returned = null;

            if (sourceImage != null)
            {
                returned = (Bitmap)sourceImage.Clone();

                Color currentPixel;
                double expRedSource, expGreenSource, expBlueSource, dispRedSource, dispGreenSource, dispBlueSource;
                StatisticalCorrection.CorrectionCalculator(returned, out expRedSource, out expGreenSource, out expBlueSource, out dispRedSource, out dispGreenSource, out dispBlueSource);
                double expRedTarget, expGreenTarget, expBlueTarget, dispRedTarget, dispGreenTarget, dispBlueTarget;
                StatisticalCorrection.CorrectionCalculator(targetImage, out expRedTarget, out expGreenTarget, out expBlueTarget, out dispRedTarget, out dispGreenTarget, out dispBlueTarget);
                int red, green, blue;

                for (int i = 0; i < sourceImage.Width; i++)
                {
                    for (int j = 0; j < sourceImage.Height; j++)
                    {
                        currentPixel = sourceImage.GetPixel(i, j);
                        red = (int)(expRedSource + (currentPixel.R - expRedTarget) * dispRedSource / dispRedTarget);
                        green = (int)(expGreenSource + (currentPixel.G - expGreenTarget) * dispGreenSource / dispGreenTarget);
                        blue = (int)(expBlueSource + (currentPixel.B - expBlueTarget) * dispBlueSource / dispBlueTarget);

                        red = ((red) >= 255) ? 255 : (((red) <= 0) ? 0 : red);
                        green = ((green) >= 255) ? 255 : (((green) <= 0) ? 0 : green);
                        blue = ((blue) >= 255) ? 255 : (((blue) <= 0) ? 0 : blue);

                        returned.SetPixel(i, j, Color.FromArgb(red, green, blue));

                        ManagerFilters.featuredPixel();
                    }
                }

                ManagerFilters.completeWork();
            }

            return returned;
        }

        private static void CorrectionCalculator(Bitmap sourceImage, out double expRed, out double expGreen, out double expBlue, out double dispRed, out double dispGreen, out double dispBlue)
        {
            expRed = expGreen = expBlue = 0;
            dispRed = dispGreen = dispBlue = 0;
            int pixelsCount = sourceImage.Height * sourceImage.Width;
            Color currentPixel;
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    currentPixel = sourceImage.GetPixel(i, j);
                    expRed += currentPixel.R;
                    expGreen += currentPixel.G;
                    expBlue += currentPixel.B;

                    ManagerFilters.featuredPixel();
                }
            }

            expRed /= pixelsCount;
            expGreen /= pixelsCount;
            expBlue /= pixelsCount;

            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    currentPixel = sourceImage.GetPixel(i, j);

                    dispRed += (currentPixel.R - expRed) * (currentPixel.R - expRed);
                    dispGreen += (currentPixel.G - expGreen) * (currentPixel.G - expGreen);
                    dispBlue += (currentPixel.B - expBlue) * (currentPixel.B - expBlue);

                    ManagerFilters.featuredPixel();
                }
            }

            dispRed = Math.Sqrt(dispRed / pixelsCount);
            dispGreen = Math.Sqrt(dispGreen / pixelsCount);
            dispBlue = Math.Sqrt(dispBlue / pixelsCount);
        }
    }
}
