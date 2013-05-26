using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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


    }

    abstract class MathematicalMorphology
    {

    }
}
