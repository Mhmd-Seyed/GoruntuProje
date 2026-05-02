using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GoruntuProje.Core;
using System.Drawing;

namespace GoruntuProje.Filters_Dev4
{
    // Tek Eşikleme
    // Amaç: Görüntüyü belirli bir eşik değerine göre siyah-beyaz hale getirmek
    public class TekEsikleme : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        {
            Bitmap cikisResmi = new Bitmap(girisResmi.Width, girisResmi.Height);

            // Tek eşik değeri
            // Bu değerin üstü beyaz, altı siyah yapılır
            int esikDegeri = 100;

            for (int y = 0; y < girisResmi.Height; y++)
            {
                for (int x = 0; x < girisResmi.Width; x++)
                {
                    Color piksel = girisResmi.GetPixel(x, y);

                    // Renkli görüntüyü gri seviyeye çeviriyoruz
                    int griDeger = (piksel.R + piksel.G + piksel.B) / 3;

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