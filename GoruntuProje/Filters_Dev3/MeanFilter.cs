using GoruntuProje.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoruntuProje.Filters_Dev3
{
    public class MeanFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap input)
        {
            Bitmap output = new Bitmap(input.Width, input.Height);

            // Kenar pikselleri aynen kopyala
            for (int y = 0; y < input.Height; y++)
            {
                for (int x = 0; x < input.Width; x++)
                {
                    output.SetPixel(x, y, input.GetPixel(x, y));
                }
            }

            // 3x3 mean filtre
            for (int y = 1; y < input.Height - 1; y++)
            {
                for (int x = 1; x < input.Width - 1; x++)
                {
                    int sumR = 0;
                    int sumG = 0;
                    int sumB = 0;

                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color p = input.GetPixel(x + i, y + j);

                            sumR += p.R;
                            sumG += p.G;
                            sumB += p.B;
                        }
                    }

                    int r = sumR / 9;
                    int g = sumG / 9;
                    int b = sumB / 9;

                    output.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return output;
        }
    }
}
