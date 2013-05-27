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
        private int[] vectorR;
        private int[] vectorG;
        private int[] vectorB;

        internal Bitmap employ(Bitmap sourceImage, int vicinity)
        {
            Bitmap result = null;

            if (sourceImage != null)
            {
                this.sourceImage = (Bitmap)sourceImage.Clone();
                this.resultImage = new Bitmap(this.sourceImage.Width, this.sourceImage.Height);
                this.size = vicinity;
                this.vectorR = new int[size * size];
                this.vectorG = new int[size * size];
                this.vectorB = new int[size * size];

                for(int i = 0; i < this.sourceImage.Width; ++i)
                    for (int j = 0; j < this.sourceImage.Height; ++j)
                    {
                        this.writeVectors(i, j);
                        this.resultImage.SetPixel(i, j, Color.FromArgb(this.chooseMedianElement(this.vectorR),
                                                                       this.chooseMedianElement(this.vectorG), 
                                                                       this.chooseMedianElement(this.vectorB)));
                        ManagerFilters.featuredPixel();
                    }


                ManagerFilters.completeWork();
                result = new Bitmap(this.resultImage);
            }

            return result;
        }

        private void writeVectors(int x, int y)
        {
            Color currentColor;
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
                        currentColor = this.sourceImage.GetPixel(shiftX, shiftY);
                        this.vectorR[count] = currentColor.R;
                        this.vectorG[count] = currentColor.G;
                        this.vectorB[count] = currentColor.B;
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
                    if (this.vectorR[i] > this.vectorR[j])
                    {
                        int tmp = this.vectorR[i];
                        this.vectorR[i] = this.vectorR[j];
                        this.vectorR[j] = tmp;
                    }

                    if (this.vectorG[i] > this.vectorG[j])
                    {
                        int tmp = this.vectorG[i];
                        this.vectorG[i] = this.vectorG[j];
                        this.vectorG[j] = tmp;
                    }

                    if (this.vectorB[i] > this.vectorB[j])
                    {
                        int tmp = this.vectorB[i];
                        this.vectorB[i] = this.vectorB[j];
                        this.vectorB[j] = tmp;
                    }
                }
        }

        private int chooseMedianElement(int [] vector)
        {
            int median = N / 2;
            return vector[median];
        }
    }
}
