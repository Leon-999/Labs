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
        private PointF[] points;

        public Triangle(Point2D firstPoint, Point2D secondPoint, Point2D thirdPoint, Color color) :
            base(firstPoint, color)
        {
            this.points = new PointF[] {new PointF(this.coordinate.x, this.coordinate.y),
                                                new PointF(secondPoint.x, secondPoint.y),
                                                new PointF(thirdPoint.x, thirdPoint.y)};
        }

        public Triangle(Point2D firstPoint, Point2D secondPoint, Point2D thirdPoint) :
            base(firstPoint, Color.Black)
        {
            this.points = new PointF[] {new PointF(this.coordinate.x, this.coordinate.y),
                                                new PointF(secondPoint.x, secondPoint.y),
                                                new PointF(thirdPoint.x, thirdPoint.y)};
        }

        protected override void draw(PictureBox canvas, bool fill, Color color)
        {
            this.pen = new Pen(new SolidBrush(color), Object2D.SIZE_PEN);

            Graphics graphics = Graphics.FromImage(canvas.Image);

            graphics.DrawPolygon(this.pen, this.points);
            if (fill) graphics.FillPolygon(new SolidBrush(color), this.points);

            this.pen.Dispose();
            graphics.Dispose();

            canvas.Invalidate();
        }
        
    }
}
