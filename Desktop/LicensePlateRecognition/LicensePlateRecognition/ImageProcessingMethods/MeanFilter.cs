using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensePlateRecognition.ImageProcessingMethods
{
    public static class MeanFilter
    {
        public static Bitmap Apply(Bitmap original)
        {
            Bitmap blurred = new Bitmap(original.Width, original.Height);

            int[,] kernel = {
                {1, 1, 1},
                {1, 1, 1},
                {1, 1, 1}
            };
            int kernelSize = 3;
            int kernelSum = 9; // Tüm elemanların toplamı

            int offset = kernelSize / 2;

            for (int y = offset; y < original.Height - offset; y++)
            {
                for (int x = offset; x < original.Width - offset; x++)
                {
                    int sumR = 0, sumG = 0, sumB = 0;

                    for (int ky = -offset; ky <= offset; ky++)
                    {
                        for (int kx = -offset; kx <= offset; kx++)
                        {
                            Color pixel = original.GetPixel(x + kx, y + ky);
                            sumR += pixel.R;
                            sumG += pixel.G;
                            sumB += pixel.B;
                        }
                    }

                    int avgR = sumR / kernelSum;
                    int avgG = sumG / kernelSum;
                    int avgB = sumB / kernelSum;

                    blurred.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return blurred;
        }
    }
}
