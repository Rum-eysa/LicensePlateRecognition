using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using LicensePlateRecognition.ImageProcessingMethods;

namespace LicensePlateRecognition.ImageProcessingMethods
{
    public static class Unsharp
    {
        public static Bitmap Apply(Bitmap original, double amount = 1.5)
        {
            Bitmap blurred = MeanFilter.Apply(original); // Gaussian yerine Mean kullanıyoruz
            Bitmap result = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color originalPixel = original.GetPixel(x, y);
                    Color blurredPixel = blurred.GetPixel(x, y);

                    int r = Clamp(originalPixel.R + (int)(amount * (originalPixel.R - blurredPixel.R)));
                    int g = Clamp(originalPixel.G + (int)(amount * (originalPixel.G - blurredPixel.G)));
                    int b = Clamp(originalPixel.B + (int)(amount * (originalPixel.B - blurredPixel.B)));

                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return result;
        }

        private static int Clamp(int value)
        {
            return Math.Max(0, Math.Min(255, value));
        }
    }
}