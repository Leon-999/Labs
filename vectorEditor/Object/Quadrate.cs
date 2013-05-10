﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace vectorEditor.Object
{
    class Quadrate:Object2D
    {
        private Point2D secondPoint;

        public Quadrate(Point2D firstPoint, Point2D secondPoint, Color color) :
            base(firstPoint, color)
        {
            this.secondPoint = secondPoint;
        }

        public Quadrate(Point2D firstPoint, Point2D secondPoint) :
            base(firstPoint, Color.Black)
        {
            this.secondPoint = secondPoint;

            float tmp;
            if (this.coordinate.x > this.secondPoint.x)
            {
                tmp = this.secondPoint.x;
                this.secondPoint.x = this.coordinate.x;
                this.coordinate.x = tmp;
            }
            if (this.coordinate.y > this.secondPoint.y)
            {
                tmp = this.secondPoint.y;
                this.secondPoint.y = this.coordinate.y;
                this.coordinate.y = tmp;
            }
            
        }

        public override void draw(PictureBox canvas)
        {
            this.pen = new Pen(this.brush, Object2D.SIZE_PEN);

            Graphics graphics = Graphics.FromImage(canvas.Image);

            graphics.DrawRectangle(this.pen, this.coordinate.x, this.coordinate.y, Math.Abs(this.secondPoint.x - this.coordinate.x), Math.Abs(this.secondPoint.y - this.coordinate.y));

            this.pen.Dispose();
            graphics.Dispose();

            canvas.Invalidate();
        }

    }
}
