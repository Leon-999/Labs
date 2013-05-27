using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.squelch
{
    //выделяет тёмные области, по сравнению с окружением
    class BlackHat:MathematicalMorphology
    {
        internal Bitmap employ(Bitmap sourceImage, BinaryMatrix structuralElement)
        {
            Bitmap result = null;

            if (sourceImage != null)
            {
                this.initialization(sourceImage, structuralElement);
                Closing closing = new Closing();
                result = closing.employ(sourceImage, structuralElement);
                this.resultMatrix = this.imageToBinaryMatrix(result);

                this.resultMatrix = new BinaryMatrix(BinaryMatrix.difference(this.resultMatrix, this.sourceMatrix));

                ManagerFilters.completeWork();
                result = this.binaryMatrixToImage(this.resultMatrix);
            }

            return result;
        }
    }
}
