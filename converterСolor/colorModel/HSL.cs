using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace converterСolor.colorModel
{
    class HSL
    {
        private double h, s, l;

        public HSL(double H, double S, double L)
        {
            h = (H > 360) ? 360 : ((H < 0) ? 0 : H);
            s = (S > 1) ? 1 : ((S < 0) ? 0 : S);
            l = (L > 1) ? 1 : ((L < 0) ? 0 : L);
        }

        public HSL(HSL hsl)
        {
            H = hsl.H;
            S = hsl.S;
            L = hsl.L;
        }

        public HSL(RGB rgb)
        {
            double r = ((double)1.0 * rgb.R / 255.0);
            double g = ((double)1.0 * rgb.G / 255.0);
            double b = ((double)1.0 * rgb.B / 255.0);

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            this.H = 0;
            this.S = 0;
            this.L = 1.0 * (double)(max + min) / 2.0;
            
            if (max == min)
            {
                this.H = 0;
            }
            else if (max == r && g >= b)
            {
                this.H = 60.0 * (g - b) / (max - min);
            }
            else if (max == r && g < b)
            {
                this.H = 60.0 * (g - b) / (max - min) + 360.0;
            }
            else if (max == g)
            {
                this.H = 60.0 * (b - r) / (max - min) + 120.0;
            }
            else if (max == b)
            {
                this.H = 60.0 * (r - g) / (max - min) + 240.0;
            }

            if (this.L == 0 || max == min)
            {
                this.S = 0;
            }
            else if (0 < this.L && this.L <= 0.5)
            {
                this.S = (max - min) / (max + min);
            }
            else if (this.L > 0.5)
            {
                this.S = (max - min) / (2 - (max + min));
            }
        }

        public HSL(HSV hsv)
        {
            RGB tmpRgb = new RGB(hsv);
            HSL tmpHsv = new HSL(tmpRgb);

            this.H = tmpHsv.H;
            this.S = tmpHsv.S;
            this.L = tmpHsv.L;
        }

        public HSL(XYZ xyz)
        {
            RGB tmpRgb = new RGB(xyz);
            HSL tmpHsl = new HSL(tmpRgb);

            this.H = tmpHsl.H;
            this.S = tmpHsl.S;
            this.L = tmpHsl.L;
        }

        public HSL(CMYK cmyk)
        {
            RGB tmpRgb = new RGB(cmyk);
            HSL tmpHsl = new HSL(tmpRgb);

            this.H = tmpHsl.H;
            this.S = tmpHsl.S;
            this.L = tmpHsl.L;
        }

        public double H
        {
            get
            {
                return h;
            }
            set
            {
                h = (value > 360) ? 360 : ((value < 0) ? 0 : value);
            }
        }

        public double S
        {
            get
            {
                return s;
            }
            set
            {
                s = (value > 1) ? 1 : ((value < 0) ? 0 : value);
            }
        }

        public double L
        {
            get
            {
                return l;
            }
            set
            {
                l = (value > 1) ? 1 : ((value < 0) ? 0 : value);
            }
        }
    }
}
