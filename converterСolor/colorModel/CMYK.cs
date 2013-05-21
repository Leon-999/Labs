using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace converterСolor.colorModel
{
    class CMYK
    {
        private double c, m, y, k;

        public CMYK(double C, double M, double Y, double K)
        {
            c = (C > 1) ? 1 : ((C < 0) ? 0 : C); //сине-зелёный
            m = (M > 1) ? 1 : ((M < 0) ? 0 : M);//пурпурный
            y = (Y > 1) ? 1 : ((Y < 0) ? 0 : Y);//жёлтый
            k = (K > 1) ? 1 : ((K < 0) ? 0 : K);//чёрный
        }

        public CMYK(CMYK c)
        {
            C = c.C;
            M = c.M;
            Y = c.Y;
            K = c.K;
        }

        public CMYK(RGB rgb)
        {
            double c = (double)(1.0 * (255 - rgb.R) / 255);
            double m = (double)(1.0 * (255 - rgb.G) / 255);
            double y = (double)(1.0 * (255 - rgb.B) / 255);

            double k = (double)Math.Min(c, Math.Min(m, y));
            this.K = k;
            if (!(k == 1.0))
            {
                this.C = (c - k) / (1 - k);
                this.M = (m - k) / (1 - k);
                this.Y = (y - k) / (1 - k);
            }
            else
            {
                this.C = 0;
                this.M = 0;
                this.Y = 0;
            }
        }

        public CMYK(HSV hsv)
        {
            RGB tmpRgb = new RGB(hsv);
            CMYK tmpCmyk = new CMYK(tmpRgb);

            this.C = tmpCmyk.C;
            this.M = tmpCmyk.M;
            this.Y = tmpCmyk.Y;
            this.K = tmpCmyk.K;
        }

        public CMYK(HSL hsl)
        {
            RGB tmpRgb = new RGB(hsl);
            CMYK tmpCmyk = new CMYK(tmpRgb);

            this.C = tmpCmyk.C;
            this.M = tmpCmyk.M;
            this.Y = tmpCmyk.Y;
            this.K = tmpCmyk.K;
        }

        public CMYK(XYZ xyz)
        {
            RGB tmpRgb = new RGB(xyz);
            CMYK tmpCmyk = new CMYK(tmpRgb);

            this.C = tmpCmyk.C;
            this.M = tmpCmyk.M;
            this.Y = tmpCmyk.Y;
            this.K = tmpCmyk.K;
        }

        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = (value > 1) ? 1 : ((value < 0) ? 0 : value);
            }
        }

        public double M
        {
            get
            {
                return m;
            }
            set
            {
                m = (value > 1) ? 1 : ((value < 0) ? 0 : value);
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = (value > 1) ? 1 : ((value < 0) ? 0 : value);
            }
        }

        public double K
        {
            get
            {
                return k;
            }
            set
            {
                k = (value > 1) ? 1 : ((value < 0) ? 0 : value);
            }
        }

    }
}
