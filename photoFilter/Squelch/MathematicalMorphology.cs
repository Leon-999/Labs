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

        private bool[][] matrix;

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

            this.matrix = new bool[this.width][];
            for (int i = 0; i < this.width; ++i)
                this.matrix[i] = new bool[this.height];
        }

        public BinaryMatrix(BinaryMatrix sourceMatrix)
        {
            this.width = sourceMatrix.width;
            this.height = sourceMatrix.height;
            for (int i = 0; i < sourceMatrix.width; ++i)
                for (int j = 0; j < sourceMatrix.height; ++j)
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

        protected void nulling()
        {
            for (int i = 0; i < this.width; ++i)
                for (int j = 0; j < this.height; ++j)
                    this.setValue(i, j, false);
        }

        public static bool compare(BinaryMatrix firstMatrix, BinaryMatrix secondMatrix)
        {
            bool result = true;

            if (firstMatrix.WIDTH != secondMatrix.WIDTH || firstMatrix.HEIGHT != secondMatrix.HEIGHT)
                result = false;
            else
                for (int i = 0; i < firstMatrix.WIDTH; ++i)
                    for (int j = 0; j < firstMatrix.HEIGHT; ++j)
                    {
                        if (firstMatrix.getValue(i, j) != secondMatrix.getValue(i, j))
                        {
                            result = false;
                        }
                    }


            return result;
        }


    }

    abstract class MathematicalMorphology
    {
        private BinaryMatrix sourceMatrix;
        private BinaryMatrix structuralElement;
        private BinaryMatrix resultMatrix;

        protected BinaryMatrix imageToBinaryMatrix(Bitmap sourceImage)
        {
            BinaryMatrix returned = new BinaryMatrix(sourceImage.Width, sourceImage.Height);

            for (int i = 0; i < sourceImage.Width; ++i)
                for (int j = 0; j < sourceImage.Height; ++j)
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

            for (int i = 0; i < sourceMatrix.WIDTH; ++i)
                for (int j = 0; j < sourceMatrix.HEIGHT; ++j)
                {
                    bool currentValue = sourceMatrix.getValue(i, j);
                    if (currentValue == false)
                        returned.SetPixel(i, j, Color.White);
                    else
                        returned.SetPixel(i, j, Color.Black);

                }

            return returned;
        }

        protected void nulling()
        {
            for (int i = 0; i < this.resultMatrix.WIDTH; ++i)
                for (int j = 0; j < this.resultMatrix.HEIGHT; ++j)
                    this.resultMatrix.setValue(i, j, false);
        }

        protected void writeChange(int x, int y, BinaryMatrix addendum)
        {
            int shiftX, shiftY;
            for (int i = 0; i < addendum.WIDTH; ++i)
                for (int j = 0; j < addendum.HEIGHT; ++j)
                {
                    shiftX = x + i;
                    shiftY = y + j;
                    if(shiftX > -1 && shiftX > -1)
                        if (this.sourceMatrix.getValue(shiftX, shiftY) || addendum.getValue(i, j))
                            this.resultMatrix.setValue(shiftX, shiftY, true);

                }
        }

        protected BinaryMatrix getCenterStructuralElement()
        {
            int widthCenter = (this.structuralElement.WIDTH % 2 == 0)? 2:1;
            int heightCenter = (this.structuralElement.HEIGHT % 2 == 0)? 2:1;
            int xCenter = (int)(this.structuralElement.WIDTH / 2);
            int yCenter = (int)(this.structuralElement.HEIGHT / 2);

            BinaryMatrix result = new BinaryMatrix(widthCenter, heightCenter);

            for (int i = 0; i < widthCenter; ++i)
                for (int j = 0; j < heightCenter; ++j)
                    result.setValue(i, j, this.structuralElement.getValue(xCenter + i, yCenter + j));

            return result;
        }

        protected void buildup()
        {
            BinaryMatrix centerStructuralMatrix = this.getCenterStructuralElement();
            BinaryMatrix pointer = new BinaryMatrix(centerStructuralMatrix.WIDTH, centerStructuralMatrix.HEIGHT);
            int dXStructuralMatrix = (int)Math.Round((double)(this.structuralElement.WIDTH / 2)) - 1;
            int dYStructuralMatrix = (int)Math.Round((double)(this.structuralElement.HEIGHT / 2)) - 1;

            for (int i = 0; i < this.sourceMatrix.WIDTH; ++i)
                for (int j = 0; j < this.sourceMatrix.HEIGHT; ++j)
                {
                    for(int x=0; x < pointer.WIDTH; ++x)
                        for(int y=0; y < pointer.HEIGHT; ++y)
                            pointer.setValue(x, y, this.sourceMatrix.getValue(i + x, j + y));

                    if (BinaryMatrix.compare(centerStructuralMatrix, pointer))
                        this.writeChange(i - dXStructuralMatrix, j - dYStructuralMatrix, this.structuralElement);
                }
        }
    }
}
