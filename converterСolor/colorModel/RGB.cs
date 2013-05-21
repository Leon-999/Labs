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

        public RGB(RGB rgb)
        {
            R = rgb.R;
            G = rgb.G;
            B = rgb.B;
        }

        public RGB(HSV hsv)
        {
            int i;
            double f, p, q, t, h;
            if (hsv.S == 0)
            {
                // achromatic (grey)
                this.R = this.G = this.B = (int)(255 * hsv.V);
            }
            h = hsv.H/60;			// sector 0 to 5
            i = (int)(Math.Floor(h));
            f = h - i;			// factorial part of h
            p = hsv.V * (1 - hsv.S);
            q = hsv.V * (1 - hsv.S * f);
            t = hsv.V * (1 - hsv.S * (1 - f));
            switch (i)
            {
                case 0:
                    this.R = (int)(255 * hsv.V);
                    this.G = (int)(255 * t);
                    this.B = (int)(255 * p);
                    break;
                case 1:
                    this.R = (int)(255 * q);
                    this.G = (int)(255 * hsv.V);
                    this.B = (int)(255 * p);
                    break;
                case 2:
                    this.R = (int)(255 * p);
                    this.G = (int)(255 * hsv.V);
                    this.B = (int)(255 * t);
                    break;
                case 3:
                    this.R = (int)(255 * p);
                    this.G = (int)(255 * q);
                    this.B = (int)(255 * hsv.V);
                    break;
                case 4:
                    this.R = (int)(255 * t);
                    this.G = (int)(255 * p);
                    this.B = (int)(255 * hsv.V);
                    break;
                default:		// case 5:
                    this.R = (int)(255 * hsv.V);
                    this.G = (int)(255 * p);
                    this.B = (int)(255 * q);
                    break;
            }
        }

        public RGB(HSL hsl)
        {
            if (hsl.S == 0)
            {
                this.R = (int)((double)hsl.L * 255.0);
                this.G = (int)((double)hsl.L * 255.0);
                this.B = (int)((double)hsl.L * 255.0);
            }
            else
            {
                double q = (hsl.L < 0.5) ? (hsl.L * (1.0 + hsl.S)) : (hsl.L + hsl.S - (hsl.L * hsl.S));
                double p = (2.0 * hsl.L) - q;

                double Hk = hsl.H / 360.0;
                double[] T = new double[3];
                T[0] = Hk + (1.0 / 3.0);
                T[1] = Hk;
                T[2] = Hk - (1.0 / 3.0);

                for (int i = 0; i < 3; i++)
                {
                    if (T[i] < 0) T[i] += 1.0;
                    if (T[i] > 1) T[i] -= 1.0;

                    if ((T[i] * 6) < 1)
                    {
                        T[i] = p + ((q - p) * 6.0 * T[i]);
                    }
                    else if ((T[i] * 2.0) < 1)
                    {
                        T[i] = q;
                    }
                    else if ((T[i] * 3.0) < 2)
                    {
                        T[i] = p + (q - p) * ((2.0 / 3.0) - T[i]) * 6.0;
                    }
                    else T[i] = p;
                }
                this.R = (int)((double)T[0] * 255.0);
                this.G = (int)((double)T[1] * 255.0);
                this.B = (int)((double)T[2] * 255.0);
            }
        }

        public RGB(XYZ xyz)
        {
            double[] Clinear = new double[3];
            Clinear[0] = xyz.X * 3.2410 - xyz.Y * 1.5374 - xyz.Z * 0.4986;
            Clinear[1] = -xyz.X * 0.9692 + xyz.Y * 1.8760 - xyz.Z * 0.0416;
            Clinear[2] = xyz.X * 0.0556 - xyz.Y * 0.2040 + xyz.Z * 1.0570;
            for (int i = 0; i < 3; i++)
            {
                Clinear[i] = (Clinear[i] <= 0.0031308) ? 12.92 * Clinear[i] : (
                    1 + 0.055) * Math.Pow(Clinear[i], (1.0 / 2.4)) - 0.055;
            }
            this.R = (int)((double)Clinear[0] * 255.0);
            this.G = (int)((double)Clinear[1] * 255.0);
            this.B = (int)((double)Clinear[2] * 255.0);
        }

        public RGB(CMYK cmyk)
        {
            double c = (double)(cmyk.C * (1 - cmyk.K) + cmyk.K);
            double m = (double)(cmyk.M * (1 - cmyk.K) + cmyk.K);
            double y = (double)(cmyk.Y * (1 - cmyk.K) + cmyk.K);
            this.R = Convert.ToInt32((1 - c) * 255.0);
            this.G = Convert.ToInt32((1 - m) * 255.0);
            this.B = Convert.ToInt32((1 - y) * 255.0);
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
