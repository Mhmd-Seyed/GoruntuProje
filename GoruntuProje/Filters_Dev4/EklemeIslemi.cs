using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using GoruntuProje.Core;
using System.Drawing;

namespace GoruntuProje.Filters_Dev4
{
    // Aritmetik Ekleme İşlemi
    // Amaç: Görüntüdeki her pikselin RGB değerlerine sabit bir değer ekleyerek görüntüyü parlaklaştırmak
    public class EklemeIslemi : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        {
            Bitmap cikisResmi = new Bitmap(girisResmi.Width, girisResmi.Height);

            // Eklenecek sabit değer
            // Bu değer arttıkça görüntü daha parlak olur
            int eklenecekDeger = 80;//büyük değer seçtim ki görüntünün parlaklığı artsın.

            for (int y = 0; y < girisResmi.Height; y++)
            {
                for (int x = 0; x < girisResmi.Width; x++)
                {
                    Color piksel = girisResmi.GetPixel(x, y);

                    int yeniKirmizi = piksel.R + eklenecekDeger;
                    int yeniYesil = piksel.G + eklenecekDeger;
                    int yeniMavi = piksel.B + eklenecekDeger;

                    // RGB değerleri 255'i geçemez
                    if (yeniKirmizi > 255)
                        yeniKirmizi = 255;

                    if (yeniYesil > 255)
                        yeniYesil = 255;

                    if (yeniMavi > 255)
                        yeniMavi = 255;

                    cikisResmi.SetPixel(x, y, Color.FromArgb(yeniKirmizi, yeniYesil, yeniMavi));
                }
            }

            return cikisResmi;
        }
    }
}