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

        public override void draw(PictureBox canvas) 
        {
            this.pen = new Pen(this.brush, Object2D.SIZE_PEN);

            Graphics graphics = Graphics.FromImage(canvas.Image);

            graphics.DrawLine(this.pen, this.coordinate.x, this.coordinate.y, this.secondPoint.x, this.secondPoint.y);
            graphics.DrawLine(this.pen, this.secondPoint.x, this.secondPoint.y, this.thirdPoint.x, this.thirdPoint.y);
            graphics.DrawLine(this.pen, this.thirdPoint.x, this.thirdPoint.y, this.coordinate.x, this.coordinate.y);

            this.pen.Dispose();
            graphics.Dispose();

            canvas.Invalidate();
        }
        
    }
}
