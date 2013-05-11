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

        public Triangle(Point2D firstPoint, Point2D secondPoint, Point2D thirdPoint, bool fill, Color color) :
            base(firstPoint, fill)
        {
            this.points = new PointF[] {new PointF(this.coordinate.x, this.coordinate.y),
                                                new PointF(secondPoint.x, secondPoint.y),
                                                new PointF(thirdPoint.x, thirdPoint.y)};
            this.color = color;
        }

        public Triangle(Point2D firstPoint, Point2D secondPoint, Point2D thirdPoint, bool fill) :
            base(firstPoint, fill)
        {
            this.points = new PointF[] {new PointF(this.coordinate.x, this.coordinate.y),
                                                new PointF(secondPoint.x, secondPoint.y),
                                                new PointF(thirdPoint.x, thirdPoint.y)};
            this.randColor();
        }

        protected override void draw(PictureBox canvas, Color color)
        {
            this.pen = new Pen(new SolidBrush(color), Object2D.SIZE_PEN);

            Graphics graphics = Graphics.FromImage(canvas.Image);

            graphics.DrawPolygon(this.pen, this.points);
            if (this.fill) graphics.FillPolygon(new SolidBrush(color), this.points);

            this.pen.Dispose();
            graphics.Dispose();

            canvas.Invalidate();
        }
        
    }
}
