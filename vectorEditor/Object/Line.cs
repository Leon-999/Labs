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

        public Line(Point2D firstPoint, Point2D secondPoint, PictureBox canvas, Color color) :
            base(firstPoint, false, canvas)
        {
            this.secondPoint = secondPoint;
            this.color = color;
        }

        public Line(Point2D firstPoint, Point2D secondPoint, PictureBox canvas) :
            base(firstPoint, false, canvas)
        {
            this.secondPoint = secondPoint;
            this.randColor();
        }

        protected override void draw(Color color)
        {
            this.pen = new Pen(new SolidBrush(color), Object2D.SIZE_PEN);

            Graphics graphics = Graphics.FromImage(this.canvas.Image);

            graphics.DrawLine(this.pen, this.coordinate.x, this.coordinate.y, this.secondPoint.x, this.secondPoint.y);

            this.pen.Dispose();
            graphics.Dispose();

            canvas.Invalidate();
        }

        public override bool inTheArea(Point2D coordinateArea, int widthArea, int heightArea)
        {
            bool answer = false;

            if( this.pointInTheArea(this.coordinate, coordinateArea, widthArea, heightArea) &&
                this.pointInTheArea(this.secondPoint, coordinateArea, widthArea, heightArea))
                answer = true;

            return answer;
        }
    }
}
