using System;
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
        private Point2D[] points = new Point2D[9];
        private int countPoint;

        private Brush currentColor;
        private Brush backgroundColor;
        private Pen pen;
        private const float SIZE_PEN = 1;
        private static Color COLOR_PEN = Color.Black;
        public static Color COLOR_BACKGROUND = Color.White;
        private int lastX, lastY;


        ListObject objects;

        private bool drawLine = false;
        private bool drawTriangle = false;
        private bool drawQuadrate = false;
        private bool drawEllipse = false;

        public MainForm()
        {
            InitializeComponent();

            this.countPoint = 0;

            this.currentColor = new SolidBrush(MainForm.COLOR_PEN);
            this.backgroundColor = new SolidBrush(MainForm.COLOR_BACKGROUND);

            this.objects = new ListObject();

            this.canvas.Image = Properties.Resources.whiteBackground;
            this.radioButtonLine.Checked = true;
        }
        private void clearCanvas()
        {
            for (ItemList i = this.objects.getHead(); i != null; i = i.next)
            {
                i.object2d.clear(this.canvas);
            }
            this.objects = new ListObject();
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {

            // Рисовать так: 
            this.pen = new Pen(this.currentColor, MainForm.SIZE_PEN);
            Graphics graphics = Graphics.FromImage(this.canvas.Image);
            Point2D point1, point2;

            point1 = new Point2D(e.X, e.Y);
            point2 = new Point2D(e.X + 1, e.Y + 1);
            graphics.DrawLine(this.pen, point1.x, point1.y, point2.x, point2.y);

            this.points[this.countPoint] = point1;

            point1 = new Point2D(e.X, e.Y + 1);
            point2 = new Point2D(e.X + 1, e.Y);
            graphics.DrawLine(this.pen, point1.x, point1.y, point2.x, point2.y);

            this.countPoint++;

            this.pen.Dispose();
            graphics.Dispose();

            this.canvas.Invalidate();

            if (this.drawLine && this.countPoint == 2)
                this.drawNewObject(new Line(this.points[0], this.points[1]));
            else if (this.drawTriangle && this.countPoint == 3)
                this.drawNewObject(new Triangle(this.points[0], this.points[1],this.points[2]));
            else if (this.drawQuadrate && this.countPoint == 2)
                this.drawNewObject(new Quadrate(this.points[0], this.points[1]));
            else if (this.drawEllipse && this.countPoint == 2)
                this.drawNewObject(new Ellipse(this.points[0], this.points[1]));
        }

        private void drawNewObject(Object2D newObject)
        {
            this.objects.Add(newObject);
            this.removePoints();
            this.objects.getTail().object2d.draw(this.canvas);
        }

        private void removePoints()
        {
            this.pen = new Pen(this.backgroundColor, MainForm.SIZE_PEN);
            Graphics graphics = Graphics.FromImage(this.canvas.Image);

            for (int i = 0; i < this.countPoint; ++i)
            {
                Point2D tmpPoint;

                tmpPoint = new Point2D(this.points[i].x + 1, this.points[i].y + 1);
                graphics.DrawLine(this.pen, this.points[i].x, this.points[i].y, tmpPoint.x, tmpPoint.y);


                this.points[i].y += 1;
                tmpPoint.y -= 1;
                graphics.DrawLine(this.pen, this.points[i].x, this.points[i].y, tmpPoint.x, tmpPoint.y);
            }
            this.countPoint = 0;

            this.pen.Dispose();
            graphics.Dispose();

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
    }
}
