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
        protected Pen pen;

        protected const float SIZE_PEN = 1;
        protected static Random randomizer = new Random();

        protected bool visible;

        protected Object2D(Point2D coordinate)
        {
            this.coordinate = coordinate;
        }

        public void draw(PictureBox canvas, bool fill = true) { this.draw(canvas, fill, this.color); }
        public void clear(PictureBox canvas) { this.draw(canvas,true, MainForm.COLOR_BACKGROUND); }

        abstract protected void draw(PictureBox canvas, bool fill, Color color);

        protected void randColor()
        {
            int red = Object2D.randomizer.Next() % 255;
            int green = Object2D.randomizer.Next() % 255;
            int blue = Object2D.randomizer.Next() % 255;

            this.color = Color.FromArgb(red, green, blue);
        }

    }
}
