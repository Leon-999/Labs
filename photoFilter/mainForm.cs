using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using photoFilter.filters;
using photoFilter.squelch;

namespace photoFilter
{
    public partial class mainForm : Form
    {

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ColorDialog colorDialog;
        private Bitmap sourceImage;
        private Bitmap workImage;

        //private BinaryMatrix structoralMatrix;

        private ManagerFilters filter;

        private int canvasWidth, canvasHeight;

        public mainForm()
        {
            InitializeComponent();
            this.radioButton4x4_CheckedChanged();
            this.radioButton5x5_CheckedChanged();
            this.radioButtonSquelch_CheckedChanged();

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
                        this.canvas.Width = canvasWidth;
                        this.canvas.Height = Convert.ToInt16(this.sourceImage.Height * widthRatio);
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

                this.workImage = this.filter.statisticalCorrection(this.sourceImage, targetImage);
                this.refreshCanvas();
                targetImage.Dispose();
            }
        }

        private void buttonBuildup_Click(object sender, EventArgs e)
        {
            BinaryMatrix structuralElement = this.readStruralElement();
            this.workImage = this.filter.buildup(this.sourceImage, structuralElement);
            this.refreshCanvas();
        }

        private void buttonErosion_Click(object sender, EventArgs e)
        {
            BinaryMatrix structuralElement = this.readStruralElement();
            this.workImage = this.filter.erosion(this.sourceImage, structuralElement);
            this.refreshCanvas();
        }


        private void buttonDisclosure_Click(object sender, EventArgs e)
        {
            BinaryMatrix structuralElement = this.readStruralElement();
            this.workImage = this.filter.disclosure(this.sourceImage, structuralElement);
            this.refreshCanvas();
        }

        private void buttonClosing_Click(object sender, EventArgs e)
        {
            BinaryMatrix structuralElement = this.readStruralElement();
            this.workImage = this.filter.closing(this.sourceImage, structuralElement);
            this.refreshCanvas();
        }

        private void buttonMorphologicalGradient_Click(object sender, EventArgs e)
        {
            BinaryMatrix structuralElement = this.readStruralElement();
            this.workImage = this.filter.morphologicalGradient(this.sourceImage, structuralElement);
            this.refreshCanvas();
        }

        private void buttonBlackHat_Click(object sender, EventArgs e)
        {
            BinaryMatrix structuralElement = this.readStruralElement();
            this.workImage = this.filter.blackHat(this.sourceImage, structuralElement);
            this.refreshCanvas();
        }

        private void buttonConventionalBuildup_Click(object sender, EventArgs e)
        {
            BinaryMatrix structuralElement = this.readStruralElement();
            this.workImage = this.filter.conventionalBuildup(this.sourceImage, structuralElement);
            this.refreshCanvas();
        }

        private void buttonMedianFilter_Click(object sender, EventArgs e)
        {
            try
            {
                int vicinity = Convert.ToInt32(this.textBoxVicinityM.Text);
                if (vicinity % 2 == 1)
                {
                    this.workImage = this.filter.medianFilter(this.sourceImage, vicinity);
                    this.refreshCanvas();
                }
                else
                {
                    MessageBox.Show("Окрестность должна быть нечётной");
                }
            }
            catch
            {
                MessageBox.Show("Окрестность введена некорректно");
            }
        }


        private void buttonGaussianFilter_Click(object sender, EventArgs e)
        {
            //try
            //{
                int vicinity = Convert.ToInt32(this.textBoxVicinityG.Text);
                if (vicinity % 2 == 1)
                {
                    this.workImage = this.filter.gaussianFilter(this.sourceImage, vicinity);
                    this.refreshCanvas();
                }
                else
                {
                    MessageBox.Show("Окрестность должна быть нечётной");
                }
            /*}
            catch
            {
                MessageBox.Show("Окрестность введена некорректно");
            }*/
        }

        //ужас
        private BinaryMatrix readStruralElement()
        {
            BinaryMatrix result;
            int width = 0, height = 0;

            if (this.radioButton3x3.Checked)
                width = height = 3;
            else if (this.radioButton4x4.Checked)
                width = height = 4;
            else if (this.radioButton5x5.Checked)
                width = height = 5;

            result = new BinaryMatrix(width, height);

            result.setValue(0, 0, Convert.ToBoolean(this.pictureBoxSE0x0.Tag));
            result.setValue(0, 1, Convert.ToBoolean(this.pictureBoxSE0x2.Tag));
            result.setValue(0, 2, Convert.ToBoolean(this.pictureBoxSE0x2.Tag));

            result.setValue(1, 0, Convert.ToBoolean(this.pictureBoxSE1x0.Tag));
            result.setValue(1, 1, Convert.ToBoolean(this.pictureBoxSE1x1.Tag));
            result.setValue(1, 2, Convert.ToBoolean(this.pictureBoxSE1x2.Tag));

            result.setValue(2, 0, Convert.ToBoolean(this.pictureBoxSE2x0.Tag));
            result.setValue(2, 1, Convert.ToBoolean(this.pictureBoxSE2x1.Tag));
            result.setValue(2, 2, Convert.ToBoolean(this.pictureBoxSE2x2.Tag));

            if (this.radioButton4x4.Checked || this.radioButton5x5.Checked)
            {
                result.setValue(3, 0, Convert.ToBoolean(this.pictureBoxSE3x0.Tag));
                result.setValue(3, 1, Convert.ToBoolean(this.pictureBoxSE3x1.Tag));
                result.setValue(3, 2, Convert.ToBoolean(this.pictureBoxSE3x2.Tag));
                result.setValue(3, 3, Convert.ToBoolean(this.pictureBoxSE3x3.Tag));

                result.setValue(0, 3, Convert.ToBoolean(this.pictureBoxSE0x3.Tag));
                result.setValue(1, 3, Convert.ToBoolean(this.pictureBoxSE1x3.Tag));
                result.setValue(2, 3, Convert.ToBoolean(this.pictureBoxSE2x3.Tag));
            }
            if (this.radioButton5x5.Checked)
            {
                result.setValue(4, 0, Convert.ToBoolean(this.pictureBoxSE4x0.Tag));
                result.setValue(4, 1, Convert.ToBoolean(this.pictureBoxSE4x1.Tag));
                result.setValue(4, 2, Convert.ToBoolean(this.pictureBoxSE4x2.Tag));
                result.setValue(4, 3, Convert.ToBoolean(this.pictureBoxSE4x3.Tag));
                result.setValue(4, 4, Convert.ToBoolean(this.pictureBoxSE4x4.Tag));

                result.setValue(0, 4, Convert.ToBoolean(this.pictureBoxSE0x4.Tag));
                result.setValue(1, 4, Convert.ToBoolean(this.pictureBoxSE1x4.Tag));
                result.setValue(2, 4, Convert.ToBoolean(this.pictureBoxSE2x4.Tag));
                result.setValue(3, 4, Convert.ToBoolean(this.pictureBoxSE2x4.Tag));
            }

            return result;
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

        private void radioButtonFilters_CheckedChanged(object sender = null, EventArgs e = null)
        {
            if (this.radioButtonFilters.Checked)
                this.panelFilters.Visible = true;
            else
                this.panelFilters.Visible = false;
        }

        private void radioButtonSquelch_CheckedChanged(object sender = null, EventArgs e = null)
        {
            if (this.radioButtonSquelch.Checked)
                this.panelSquelch.Visible = true;
            else
                this.panelSquelch.Visible = false;
        }

        private void pictureBoxSENxM_Click(object sender, EventArgs e)
        {
            PictureBox pictureBoxSE = (PictureBox)sender;

            int n,m;
            for (n = 0; n < 5; ++n)
                for (m = 0; m < 5; ++m)
                {
                    if (pictureBoxSE.Name == "pictureBoxSE" + n + "x" + m)
                    {
                        if (pictureBoxSE.BackColor == Color.White)
                        {
                            pictureBoxSE.BackColor = Color.DimGray;
                            pictureBoxSE.Tag = "true";
                        }
                        else
                        {
                            pictureBoxSE.BackColor = Color.White;
                            pictureBoxSE.Tag = "false";
                        }
                    }
                }

        }
        //выглядит ужастно
        private void radioButton4x4_CheckedChanged(object sender = null, EventArgs e = null)
        {
            if (this.radioButton4x4.Checked || this.radioButton5x5.Checked)
            {
                this.pictureBoxSE3x0.Visible = true;
                this.pictureBoxSE3x1.Visible = true;
                this.pictureBoxSE3x2.Visible = true;
                this.pictureBoxSE3x3.Visible = true;
                this.pictureBoxSE0x3.Visible = true;
                this.pictureBoxSE1x3.Visible = true;
                this.pictureBoxSE2x3.Visible = true;
            }
            else
            {
                if (!this.radioButton5x5.Checked)
                {
                    this.pictureBoxSE3x0.Visible = false;
                    this.pictureBoxSE3x1.Visible = false;
                    this.pictureBoxSE3x2.Visible = false;
                    this.pictureBoxSE3x3.Visible = false;
                    this.pictureBoxSE0x3.Visible = false;
                    this.pictureBoxSE1x3.Visible = false;
                    this.pictureBoxSE2x3.Visible = false;
                }
            }
        }

        private void radioButton5x5_CheckedChanged(object sender = null, EventArgs e = null)
        {
            this.radioButton4x4_CheckedChanged();

            if (this.radioButton5x5.Checked)
            {
                this.pictureBoxSE4x0.Visible = true;
                this.pictureBoxSE4x1.Visible = true;
                this.pictureBoxSE4x2.Visible = true;
                this.pictureBoxSE4x3.Visible = true;
                this.pictureBoxSE4x4.Visible = true;
                this.pictureBoxSE0x4.Visible = true;
                this.pictureBoxSE1x4.Visible = true;
                this.pictureBoxSE2x4.Visible = true;
                this.pictureBoxSE3x4.Visible = true;

            }
            else
            {
                this.pictureBoxSE4x0.Visible = false;
                this.pictureBoxSE4x1.Visible = false;
                this.pictureBoxSE4x2.Visible = false;
                this.pictureBoxSE4x3.Visible = false;
                this.pictureBoxSE4x4.Visible = false;
                this.pictureBoxSE0x4.Visible = false;
                this.pictureBoxSE1x4.Visible = false;
                this.pictureBoxSE2x4.Visible = false;
                this.pictureBoxSE3x4.Visible = false;
            }
        }

        private void radioButton3x3_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButton4x4_CheckedChanged();
            this.radioButton5x5_CheckedChanged();
        }
        
    }
}
