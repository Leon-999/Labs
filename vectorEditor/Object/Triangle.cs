using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Windows.Forms;

namespace vectorEditor.Object
{
    class Triangle:Object2D
    {
        private Point2D secondPoint;
        private Point2D thirdPoint;

        public Triangle(Point2D firstPoint, Point2D secondPoint, Point2D thirdPoint, Color color) :
            base(firstPoint, color)
        {
            this.secondPoint = secondPoint;
            this.thirdPoint = thirdPoint;
        }

        public Triangle(Point2D firstPoint, Point2D secondPoint, Point2D thirdPoint) :
            base(firstPoint, Color.Black)
        {
            this.secondPoint = secondPoint;
            this.thirdPoint = thirdPoint;
        }

        protected override void draw(PictureBox canvas, bool fill, Color color)
        {
            this.pen = new Pen(new SolidBrush(color), Object2D.SIZE_PEN);

            Graphics graphics = Graphics.FromImage(canvas.Image);

            PointF[] points = new PointF[] {new PointF(this.coordinate.x, this.coordinate.y),
                                                new PointF(this.secondPoint.x, this.secondPoint.y),
                                                new PointF(this.thirdPoint.x, this.thirdPoint.y)};

            graphics.DrawPolygon(this.pen, points);
            if (fill) graphics.FillPolygon(new SolidBrush(color), points);

            this.pen.Dispose();
            graphics.Dispose();

            canvas.Invalidate();
        }
        
    }
}
