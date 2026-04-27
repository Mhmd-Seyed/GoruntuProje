using GoruntuProje.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoruntuProje.Filters_Dev3
{
    public class HistogramGerme : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap input)
        {
            Bitmap output = new Bitmap(input.Width, input.Height);

            int minR = 255, minG = 255, minB = 255;
            int maxR = 0, maxG = 0, maxB = 0;

            for (int y = 0; y < input.Height; y++)
            {
                for (int x = 0; x < input.Width; x++)
                {
                    Color p = input.GetPixel(x, y);

                    if (p.R < minR) minR = p.R;
                    if (p.G < minG) minG = p.G;
                    if (p.B < minB) minB = p.B;

                    if (p.R > maxR) maxR = p.R;
                    if (p.G > maxG) maxG = p.G;
                    if (p.B > maxB) maxB = p.B;
                }
            }

            for (int y = 0; y < input.Height; y++)
            {
                for (int x = 0; x < input.Width; x++)
                {
                    Color p = input.GetPixel(x, y);

                    int r = Stretch(p.R, minR, maxR);
                    int g = Stretch(p.G, minG, maxG);
                    int b = Stretch(p.B, minB, maxB);

                    output.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return output;
        }

        private int Stretch(int value, int min, int max)
        {
            if (max == min)
                return value;

            int result = (value - min) * 255 / (max - min);

            if (result < 0) return 0;
            if (result > 255) return 255;

            return result;
        }
    }
}
