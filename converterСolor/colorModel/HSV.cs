using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace converterСolor.colorModel
{
    class HSV
    {
        private double h, s, v;

        public HSV(double H, double S, double V)
        {
            this.h = (H > 360) ? 360 : ((H < 0) ? 0 : H);
            this.s = (S > 1) ? 1 : ((S < 0) ? 0 : S);
            this.v = (V > 1) ? 1 : ((V < 0) ? 0 : V);
        }

        public HSV(HSV hsv)
        {
            this.H = hsv.H;
            this.S = hsv.S;
            this.V = hsv.V;
        }

        public HSV(RGB rgb)
        {
            double r = ((double)rgb.R / 255.0);
            double g = ((double)rgb.G / 255.0);
            double b = ((double)rgb.B / 255.0);

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            this.V = max;

            double delta = max - min;

            if (max != 0)
                this.S = delta / max;
            else
            {
                this.S = 0;
                this.H = -1;
            }

            if (max == min)
            {
                this.H = 0;
            }
            else if (r == max)
                this.H = (g - b) / delta;		// between yellow & magenta
            else if (g == max)
                this.H = 2 + (b - r) / delta;	// between cyan & yellow
            else
                this.H = 4 + (r - g) / delta;	// between magenta & cyan
            this.H *= 60;				// degrees
            if (this.H < 0) this.H += 360;
            /*
            this.S = (max == 0) ? 0.0 : (1.0 - (min / max));

            if (max == min)
            {
                this.H = 0;
            }
            else if (max == r && g >= b)
            {
                this.H = 60 * (g - b) / (max - min);
            }
            else if (max == r && g < b)
            {
                this.H = 60 * (g - b) / (max - min) + 360;
            }
            else if (max == g)
            {
                this.H = 60 * (b - r) / (max - min) + 120;
            }
            else if (max == b)
            {
                this.H = 60 * (r - g) / (max - min) + 240;
            }*/
        }

        public HSV(HSL hsl)
        {
            RGB tmpRgb = new RGB(hsl);
            HSV tmpHsv = new HSV(tmpRgb);

            this.H = tmpHsv.H;
            this.S = tmpHsv.S;
            this.V = tmpHsv.V;
        }

        public HSV(XYZ xyz)
        {
            RGB tmpRgb = new RGB(xyz);
            HSV tmpHsv = new HSV(tmpRgb);

            this.H = tmpHsv.H;
            this.S = tmpHsv.S;
            this.V = tmpHsv.V;
        }

        public HSV(CMYK cmyk)
        {
            RGB tmpRgb = new RGB(cmyk);
            HSV tmpHsv = new HSV(tmpRgb);

            this.H = tmpHsv.H;
            this.S = tmpHsv.S;
            this.V = tmpHsv.V;
        }

        public double H
        {
            get
            {
                return h;
            }
            set
            {
                if (H == -1)
                    h = H;
                else
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

        public double V
        {
            get
            {
                return v;
            }
            set
            {
                v = (value > 1) ? 1 : ((value < 0) ? 0 : value);
            }
        }
    }
}
