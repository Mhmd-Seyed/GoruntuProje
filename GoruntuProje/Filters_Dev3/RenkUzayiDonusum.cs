using GoruntuProje.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoruntuProje.Filters_Dev3
{
    public class RenkUzayiDonusum : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap input)
        {
            Bitmap output = new Bitmap(input.Width, input.Height);

            for (int y = 0; y < input.Height; y++)
            {
                for (int x = 0; x < input.Width; x++)
                {
                    Color p = input.GetPixel(x, y);

                    int gray = (int)(0.299 * p.R + 0.587 * p.G + 0.114 * p.B);

                    if (gray < 0) gray = 0;
                    if (gray > 255) gray = 255;

                    output.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            return output;
        }
    }
}
