using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.squelch
{
    class Disclosure:MathematicalMorphology
    {
        internal Bitmap employ(Bitmap sourceImage, BinaryMatrix structuralElement)
        {
            Bitmap result = null;

            if (sourceImage != null)
            {
                this.initialization(sourceImage, structuralElement);
                this.erosion();
                this.sourceMatrix = new BinaryMatrix(this.resultMatrix);
                this.resultMatrix.nulling();
                this.buildup();

                result = this.binaryMatrixToImage(this.resultMatrix);
            }

            return result;
        }
    }
}
