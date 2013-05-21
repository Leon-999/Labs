using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using converterСolor.colorModel;

namespace converterСolor
{
    public partial class mainForm : Form
    {

        private RGB rgb;
        private HSV hsv;
        private HSL hsl;
        private XYZ xyz;
        private CMYK cmyk;

        private const int EXACTNESS = 6;

        public mainForm()
        {
            InitializeComponent();

            this.rgb = new RGB(150, 150, 150);
            this.comboBoxLeft.Text = "RGB";
            this.hsv = new HSV(0, 0, 0);
            this.hsl = new HSL(0, 0, 0);
            this.xyz = new XYZ(0, 0, 0);
            this.cmyk = new CMYK(0, 0, 0, 0);
            this.convertLeftRight_Click();

            this.textBoxRight1.Enabled = false;
            this.textBoxRight2.Enabled = false;
            this.textBoxRight3.Enabled = false;
            this.textBoxRight4.Enabled = false;

            //this.comboBoxLeft_SelectedIndexChanged();
            //this.comboBoxRight_SelectedIndexChanged();
        }

        private void comboBoxLeft_SelectedIndexChanged(object sender = null, EventArgs e = null)
        {
            double value1 = 0, value2 = 0, value3 = 0, value4 = 0;

            if (this.comboBoxLeft.Text == "RGB")
            {
                this.labelLeft1.Text = "R";
                this.labelLeft2.Text = "G";
                this.labelLeft3.Text = "B";
                this.labelLeft4.Visible = false;
                this.textBoxLeft4.Visible = false;

                value1 = this.rgb.R;
                value2 = this.rgb.G;
                value3 = this.rgb.B;
            }
            else if (this.comboBoxLeft.Text == "HSV")
            {
                this.labelLeft1.Text = "H";
                this.labelLeft2.Text = "S";
                this.labelLeft3.Text = "V";
                this.labelLeft4.Visible = false;
                this.textBoxLeft4.Visible = false;

                value1 = this.hsv.H;
                value2 = this.hsv.S;
                value3 = this.hsv.V;
            }
            else if (this.comboBoxLeft.Text == "HSL")
            {
                this.labelLeft1.Text = "H";
                this.labelLeft2.Text = "S";
                this.labelLeft3.Text = "L";
                this.labelLeft4.Visible = false;
                this.textBoxLeft4.Visible = false;

                value1 = this.hsl.H;
                value2 = this.hsl.S;
                value3 = this.hsl.L;
            }
            else if (this.comboBoxLeft.Text == "XYZ")
            {
                this.labelLeft1.Text = "X";
                this.labelLeft2.Text = "Y";
                this.labelLeft3.Text = "Z";
                this.labelLeft4.Visible = false;
                this.textBoxLeft4.Visible = false;

                value1 = this.xyz.X;
                value2 = this.xyz.Y;
                value3 = this.xyz.Z;
            }
            else if (this.comboBoxLeft.Text == "CMYK")
            {
                this.labelLeft1.Text = "C";
                this.labelLeft2.Text = "M";
                this.labelLeft3.Text = "Y";
                this.labelLeft4.Text = "K";
                this.labelLeft4.Visible = true;
                this.textBoxLeft4.Visible = true;

                value1 = this.cmyk.C;
                value2 = this.cmyk.M;
                value3 = this.cmyk.Y;
                value4 = this.cmyk.K;
            }

            value1 = Math.Round(value1, mainForm.EXACTNESS);
            value2 = Math.Round(value2, mainForm.EXACTNESS);
            value3 = Math.Round(value3, mainForm.EXACTNESS);
            value4 = Math.Round(value4, mainForm.EXACTNESS);

            this.textBoxLeft1.Text = value1.ToString();
            this.textBoxLeft2.Text = value2.ToString();
            this.textBoxLeft3.Text = value3.ToString();
            this.textBoxLeft4.Text = value4.ToString();
        }

        private void comboBoxRight_SelectedIndexChanged(object sender = null, EventArgs e = null)
        {
            double value1 = 0, value2 = 0, value3 = 0, value4 = 0;

            if (this.comboBoxRight.Text == "RGB")
            {
                this.labelRight1.Text = "R";
                this.labelRight2.Text = "G";
                this.labelRight3.Text = "B";
                this.labelRight4.Visible = false;
                this.textBoxRight4.Visible = false;

                value1 = this.rgb.R;
                value2 = this.rgb.G;
                value3 = this.rgb.B;
            }
            else if (this.comboBoxRight.Text == "HSV")
            {
                this.labelRight1.Text = "H";
                this.labelRight2.Text = "S";
                this.labelRight3.Text = "V";
                this.labelRight4.Visible = false;
                this.textBoxRight4.Visible = false;

                value1 = this.hsv.H;
                value2 = this.hsv.S;
                value3 = this.hsv.V;
            }
            else if (this.comboBoxRight.Text == "HSL")
            {
                this.labelRight1.Text = "H";
                this.labelRight2.Text = "S";
                this.labelRight3.Text = "L";
                this.labelRight4.Visible = false;
                this.textBoxRight4.Visible = false;

                value1 = this.hsl.H;
                value2 = this.hsl.S;
                value3 = this.hsl.L;
            }
            else if (this.comboBoxRight.Text == "XYZ")
            {
                this.labelRight1.Text = "X";
                this.labelRight2.Text = "Y";
                this.labelRight3.Text = "Z";
                this.labelRight4.Visible = false;
                this.textBoxRight4.Visible = false;

                value1 = this.xyz.X;
                value2 = this.xyz.Y;
                value3 = this.xyz.Z;
            }
            else if (this.comboBoxRight.Text == "CMYK")
            {
                this.labelRight1.Text = "C";
                this.labelRight2.Text = "M";
                this.labelRight3.Text = "Y";
                this.labelRight4.Text = "K";
                this.labelRight4.Visible = true;
                this.textBoxRight4.Visible = true;

                value1 = this.cmyk.C;
                value2 = this.cmyk.M;
                value3 = this.cmyk.Y;
                value4 = this.cmyk.K;
            }

            value1 = Math.Round(value1, mainForm.EXACTNESS);
            value2 = Math.Round(value2, mainForm.EXACTNESS);
            value3 = Math.Round(value3, mainForm.EXACTNESS);
            value4 = Math.Round(value4, mainForm.EXACTNESS);

            this.textBoxRight1.Text = value1.ToString();
            this.textBoxRight2.Text = value2.ToString();
            this.textBoxRight3.Text = value3.ToString();
            this.textBoxRight4.Text = value4.ToString();
        }

        private void convertLeftRight_Click(object sender = null, EventArgs e = null)
        {
            double value1, value2, value3, value4;

            try
            {
                value1 = Math.Abs(Convert.ToDouble(this.textBoxLeft1.Text));
                value2 = Math.Abs(Convert.ToDouble(this.textBoxLeft2.Text));
                value3 = Math.Abs(Convert.ToDouble(this.textBoxLeft3.Text));
                if (this.textBoxLeft4.Text != "") 
                    value4 = Math.Abs(Convert.ToDouble(this.textBoxLeft4.Text)); 
                else
                    value4 = -1;

                this.convert(value1, value2, value3, value4);
                this.drawColor();
            }
            catch
            {
                MessageBox.Show("Введены некоректные значения в текстовые поля", "Ошибка");
            }
        }

        private void convert(double value1, double value2, double value3, double value4)
        {
            if (this.comboBoxLeft.Text == "RGB")
            {
                this.rgb = new RGB((int)value1, (int)value2, (int)value3);
                this.hsv = new HSV(rgb);
                this.hsl = new HSL(rgb);
                this.xyz = new XYZ(rgb);
                this.cmyk = new CMYK(rgb);
            }
            else if (this.comboBoxLeft.Text == "HSV")
            {
                this.hsv = new HSV(value1, value2, value3);
                this.rgb = new RGB(hsv);
                this.hsl = new HSL(hsv);
                this.xyz = new XYZ(hsv);
                this.cmyk = new CMYK(hsv);
            }
            else if (this.comboBoxLeft.Text == "HSL")
            {
                this.hsl = new HSL(value1, value2, value3);
                this.rgb = new RGB(hsl);
                this.hsv = new HSV(hsl);
                this.xyz = new XYZ(hsl);
                this.cmyk = new CMYK(hsl);
            }
            else if (this.comboBoxLeft.Text == "XYZ")
            {
                this.xyz = new XYZ(value1, value2, value3);
                this.hsv = new HSV(xyz);
                this.hsl = new HSL(xyz);
                this.rgb = new RGB(xyz);
                this.cmyk = new CMYK(xyz);
            }
            else if (this.comboBoxLeft.Text == "CMYK")
            {
                this.cmyk = new CMYK(value1, value2, value3, value4);
                this.hsv = new HSV(cmyk);
                this.hsl = new HSL(cmyk);
                this.xyz = new XYZ(cmyk);
                this.rgb = new RGB(cmyk);
            }

            this.comboBoxLeft_SelectedIndexChanged();
            this.comboBoxRight_SelectedIndexChanged();
        }

        private void drawColor()
        {
            this.pictureBox1.BackColor = Color.FromArgb(this.rgb.R, this.rgb.G, this.rgb.B);
        }
    }
}
