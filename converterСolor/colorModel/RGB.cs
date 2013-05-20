using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace converterСolor.colorModel
{
    class RGB
    {
        private int r, g, b;

        public RGB(int R, int G, int B)
        {
            r = (R > 255) ? 255 : ((R < 0) ? 0 : R);
            g = (G > 255) ? 255 : ((G < 0) ? 0 : G);
            b = (B > 255) ? 255 : ((B < 0) ? 0 : B);
        }

        public RGB(RGB C)
        {
            R = C.R;
            G = C.G;
            B = C.B;
        }

        public RGB(HSV hsv)
        {
            if (hsv.S == 0)
            {
                this.R = this.G = this.B = (int)hsv.V;
            }
            else
            {
                double h = hsv.H / 60.0;
                int Hi = (int)(Math.Floor(h));
                double Vmin = hsv.V * (1.0 - hsv.S);
                double a = (hsv.V - Vmin) * ((hsv.H % 60) / 60);
                double Vdec = hsv.V - a;
                double Vinc = Vmin + a;

                switch (Hi)
                {
                    case 0:
                        this.R = (int)hsv.V;
                        this.G = (int)Vinc;
                        this.B = (int)Vmin;
                        break;
                    case 1:
                        this.R = (int)Vdec;
                        this.G = (int)hsv.V;
                        this.B = (int)Vmin;
                        break;
                    case 2:
                        this.R = (int)Vmin;
                        this.G = (int)hsv.V;
                        this.B = (int)Vinc;
                        break;
                    case 3:
                        this.R = (int)Vmin;
                        this.G = (int)Vdec;
                        this.B = (int)hsv.V;
                        break;
                    case 4:
                        this.R = (int)Vinc;
                        this.G = (int)Vmin;
                        this.B = (int)hsv.V;
                        break;
                    case 5:
                        this.R = (int)hsv.V;
                        this.G = (int)Vmin;
                        this.B = (int)Vdec;
                        break;
                }
            }
        }

        public int R
        {
            get
            {
                return r;
            }
            set
            {
                r = (value > 255) ? 255 : ((value < 0) ? 0 : value);
            }
        }

        public int G
        {
            get
            {
                return g;
            }
            set
            {
                g = (value > 255) ? 255 : ((value < 0) ? 0 : value);
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = (value > 255) ? 255 : ((value < 0) ? 0 : value);
            }
        }
        /*
        public static implicit operator HSL(RGB O)
        {
            HSL N = new HSL(0.0, 0.0, 0.0);
            double r = ((double)1.0 * O.R / 255.0);
            double g = ((double)1.0 * O.G / 255.0);
            double b = ((double)1.0 * O.B / 255.0);

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));
            N.L = 1.0 * (double)(max + min) / 2.0;
            if (max == min)
            {
                N.H = 0;
            }
            else if (max == r && g >= b)
            {
                N.H = 60.0 * (g - b) / (max - min);
            }
            else if (max == r && g < b)
            {
                N.H = 60.0 * (g - b) / (max - min) + 360.0;
            }
            else if (max == g)
            {
                N.H = 60.0 * (b - r) / (max - min) + 120.0;
            }
            else if (max == b)
            {
                N.H = 60.0 * (r - g) / (max - min) + 240.0;
            }
            if (N.L == 0 || max == min)
            {
                N.S = 0;
            }
            else if (0 < N.L && N.L <= 0.5)
            {
                N.S = (max - min) / (max + min);
            }
            else if (N.L > 0.5)
            {
                N.S = (max - min) / (2 - (max + min));
            }
            return N;
        }
        public static implicit operator CMYK(RGB O)
        {
            CMYK N = new CMYK(0.0, 0.0, 0.0, 0.0);
            double c = (double)(1.0 * (255 - O.R) / 255);
            double m = (double)(1.0 * (255 - O.G) / 255);
            double y = (double)(1.0 * (255 - O.B) / 255);

            double k = (double)Math.Min(c, Math.Min(m, y));
            N.K = k;
            if (!(k == 1.0))
            {
                N.C = (c - k) / (1 - k);
                N.M = (m - k) / (1 - k);
                N.Y = (y - k) / (1 - k);
            }
            return N;
        }
        public static implicit operator XYZ(RGB O)
        {
            XYZ N = new XYZ(0.0, 0.0, 0.0);
            double r = (1.0 * (double)O.R / 255.0);
            double g = (1.0 * (double)O.G / 255.0);
            double b = (1.0 * (double)O.B / 255.0);

            r = (r > 0.04045) ? Math.Pow((r + 0.055) / (1 + 0.055), 2.2) : (r / 12.92);
            g = (g > 0.04045) ? Math.Pow((g + 0.055) / (1 + 0.055), 2.2) : (g / 12.92);
            b = (b > 0.04045) ? Math.Pow((b + 0.055) / (1 + 0.055), 2.2) : (b / 12.92);

            N.X = r * 0.4124 + g * 0.3576 + b * 0.1805;
            N.Y = r * 0.2126 + g * 0.7152 + b * 0.0722;
            N.Z = r * 0.0193 + g * 0.1192 + b * 0.9505;

            return N;
        }*/

    }
}
