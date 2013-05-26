using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.Squelch
{
    class BinaryMatrix
    {
        private int width;
        private int height;

        public bool[][] matrix;

        public BinaryMatrix(int width, int height)
        {
            if (width < 0)
                this.width = 0;
            else
                this.width = width;

            if (height < 0)
                this.height = 0;
            else
                this.height = height;

            this.matrix = new bool[this.height][];
            for (int i = 0; i < this.height; ++i)
                this.matrix[i] = new bool[this.width];
        }

        public BinaryMatrix(BinaryMatrix sourceMatrix)
        {
            this.width = sourceMatrix.width;
            this.height = sourceMatrix.height;
            for (int i = 0; i < sourceMatrix.height; ++i)
                for (int j = 0; j < sourceMatrix.width; ++j)
                    this.matrix[i][j] = sourceMatrix.matrix[i][j];
                    
        }

        public int WIDTH
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = (value < 0) ? 0 : value;
            }
        }

        public int HEIGHT
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = (value < 0) ? 0 : value;
            }
        }

        public void setValue(int x, int y, bool value)
        {
            if ((x >= 0 && x < this.width) && (y >= 0 && y < this.height))
                this.matrix[x][y] = value;
        }

        public bool getValue(int x, int y)
        {
            bool returned;

            if ((x >= 0 && x < this.width) && (y >= 0 && y < this.height))
                returned = this.matrix[x][y];
            else
                returned = false;

            return returned;
        }


    }

    abstract class MathematicalMorphology
    {
        protected BinaryMatrix imageToBinaryMatrix(Bitmap sourceImage)
        {
            BinaryMatrix returned = new BinaryMatrix(sourceImage.Width, sourceImage.Height);

            for (int i = 0; i < sourceImage.Height; ++i)
                for (int j = 0; j < sourceImage.Width; ++j)
                {
                    Color currentPixel = sourceImage.GetPixel(i, j);
                    if(currentPixel == Color.White) 
                        returned.setValue(i, j, false);
                    else
                        returned.setValue(i, j, true);

                }

            return returned;
        }

        protected Bitmap binaryMatrixToImage(BinaryMatrix sourceMatrix)
        {
            Bitmap returned = new Bitmap(sourceMatrix.WIDTH, sourceMatrix.HEIGHT);

            for (int i = 0; i < sourceMatrix.HEIGHT; ++i)
                for (int j = 0; j < sourceMatrix.WIDTH; ++j)
                {
                    bool currentValue = sourceMatrix.getValue(i, j);
                    if (currentValue == false)
                        returned.SetPixel(i, j, Color.White);
                    else
                        returned.SetPixel(i, j, Color.Black);

                }

            return returned;
        }
    }
}
