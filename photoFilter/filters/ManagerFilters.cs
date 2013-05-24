﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace photoFilter.filters
{
    class ManagerFilters
    {
        internal const int SIZE_PART = 1000;

        private static ProgressBar progressBar;
        private static int numberOfParts;
        private static bool progressBarActive;

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
            }
        }

        internal static void completePartWork()
        {
            if (ManagerFilters.progressBar != null && ManagerFilters.progressBarActive)
            {
                ManagerFilters.progressBar.Value++;
                ManagerFilters.numberOfParts--;
                if (ManagerFilters.numberOfParts == 0) ManagerFilters.progressBar.Visible = false;
            }
        }

    }
}
