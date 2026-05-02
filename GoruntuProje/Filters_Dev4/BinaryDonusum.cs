using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GoruntuProje.Core;
using System.Drawing;

namespace GoruntuProje.Filters_Dev4
{
    // Binary Dönüşüm
    // Amaç: Görüntüyü sadece siyah ve beyaz hale getirmek
    public class BinaryDonusum : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        {
            Bitmap cikisResmi = new Bitmap(girisResmi.Width, girisResmi.Height);

            // Eşik değeri
            // 0 - 255 arasıdır
            // 128 orta değerdir
            int esikDegeri = 128;

            for (int y = 0; y < girisResmi.Height; y++)
            {
                for (int x = 0; x < girisResmi.Width; x++)
                {
                    Color piksel = girisResmi.GetPixel(x, y);

                    // RGB değerlerinden gri değer hesaplanır
                    int griDeger = (piksel.R + piksel.G + piksel.B) / 3;

                    // Eğer gri değer eşik değerinden büyükse beyaz yapılır
                    // Küçükse siyah yapılır
                    if (griDeger >= esikDegeri)
                    {
                        cikisResmi.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        cikisResmi.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return cikisResmi;
        }
    }
}