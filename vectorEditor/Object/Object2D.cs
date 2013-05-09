using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace vectorEditor.Object
{
    public struct Point2D
    {
        //обычно координаты находятся в первой точке объекта
        public float x;
        public float y;

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public struct Point3D
    {
        public float x;
        public float y;
        public float z;

        public Point3D(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    public abstract class Object2D
    {
        protected Point2D coordinate;
        protected Color color;
        protected Brush brush;
        protected Pen pen;

        protected const float SIZE_PEN = 1;

        protected bool visible;

        protected Object2D(Point2D coordinate, Color color)
        {
            this.coordinate = coordinate;
            this.color = color;
            this.brush = new SolidBrush(this.color);
        }

        abstract public void draw(PictureBox canvas);

    }
}
