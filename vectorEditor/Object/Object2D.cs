﻿using System;
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
        protected bool fill;
        protected Pen pen;
        protected PictureBox canvas;

        protected const float SIZE_PEN = 1;
        protected static Random randomizer = new Random();

        protected bool visible;

        protected Object2D(Point2D coordinate, bool fill, PictureBox canvas)
        {
            this.coordinate = coordinate;
            this.fill = fill;
            this.canvas = canvas;
        }

        public void draw() { this.draw(this.color); }
        public void clear() { this.draw(MainForm.COLOR_BACKGROUND); }
        internal Point2D getCoordinate() { return this.coordinate; }
        internal Color getColor() { return this.color; }
        internal void setColor(Color color) { this.color = color; }

        abstract protected void draw(Color color);
        abstract public bool inTheArea(Point2D coordinateArea, int widthArea, int heightArea);

        protected void randColor()
        {
            int red = Object2D.randomizer.Next() % 255;
            int green = Object2D.randomizer.Next() % 255;
            int blue = Object2D.randomizer.Next() % 255;

            this.color = Color.FromArgb(red, green, blue);
        }

        protected bool pointInTheArea(Point2D point, Point2D coordinateArea, int widthArea, int heightArea)
        {
            bool answer = false;

            if ((point.x > coordinateArea.x && point.x < coordinateArea.x + widthArea) &&
                   (point.y > coordinateArea.y && point.y < coordinateArea.y + heightArea))
                answer = true;

            return answer;
        }

    }
}
