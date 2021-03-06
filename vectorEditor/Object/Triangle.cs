﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Windows.Forms;

namespace vectorEditor.Object
{
    class Triangle:Object2D
    {
        private PointF[] points;
        private const int NUMBER_OF_PEAK = 3;

        public Triangle(Point2D firstPoint, Point2D secondPoint, Point2D thirdPoint, bool fill, PictureBox canvas, Color color) :
            base(firstPoint, fill, canvas)
        {
            this.points = new PointF[] {new PointF(this.coordinate.x, this.coordinate.y),
                                                new PointF(secondPoint.x, secondPoint.y),
                                                new PointF(thirdPoint.x, thirdPoint.y)};
            this.color = color;
        }

        public Triangle(Point2D firstPoint, Point2D secondPoint, Point2D thirdPoint, bool fill, PictureBox canvas) :
            base(firstPoint, fill, canvas)
        {
            this.points = new PointF[] {new PointF(this.coordinate.x, this.coordinate.y),
                                                new PointF(secondPoint.x, secondPoint.y),
                                                new PointF(thirdPoint.x, thirdPoint.y)};
            this.randColor();
        }

        protected override void draw(Color color)
        {

            this.pen = new Pen(new SolidBrush(color), Object2D.SIZE_PEN);
            Graphics graphics = Graphics.FromImage(this.canvas.Image);

            graphics.DrawPolygon(this.pen, this.points);
            if (this.fill) graphics.FillPolygon(new SolidBrush(color), this.points);

            this.pen.Dispose();
            graphics.Dispose();

            canvas.Invalidate();
        }

        public override bool inTheArea(Point2D coordinateArea, int widthArea, int heightArea)
        {
            bool answer = true;

            for( int i=0; i <  Triangle.NUMBER_OF_PEAK; ++i)
                if (!this.pointInTheArea(new Point2D(this.points[i].X, this.points[i].Y), coordinateArea, widthArea, heightArea))
                {
                    answer = false;
                    break;
                }

            return answer;
        }
        
    }
}
