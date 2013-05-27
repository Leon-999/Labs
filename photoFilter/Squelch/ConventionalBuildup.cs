using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.squelch
{
    class ConventionalBuildup:MathematicalMorphology
    {
        private BinaryMatrix buferWork;
        private BinaryMatrix buferSource;

        internal Bitmap employ(Bitmap sourceImage, BinaryMatrix structuralElementErosion, BinaryMatrix structuralElementBuildup)
        {
            Bitmap result = null;

            if (sourceImage != null)
            {
                this.initialization(sourceImage, structuralElementErosion);
                this.erosion();

                this.buferWork = new BinaryMatrix(1,1);
                this.buferSource = new BinaryMatrix(this.sourceMatrix);
                this.structuralElement = structuralElementBuildup;
                while(!BinaryMatrix.compare(this.resultMatrix, this.buferWork))
                {
                    this.buferWork = new BinaryMatrix(this.resultMatrix);
                    this.sourceMatrix = new BinaryMatrix(this.resultMatrix);
                    this.buildup();
                    this.resultMatrix = new BinaryMatrix(BinaryMatrix.confluence(this.resultMatrix, this.buferSource));
                }

                ManagerFilters.completeWork();
                result = this.binaryMatrixToImage(this.resultMatrix);
            }

            return result;
        }
    }
}
