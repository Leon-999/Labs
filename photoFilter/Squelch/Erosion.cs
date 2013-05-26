using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.squelch
{
    class Erosion:MathematicalMorphology
    {
        internal Bitmap employ(Bitmap sourceImage, BinaryMatrix structuralElement)
        {
            Bitmap result = null;

            if (sourceImage != null)
            {
                this.sourceMatrix = this.imageToBinaryMatrix(sourceImage);
                this.structuralElement = structuralElement;
                this.resultMatrix = new BinaryMatrix(this.sourceMatrix.WIDTH, this.sourceMatrix.HEIGHT);
                this.resultMatrix.nulling();
                this.erosion();

                result = this.binaryMatrixToImage(this.resultMatrix);
            }

            return result;
        }
    }
}
