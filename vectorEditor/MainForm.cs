﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using vectorEditor.Object;

namespace vectorEditor
{
    public partial class MainForm : Form
    {
        private Line line;
        private Point2D[] points = new Point2D[2];
        private int countPoint;

        private Brush currentColor;
        private Pen pen;
        private const float SIZE_PEN = 1;
        private static Color COLOR_PEN = Color.Black;
        private static Color COLOR_BACKGROUND = Color.White;
        private int lastX, lastY;

        private bool drawLine = false;

        public MainForm()
        {
            InitializeComponent();

            this.countPoint = 0;
            //this.line = new Line(new Point2D(0, 0), new Point2D(120, 120));

            this.currentColor = new SolidBrush(MainForm.COLOR_PEN);

            this.clearCanvas();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.clearCanvas();
        }
        private void clearCanvas()
        {
            this.canvas.Image = Properties.Resources.whiteBackground;
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {

            // Рисовать так: 
            this.pen = new Pen(currentColor, MainForm.SIZE_PEN);
            Graphics graphics = Graphics.FromImage(this.canvas.Image);
            Point2D point1, point2;

            point1 = new Point2D(e.X, e.Y);
            point2 = new Point2D(e.X + 1, e.Y + 1);
            graphics.DrawLine(this.pen, point1.x, point1.y, point2.x, point2.y);

            point1 = new Point2D(e.X, e.Y + 1);
            point2 = new Point2D(e.X + 1, e.Y);
            graphics.DrawLine(this.pen, point1.x, point1.y, point2.x, point2.y);

            this.points[this.countPoint] = point1;
            this.countPoint++;

            this.pen.Dispose();
            graphics.Dispose();

            this.canvas.Invalidate();

            if (this.drawLine && this.countPoint == 2)
            {
                this.line = new Line(this.points[0], this.points[1]);
                this.line.draw(this.canvas);
                this.countPoint = 0;
            }
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            this.drawLine = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.clearCanvas();
        }
    }
}