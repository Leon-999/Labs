using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace photoFilter.squelch
{
    class GaussianFilter
    {
        internal Bitmap employ(Bitmap sourceImage)
        {
            Bitmap result = null;

            if (sourceImage != null)
            {
                result = new Bitmap(sourceImage.Width, sourceImage.Height);

                double sum = 0;
                double s = 0;
                double r = 1.398;
                double r2 = 2 * r * r;
                int n = 3;
                double ss;
                double colorR=0;
                double colorG=0;
                double colorB=0;
                double[][] w = new double[n] [];
                for (int i = 0; i < n; i++)
                {
                    w[i] = new double[n];
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        ss = (i * i + j * j) / r2;
                        w[i][j] = 1 / (Math.Sqrt(Math.PI * r2)) * Math.Exp(ss * (-1.0));
                        //cout<<w[i][j]<<endl;
                        s += w[i][j];
                    }
                    for (int j = 0; j < n; j++)
                    {

                        w[i][j] = w[i][j] / s;
                        sum += w[i][j];
                    }
                }

                Color currentColor = new Color();
                for (int yi = 0; yi < sourceImage.Height - n; yi++)
                {
                    for (int xj = 0; xj < sourceImage.Width - n; xj++)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            colorR = 0;
                            colorG = 0;
                            colorB = 0;
                            for (int j = 0; j < n; j++)
                            {
                                currentColor = sourceImage.GetPixel(j + xj,i + yi);
                                colorR += w[i][j] * currentColor.R;
                                colorG += w[i][j] * currentColor.G;
                                colorB += w[i][j] * currentColor.B;
                            }
                        }
                        colorR /= sum;
                        colorG /= sum;
                        colorB /= sum;

                        int currentedR = (int)(colorR * currentColor.R);
                        currentedR = (currentedR > 255) ? 255 : (currentedR < 0) ? 0 : currentedR;
                        int currentedG = (int)(colorG * currentColor.G);
                        currentedG = (currentedG > 255) ? 255 : (currentedG < 0) ? 0 : currentedG;
                        int currentedB = (int)(colorB * currentColor.B);
                        currentedB = (currentedB > 255) ? 255 : (currentedB < 0) ? 0 : currentedB;

                        currentColor = Color.FromArgb(currentedR,currentedG, currentedB );
                        result.SetPixel(xj, yi, currentColor);

                        ManagerFilters.featuredPixel();
                    }
                }

                ManagerFilters.completeWork();
            }

            return result;
        }
    }
}

/*double s=0;
    double r=1.398;
    double r2=2*r*r;
    int n=3;
    double ss;
    double color;
    double** w=new double*[n];
    for(int i=0;i<n;i++){
        w[i]=new double[n];
    }
    for (int i =0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            ss=(i*i+j*j)/r2;
            w[i][j]=1/(sqrt(M_PI*r2))*exp(ss*(-1.0));
            //cout<<w[i][j]<<endl;
            s+=w[i][j];
        }
        for (int j = 0; j < n; j++)
        {
            
            w[i][j]=w[i][j]/s;
        }
    }
    for (int yi =n; yi < height-n; yi++)
    {
        for (int xj = n; xj < width-n; xj++)
        {
                for (int i =0; i < n; i++)
                {color=0;
                    for (int j = 0; j < n; j++)
                    {
                        color+=w[i][j]*LightMap[(int)(i+yi)][(int)(j+xj)];
                    }
                }
                LightMap[(int)(yi)][(int)(xj)] =color;
        }
    }*/