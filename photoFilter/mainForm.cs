using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace photoFilter
{
    public partial class mainForm : Form
    {

        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Bitmap sourceImage;
        private Bitmap workImage;

        private int canvasWidth, canvasHeight;

        public mainForm()
        {
            InitializeComponent();

            this.openFileDialog = new OpenFileDialog();
            this.saveFileDialog = new SaveFileDialog();

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
                canvas.Image = workImage;
                canvas.Refresh();
            }
        }

        private void saveNewImage()
        {
            if (workImage != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workImage.Save(saveFileDialog.FileName);
                }
            }
        }

        private void radioSourseFile_CheckedChanged(object sender, EventArgs e)
        {
            this.workImage = this.sourceImage;
            this.refreshCanvas();
        }


        
    }
}
