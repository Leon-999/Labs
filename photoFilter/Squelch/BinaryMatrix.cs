using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace photoFilter.squelch
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

            this.matrix = new bool[this.width][];
            for (int i = 0; i < this.width; ++i)
                this.matrix[i] = new bool[this.height];

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

        public void nulling()
        {
            for (int i = 0; i < this.width; ++i)
                for (int j = 0; j < this.height; ++j)
                {
                    this.setValue(i, j, false);
                    ManagerFilters.featuredPixel();
                }
                    
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
}
