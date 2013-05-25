using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using photoFilter.filters;

namespace photoFilter
{
    public partial class mainForm : Form
    {

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Bitmap sourceImage;
        private Bitmap workImage;

        private ManagerFilters filter;

        private int canvasWidth, canvasHeight;

        public mainForm()
        {
            InitializeComponent();

            this.openFileDialog = new OpenFileDialog();
            this.saveFileDialog = new SaveFileDialog();

            this.filter = new ManagerFilters(this.progressBar);

            this.canvasWidth = this.canvas.Width;
            this.canvasHeight = this.canvas.Height;

        }

        private void openToolStripMenu_Click(object sender, EventArgs e)
        {
            this.openNewImage();
        }

        private void saveAsToolStripMenu_Click(object sender, EventArgs e)
        {
            saveNewImage();
        }

        private void exitToolStripMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openNewImage()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.sourceImage != null) this.sourceImage.Dispose();
                if (this.workImage != null)
                {
                    this.workImage.Dispose();
                }

                this.sourceImage = new Bitmap(this.openFileDialog.FileName);
                this.workImage = new Bitmap(this.sourceImage.Width, this.sourceImage.Height);
                //this.canvas.SizeMode = PictureBoxSizeMode.StretchImage;
                if (this.sourceImage.Width > this.canvasWidth || sourceImage.Height > this.canvasHeight)
                {
                    double widthRatio, heightRatio;

                    heightRatio = (double)this.canvasHeight / (double)sourceImage.Height;
                    widthRatio = (double)this.canvasWidth / (double)sourceImage.Width;
                    if (heightRatio < widthRatio)
                    {
                        canvas.Width = Convert.ToInt16(sourceImage.Width * heightRatio);
                        canvas.Height = canvasHeight;
                    }
                    else
                    {
                        canvas.Width = canvasWidth;
                        canvas.Height = Convert.ToInt16(sourceImage.Height * widthRatio);
                    }
                    this.canvas.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    //if (canvas.SizeMode == PictureBoxSizeMode.StretchImage) canvas.SizeMode = PictureBoxSizeMode.AutoSize;
                    this.canvas.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                this.workImage = this.sourceImage;
                refreshCanvas();
            }
        }

        private void refreshCanvas()
        {
            if (workImage != null)
            {
                canvas.Image = this.workImage;
                canvas.Refresh();
            }
        }

        private void saveNewImage()
        {
            if (workImage != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workImage.Save(saveFileDialog.FileName + ".bmp");
                }
            }
        }

        private void buttonSourceFile_Click(object sender, EventArgs e)
        {
            this.workImage = this.sourceImage;
            this.refreshCanvas();
        }

        private void buttonGray_Click(object sender, EventArgs e)
        {
            this.workImage = this.filter.gray(this.sourceImage);
            this.refreshCanvas();
        }

        private void buttonBlackAndWhite_Click(object sender, EventArgs e)
        {
            this.workImage = this.filter.blackAndWhite(this.sourceImage);
            this.refreshCanvas();
        }

        private void buttonShift_Click(object sender, EventArgs e)
        {
            int dX, dY;
            try
            {
                dX = Convert.ToInt32(this.textBoxShiftX.Text);
                dY = Convert.ToInt32(this.textBoxShiftY.Text);
                this.workImage = this.filter.shift(this.sourceImage, dX, dY);
                this.refreshCanvas();
            }
            catch
            {
                MessageBox.Show("Смещение введено неверно");
            }

        }


        private void buttonRotate_Click(object sender, EventArgs e)
        {
            float angle;
            try
            {
                angle = (float)Convert.ToDouble(this.textBoxRotateAngle.Text);
                this.workImage = this.filter.rotate(this.sourceImage, angle);
                this.refreshCanvas();
            }
            catch
            {
                MessageBox.Show("Угол введен неверно");
            }

        }
        
    }
}
