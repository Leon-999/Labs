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
                this.initialization(sourceImage, structuralElement);
                this.erosion();

                ManagerFilters.completeWork();
                result = this.binaryMatrixToImage(this.resultMatrix);
            }

            return result;
        }
    }
}
