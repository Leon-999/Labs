﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.squelch
{
    abstract class MathematicalMorphology
    {
        protected BinaryMatrix sourceMatrix;
        protected BinaryMatrix structuralElement;
        protected BinaryMatrix resultMatrix;

        protected BinaryMatrix imageToBinaryMatrix(Bitmap sourceImage)
        {
                BinaryMatrix returned = new BinaryMatrix(sourceImage.Width, sourceImage.Height);

                for (int i = 0; i < sourceImage.Width; ++i)
                    for (int j = 0; j < sourceImage.Height; ++j)
                    {
                        Color currentPixel = sourceImage.GetPixel(i, j);
                        if (currentPixel.ToArgb() == Color.White.ToArgb())
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
                {
                    this.resultMatrix.setValue(i, j, false);
                    ManagerFilters.featuredPixel();
                }
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

                    ManagerFilters.featuredPixel();
                }

            ManagerFilters.completeWork();
        }
    }
}
