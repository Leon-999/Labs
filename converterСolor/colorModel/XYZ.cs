using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace converterСolor.colorModel
{
    class XYZ
    {
        private double x, y, z;
        public XYZ(double X, double Y, double Z)
        
        {
            x = (X > 0.9505) ? 0.9505 : ((X < 0) ? 0 : X);
            y = (Y > 1.0) ? 1.0 : ((Y < 0) ? 0 : Y);
            z = (Z > 1.089) ? 1.089 : ((Z < 0) ? 0 : Z);
        }

        public XYZ(XYZ xyz)
        {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
        }

        public XYZ(RGB rgb)
        {
            double r = (1.0 * (double)rgb.R / 255.0);
            double g = (1.0 * (double)rgb.G / 255.0);
            double b = (1.0 * (double)rgb.B / 255.0);

            r = (r > 0.04045) ? Math.Pow((r + 0.055) / (1 + 0.055), 2.2) : (r / 12.92);
            g = (g > 0.04045) ? Math.Pow((g + 0.055) / (1 + 0.055), 2.2) : (g / 12.92);
            b = (b > 0.04045) ? Math.Pow((b + 0.055) / (1 + 0.055), 2.2) : (b / 12.92);
            
            this.X = r * 0.4124 + g * 0.3576 + b * 0.1805;
            this.Y = r * 0.2126 + g * 0.7152 + b * 0.0722;
            this.Z = r * 0.0193 + g * 0.1192 + b * 0.9505;
        }

        public XYZ(HSV hsv)
        {
            RGB tmpRgb = new RGB(hsv);
            XYZ tmpXyz = new XYZ(tmpRgb);

            this.X = tmpXyz.X;
            this.Y = tmpXyz.Y;
            this.Z = tmpXyz.Z;
        }

        public XYZ(HSL hsl)
        {
            RGB tmpRgb = new RGB(hsl);
            XYZ tmpXyz = new XYZ(tmpRgb);

            this.X = tmpXyz.X;
            this.Y = tmpXyz.Y;
            this.Z = tmpXyz.Z;
        }

        public XYZ(CMYK cmyk)
        {
            RGB tmpRgb = new RGB(cmyk);
            XYZ tmpXyz = new XYZ(tmpRgb);

            this.X = tmpXyz.X;
            this.Y = tmpXyz.Y;
            this.Z = tmpXyz.Z;
        }

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = (value > 0.9505) ? 0.9505 : ((value < 0) ? 0 : value);
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
                y = (value > 1.0) ? 1.0 : ((value < 0) ? 0 : value);
            }
        }

        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                z = (value > 1.089) ? 1.089 : ((value < 0) ? 0 : value);
            }
        }
    }
}
