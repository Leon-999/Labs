using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.squelch
{
    class Buildup:MathematicalMorphology
    {
        internal Bitmap employ(Bitmap sourceImage, BinaryMatrix structuralElement)
        {
            Bitmap result = null;

            if( sourceImage != null)
            {
                this.initialization(sourceImage, structuralElement);
                this.buildup();

                result = this.binaryMatrixToImage(this.resultMatrix);
            }

            return result;
        }
    }
}
