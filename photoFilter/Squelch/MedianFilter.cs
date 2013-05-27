using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.squelch
{
    class MedianFilter
    {
        private Bitmap sourceImage;
        private Bitmap resultImage;
        private int size;
        private int N;
        private Color[] vector; 

        internal Bitmap employ(Bitmap sourceImage, int vicinity)
        {
            Bitmap result = null;

            if (sourceImage != null)
            {
                this.sourceImage = (Bitmap)sourceImage.Clone();
                this.resultImage = new Bitmap(this.sourceImage.Width, this.sourceImage.Height);
                this.size = vicinity;
                this.vector = new Color[size * size];

                for(int i = 0; i < this.sourceImage.Width; ++i)
                    for (int j = 0; j < this.sourceImage.Height; ++j)
                    {
                        this.writeVector(i, j);
                        this.resultImage.SetPixel(i, j, this.chooseMedianElement());
                        ManagerFilters.featuredPixel();
                    }


                ManagerFilters.completeWork();
                result = new Bitmap(this.resultImage);
            }

            return result;
        }

        private void writeVector(int x, int y)
        {
            int count = 0;
            int shiftX, shiftY;
            int shift = (int)(this.size / 2);
            for(int i = 0; i < this.size; ++i)
                for (int j = 0; j < this.size ; ++j)
                {
                    shiftX = x - shift + i;
                    shiftY = y - shift + j;
                    if (shiftX > -1 && shiftY > -1 && shiftX < this.sourceImage.Width && shiftY < this.sourceImage.Height)
                    {
                        this.vector[count] = this.sourceImage.GetPixel(shiftX, shiftY);
                        count++;
                    }
                }

            this.N = count;

            this.sort();
        }

        private void sort()
        {
            for(int i = 0; i < this.N; ++i)
                for (int j = i; j < this.N; ++j)
                {
                    if (this.vector[i].R > this.vector[j].R)
                    {
                        Color tmp = this.vector[i];
                        this.vector[i] = this.vector[j];
                        this.vector[j] = tmp;
                    }
                }
        }

        private Color chooseMedianElement()
        {
            int median = N / 2;
            return this.vector[median];
        }
    }
}
