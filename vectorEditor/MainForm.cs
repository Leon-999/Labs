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
        private Point2D[] points = new Point2D[3];
        private int countPoint;

        private Brush currentColor;
        private Brush backgroundColor;
        private Pen pen;
        private Graphics graphics;
        private const float SIZE_PEN = 1;
        private static Color COLOR_PEN = Color.Black;
        public static Color COLOR_BACKGROUND = Color.White;


        Group objects;
        private bool fillObject = false;

        private bool drawLine = false;
        private bool drawTriangle = false;
        private bool drawQuadrate = false;
        private bool drawEllipse = false;

        private bool drawQuadrateSelection = false;
        private bool activationQS = false;
        private int xQS, yQS;
        private int widthQS, heightQS;

        public MainForm()
        {
            InitializeComponent();

            this.countPoint = 0;

            this.currentColor = new SolidBrush(MainForm.COLOR_PEN);
            this.backgroundColor = new SolidBrush(MainForm.COLOR_BACKGROUND);

            this.objects = new Group();

            this.canvas.Image = Properties.Resources.whiteBackground;
            this.radioButtonLine.Checked = true;
            this.radioButtonPickOut.Checked = this.activationQS;
            this.checkBoxFill.Checked = this.fillObject;
        }
        private void clearCanvas()
        {
            this.objects.clear(this.canvas);
            this.objects = new Group();
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            this.graphics = Graphics.FromImage(this.canvas.Image);
            this.pen = new Pen(this.currentColor, MainForm.SIZE_PEN);

            Point2D point1, point2;

            point1 = new Point2D(e.X, e.Y);
            point2 = new Point2D(e.X + 1, e.Y + 1);
            this.graphics.DrawLine(this.pen, point1.x, point1.y, point2.x, point2.y);

            this.points[this.countPoint] = point1;

            point1 = new Point2D(e.X, e.Y + 1);
            point2 = new Point2D(e.X + 1, e.Y);
            this.graphics.DrawLine(this.pen, point1.x, point1.y, point2.x, point2.y);

            this.countPoint++;

            this.pen.Dispose();
            this.graphics.Dispose();

            this.canvas.Invalidate();

            if (this.drawLine && this.countPoint == 2)
                this.drawNewObject(new Line(this.points[0], this.points[1]));
            else if (this.drawTriangle && this.countPoint == 3)
                this.drawNewObject(new Triangle(this.points[0], this.points[1],this.points[2], this.fillObject));
            else if (this.drawQuadrate && this.countPoint == 2)
                this.drawNewObject(new Quadrate(this.points[0], this.points[1], this.fillObject));
            else if (this.drawEllipse && this.countPoint == 2)
                this.drawNewObject(new Ellipse(this.points[0], this.points[1], this.fillObject));
        }

        private void drawNewObject(Object2D newObject)
        {
            this.objects.addObject(newObject);
            this.removePoints();
            this.objects.drawLatest(this.canvas);
        }

        private void removePoints()
        {
            this.pen = new Pen(this.backgroundColor, MainForm.SIZE_PEN);
            this.graphics = Graphics.FromImage(this.canvas.Image);

            for (int i = 0; i < this.countPoint; ++i)
            {
                Point2D tmpPoint;

                tmpPoint = new Point2D(this.points[i].x + 1, this.points[i].y + 1);
                this.graphics.DrawLine(this.pen, this.points[i].x, this.points[i].y, tmpPoint.x, tmpPoint.y);


                this.points[i].y += 1;
                tmpPoint.y -= 1;
                this.graphics.DrawLine(this.pen, this.points[i].x, this.points[i].y, tmpPoint.x, tmpPoint.y);
            }
            this.countPoint = 0;

            this.pen.Dispose();
            this.graphics.Dispose();

            this.canvas.Invalidate();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.clearCanvas();
        }

        private void radioButtonLine_CheckedChanged(object sender, EventArgs e)
        {
            this.switchOffAll();
            this.removePoints();
            this.drawLine = true;
        }

        private void radioButtonTriangle_CheckedChanged(object sender, EventArgs e)
        {
            this.switchOffAll();
            this.removePoints();
            this.drawTriangle = true;
        }

        private void radioButtonQuadrate_CheckedChanged(object sender, EventArgs e)
        {
            this.switchOffAll();
            this.removePoints();
            this.drawQuadrate = true;
        }

        private void radioButtonEllipse_CheckedChanged(object sender, EventArgs e)
        {
            this.switchOffAll();
            this.removePoints();
            this.drawEllipse = true;
        }

        private void switchOffAll ()
        {
            this.drawLine = false;
            this.drawTriangle = false;
            this.drawQuadrate = false;
            this.drawEllipse = false;
        }

        private void checkBoxFill_CheckedChanged(object sender, EventArgs e)
        {
            this.fillObject = this.checkBoxFill.Checked;
        }

        private void radioButtonPickOut_CheckedChanged(object sender, EventArgs e)
        {
            this.activationQS = this.radioButtonPickOut.Checked;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.activationQS)
            {
                this.drawQuadrateSelection = true;
                this.xQS = e.X;
                this.yQS = e.Y;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.activationQS)
            {
                this.drawQuadrateSelection = false;
                this.drawQS(this.backgroundColor);
                this.objects.draw(this.canvas);
                this.removePoints();
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drawQuadrateSelection)
            {
                this.drawQS(this.backgroundColor);
                this.objects.draw(canvas);
                
                this.widthQS = e.X - this.xQS;
                this.heightQS = e.Y - this.yQS;

                this.drawQS(this.currentColor);
            }
        }

        private void drawQS(Brush brush)
        {
            this.graphics = Graphics.FromImage(this.canvas.Image);

            this.pen = new Pen(brush, MainForm.SIZE_PEN);

            int paintX, paintY;

            if(this.widthQS < 0) 
                paintX = this.xQS + this.widthQS; 
            else
                paintX = this.xQS;

            if (this.heightQS < 0)
                paintY = this.yQS + this.heightQS;
            else
                paintY = this.yQS;

            this.graphics.DrawRectangle(this.pen, paintX, paintY, Math.Abs(this.widthQS), Math.Abs(this.heightQS));

            this.pen.Dispose();
            this.graphics.Dispose();

            this.canvas.Invalidate();
        }
    }
}
