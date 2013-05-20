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
            this.V = (double)max;
            this.S = (max == 0) ? 0.0 : (1.0 - (min / max));
            if (max == r && g >= b)
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
            }
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

        public static implicit operator RGB(HSV O)
        {
            RGB N = new RGB(0, 0, 0);
            if (O.S == 0)
            {
                N.R = N.G = N.B = (int)O.V;
            }
            else
            {
                double h = 1.0 * O.H / 60.0;
                int Hi = (int)(Math.Floor(h));
                double f = h - Hi;
                double p = 1.0 * O.V * (1.0 - O.S);
                double q = 1.0 * O.V * (1.0 - (O.S * f));
                double t = 1.0 * O.V * (1.0 - (O.S * (1 - f)));

                switch (Hi)
                {
                    case 0:
                        N.R = (int)O.V;
                        N.G = (int)t;
                        N.B = (int)p;
                        break;
                    case 1:
                        N.R = (int)q;
                        N.G = (int)O.V;
                        N.B = (int)p;
                        break;
                    case 2:
                        N.R = (int)p;
                        N.G = (int)O.V;
                        N.B = (int)t;
                        break;
                    case 3:
                        N.R = (int)p;
                        N.G = (int)q;
                        N.B = (int)O.V;
                        break;
                    case 4:
                        N.R = (int)t;
                        N.G = (int)p;
                        N.B = (int)O.V;
                        break;
                    case 5:
                        N.R = (int)O.V;
                        N.G = (int)p;
                        N.B = (int)q;
                        break;
                }
            }
            return N;
        }
    }
}
