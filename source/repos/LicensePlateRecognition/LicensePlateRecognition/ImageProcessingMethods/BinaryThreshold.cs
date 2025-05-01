using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensePlateRecognition.ImageProcessingMethods
{
  
        public static class BinaryThreshold
        {
            public static Bitmap Apply(Bitmap original)
            {
                Bitmap binaryImage = new Bitmap(original.Width, original.Height);
                for (int y = 0; y < original.Height; y++)
                {
                    for (int x = 0; x < original.Width; x++)
                    {
                        Color c = original.GetPixel(x, y);
                        int gray = (int)((c.R + c.G + c.B) / 3);
                        int threshold = 128;
                        int value = gray >= threshold ? 255 : 0;
                        binaryImage.SetPixel(x, y, Color.FromArgb(value, value, value));
                    }
                }
                return binaryImage;
            }
        }
 }
