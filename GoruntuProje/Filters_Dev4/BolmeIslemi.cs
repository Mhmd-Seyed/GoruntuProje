using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GoruntuProje.Core;
using System.Drawing;

namespace GoruntuProje.Filters_Dev4
{
    // Aritmetik Bölme İşlemi
    // Amaç: Görüntüdeki her pikselin RGB değerlerini sabit bir sayıya bölerek görüntüyü koyulaştırmak
    public class BolmeIslemi : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        {
            Bitmap cikisResmi = new Bitmap(girisResmi.Width, girisResmi.Height);

            // Bölünecek sabit değer
            // Bu değer arttıkça görüntü daha koyu olur
            int bolmeDegeri = 4; //koyulaşsın diye 4 seçtim

            for (int y = 0; y < girisResmi.Height; y++)
            {
                for (int x = 0; x < girisResmi.Width; x++)
                {
                    Color piksel = girisResmi.GetPixel(x, y);

                    int yeniKirmizi = piksel.R / bolmeDegeri;
                    int yeniYesil = piksel.G / bolmeDegeri;
                    int yeniMavi = piksel.B / bolmeDegeri;

                    cikisResmi.SetPixel(x, y, Color.FromArgb(yeniKirmizi, yeniYesil, yeniMavi));
                }
            }

            return cikisResmi;
        }
    }
}