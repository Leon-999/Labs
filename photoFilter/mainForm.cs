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
        private ColorDialog colorDialog;
        private Bitmap sourceImage;
        private Bitmap workImage;

        private ManagerFilters filter;

        private int canvasWidth, canvasHeight;

        public mainForm()
        {
            InitializeComponent();

            this.openFileDialog = new OpenFileDialog();
            this.saveFileDialog = new SaveFileDialog();
            this.colorDialog = new ColorDialog();

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
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.sourceImage != null) this.sourceImage.Dispose();
                if (this.workImage != null) this.workImage.Dispose();

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
                if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
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

        private void buttonHorizontalWaves_Click(object sender, EventArgs e)
        {
            this.workImage = this.filter.horozontalWaves(this.sourceImage);
            this.refreshCanvas();
        }

        private void buttonVerticalWaves_Click(object sender, EventArgs e)
        {
            this.workImage = this.filter.verticalWaves(this.sourceImage);
            this.refreshCanvas();
        }

        private void buttonGlass_Click(object sender, EventArgs e)
        {
            this.workImage = this.filter.glass(this.sourceImage);
            this.refreshCanvas();
        }

        private void buttonCorrection_Click(object sender, EventArgs e)
        {
            this.workImage = this.filter.correction(this.sourceImage, this.pictureBoxBaseColor.BackColor, 
                                                                      this.pictureBoxDestinationColor.BackColor);
            this.refreshCanvas();
        }

        private void buttonAutoCorrection_Click(object sender, EventArgs e)
        {
            this.workImage = this.filter.contrastStretching(this.sourceImage);
            this.refreshCanvas();
        }


        private void buttonIdealReflector_Click(object sender, EventArgs e)
        {
            this.workImage = this.filter.idealReflector(this.sourceImage);
            this.refreshCanvas();
        }


        private void buttonStatisticalCorrection_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap targetImage = new Bitmap(openFileDialog.FileName);

                this.workImage = this.filter.statisticalCorrection(sourceImage, targetImage);
                this.refreshCanvas();
                targetImage.Dispose();
            }
        }

        private void pictureBoxBaseColor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите мышкой пиксель на картинке");
        }

        private void pictureBoxDestinationColor_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxDestinationColor.BackColor = this.colorDialog.Color;
            }

        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.canvas.Image != null && this.workImage != null)
            {
                double widthRatio, heightRatio;

                heightRatio = (double)this.canvas.Image.Height / (double)this.canvas.Height;
                widthRatio = (double)this.workImage.Width / (double)this.canvas.Width;
                int getY = (int)Math.Round(e.Y * heightRatio);
                int getX = (int)Math.Round(e.X * widthRatio);

                this.pictureBoxBaseColor.BackColor = ((Bitmap)this.canvas.Image).GetPixel(getX, getY);
            }
        }

        private void radioButtonFilters_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonFilters.Checked)
                this.panelFilters.Visible = true;
            else
                this.panelFilters.Visible = false;
        }

        private void radioButtonSquelch_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonSquelch.Checked)
                this.panelSquelch.Visible = true;
            else
                this.panelSquelch.Visible = false;
        }
        
    }
}
