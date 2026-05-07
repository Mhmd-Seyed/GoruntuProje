using GoruntuProje.Core;
using System;
using System.Drawing;

namespace GoruntuProje.Filters_Dev4
{
    // Aritmetik Ekleme İşlemi
    // Amaç: İki görüntünün aynı konumdaki piksellerini toplayarak yeni bir görüntü oluşturmak.
    public class EklemeIslemi : IImageFilter2
    {
        public Bitmap ApplyFilter(Bitmap birinciResim, Bitmap ikinciResim)
        {
            int genislik = Math.Min(birinciResim.Width, ikinciResim.Width);
            int yukseklik = Math.Min(birinciResim.Height, ikinciResim.Height);

            Bitmap cikisResmi = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    Color piksel1 = birinciResim.GetPixel(x, y);
                    Color piksel2 = ikinciResim.GetPixel(x, y);

                    int yeniKirmizi = piksel1.R + piksel2.R;
                    int yeniYesil = piksel1.G + piksel2.G;
                    int yeniMavi = piksel1.B + piksel2.B;

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