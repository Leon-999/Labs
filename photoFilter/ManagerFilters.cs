using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using photoFilter.filters;
using photoFilter.squelch;

namespace photoFilter
{
    class ManagerFilters
    {
        internal const int SIZE_PART = 1000;

        private static ProgressBar progressBar;
        private static int numberOfParts;
        private static bool progressBarActive;

        private static int countFeaturedPixels;

        public ManagerFilters(ProgressBar progressBar)
        {
            ManagerFilters.progressBar = progressBar;
            ManagerFilters.progressBarActive = false;
        }

        public ManagerFilters(){}

        public Bitmap gray(Bitmap sourceImage) 
        { 
            this.countParts(sourceImage);
            return Gray.employ(sourceImage); 
        }

        public Bitmap blackAndWhite(Bitmap sourceImage) 
        { 
            this.countParts(sourceImage);
            return BlackAndWhite.employ(sourceImage); 
        }

        public Bitmap shift(Bitmap sourceImage, int dX, int dY) 
        { 
            this.countParts(sourceImage);
            return Shift.employ(sourceImage, dX, dY); 
        }

        public Bitmap rotate(Bitmap sourceImage, float angle)
        {
            this.countParts(sourceImage);
            return Rotate.employ(sourceImage, angle);
        }

        public Bitmap horozontalWaves(Bitmap sourceImage)
        {
            this.countParts(sourceImage);
            return HorizontalWaves.employ(sourceImage);
        }

        public Bitmap verticalWaves(Bitmap sourceImage)
        {
            this.countParts(sourceImage);
            return VerticalWaves.employ(sourceImage);
        }

        public Bitmap glass(Bitmap sourceImage)
        {
            this.countParts(sourceImage);
            return Glass.employ(sourceImage);
        }

        public Bitmap correction(Bitmap sourceImage, Color baseColor, Color destinationColor)
        {
            this.countParts(sourceImage);
            return Correction.employ(sourceImage, baseColor, destinationColor);
        }

        public Bitmap contrastStretching(Bitmap sourceImage)
        {
            this.countParts(sourceImage);
            return ContrastStretching.employ(sourceImage);
        }

        public Bitmap idealReflector(Bitmap sourceImage)
        {
            this.countParts(sourceImage);
            return IdealReflector.employ(sourceImage);
        }

        public Bitmap statisticalCorrection(Bitmap sourceImage, Bitmap targetImage)
        {
            this.countParts(sourceImage);
            return StatisticalCorrection.employ(sourceImage, targetImage);
        }

        public Bitmap buildup(Bitmap sourceImage, BinaryMatrix structuralElement)
        {
            this.countParts(sourceImage);
            Buildup worker = new Buildup();
            return worker.employ(sourceImage, structuralElement);
        }

        public Bitmap erosion(Bitmap sourceImage, BinaryMatrix structuralElement)
        {
            this.countParts(sourceImage);
            Erosion worker = new Erosion();
            return worker.employ(sourceImage, structuralElement);
        }

        public Bitmap disclosure(Bitmap sourceImage, BinaryMatrix structuralElement)
        {
            this.countParts(sourceImage);
            Disclosure worker = new Disclosure();
            return worker.employ(sourceImage, structuralElement);
        }

        private void countParts(Bitmap sourceImage)
        {
            if (ManagerFilters.progressBar != null && sourceImage != null)
            {
                ManagerFilters.numberOfParts = ((sourceImage.Width * sourceImage.Height) / ManagerFilters.SIZE_PART);
                ManagerFilters.progressBar.Minimum = 0;
                ManagerFilters.progressBar.Maximum = ManagerFilters.numberOfParts;
                ManagerFilters.progressBar.Value = 0;
                ManagerFilters.progressBar.Visible = true;
                ManagerFilters.progressBarActive = true;
                countFeaturedPixels = 0;
            }
        }

        internal static void completePartWork()
        {
            if (ManagerFilters.progressBar != null && ManagerFilters.progressBarActive)
            {
                if (ManagerFilters.progressBar.Value != ManagerFilters.progressBar.Maximum)
                    ManagerFilters.progressBar.Value++;
                else
                    ManagerFilters.progressBar.Value = 0;
            }
        }

        internal static void completeWork()
        {
            if (ManagerFilters.progressBar != null) ManagerFilters.progressBar.Visible = false;
            ManagerFilters.progressBarActive = false;
        }

        internal static void featuredPixel()
        {
            ManagerFilters.countFeaturedPixels++;
            if (ManagerFilters.countFeaturedPixels == ManagerFilters.SIZE_PART)
            {
                ManagerFilters.countFeaturedPixels = 0;
                ManagerFilters.completePartWork();
            }
        }

    }
}
