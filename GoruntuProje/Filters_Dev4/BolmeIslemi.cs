using GoruntuProje.Core;
using System;
using System.Drawing;

namespace GoruntuProje.Filters_Dev4
{
    // Aritmetik Bölme İşlemi
    // Amaç: İki görüntünün aynı konumdaki piksellerini birbirine bölerek yeni bir görüntü oluşturmak.
    public class BolmeIslemi : IImageFilter2
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

                    int yeniKirmizi;
                    int yeniYesil;
                    int yeniMavi;

                    // 0'a bölme hatasını önlemek için kontrol
                    if (piksel2.R == 0)
                        yeniKirmizi = 0;
                    else
                        yeniKirmizi = piksel1.R / piksel2.R;

                    if (piksel2.G == 0)
                        yeniYesil = 0;
                    else
                        yeniYesil = piksel1.G / piksel2.G;

                    if (piksel2.B == 0)
                        yeniMavi = 0;
                    else
                        yeniMavi = piksel1.B / piksel2.B;

                    cikisResmi.SetPixel(x, y, Color.FromArgb(yeniKirmizi, yeniYesil, yeniMavi));
                }
            }

            return cikisResmi;
        }
    }
}