using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensePlateRecognition.ImageProcessingMethods
{
        public static class ColorSpaceConverter
        {
            public static Bitmap ConvertToHSV(Bitmap original)
            {
                Bitmap hsvImage = new Bitmap(original.Width, original.Height);

                for (int y = 0; y < original.Height; y++)
                {
                    for (int x = 0; x < original.Width; x++)
                    {
                        Color pixel = original.GetPixel(x, y);

                        float hue = pixel.GetHue();             // 0 - 360
                        float saturation = pixel.GetSaturation(); // 0 - 1
                        float brightness = pixel.GetBrightness(); // 0 - 1

                        // HSV değerlerini RGB'ye dönüştürüp görselleştirebiliriz
                        Color hsvColor = ColorFromHSV(hue, saturation, brightness);

                        hsvImage.SetPixel(x, y, hsvColor);
                    }
                }

                return hsvImage;
            }

            // HSV → RGB dönüşümü
            public static Color ColorFromHSV(double hue, double saturation, double value)
            {
                int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
                double f = hue / 60 - Math.Floor(hue / 60);

                value *= 255;
                int v = Convert.ToInt32(value);
                int p = Convert.ToInt32(value * (1 - saturation));
                int q = Convert.ToInt32(value * (1 - f * saturation));
                int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

                return hi switch
                {
                    0 => Color.FromArgb(v, t, p),
                    1 => Color.FromArgb(q, v, p),
                    2 => Color.FromArgb(p, v, t),
                    3 => Color.FromArgb(p, q, v),
                    4 => Color.FromArgb(t, p, v),
                    _ => Color.FromArgb(v, p, q),
                };
            }
        }
 }
