﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace vectorEditor.Object
{
    class Line:Object2D
    {
        private Point2D secondPoint;

        public Line(Point2D firstPoint, Point2D secondPoint, Color color) :
            base(firstPoint, color)
        {
            this.secondPoint = secondPoint;
        }

        public Line(Point2D firstPoint, Point2D secondPoint) :
            base(firstPoint, Color.Black)
        {
            this.secondPoint = secondPoint;
            
        }

        public override void draw(PictureBox canvas)
        {
            this.pen = new Pen(this.brush, Object2D.SIZE_PEN);

            Graphics graphics = Graphics.FromImage(canvas.Image);

            graphics.DrawLine(this.pen, this.coordinate.x, this.coordinate.y, this.secondPoint.x, this.secondPoint.y);

            this.pen.Dispose();
            graphics.Dispose();

            canvas.Invalidate();
        }
    }
}