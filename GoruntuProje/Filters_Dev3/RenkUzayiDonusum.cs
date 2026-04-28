using GoruntuProje.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoruntuProje.Filters_Dev3
{
    // RGB görüntüyü gri tonlamaya çevirir
    public class RenkUzayiDonusum : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        {
            Bitmap cikisResmi = new Bitmap(girisResmi.Width, girisResmi.Height);

            for (int y = 0; y < girisResmi.Height; y++)
            {
                for (int x = 0; x < girisResmi.Width; x++)
                {
                    Color piksel = girisResmi.GetPixel(x, y);

                    // RGB -> Gray dönüşümü
                    // İnsan gözü yeşile daha duyarlı olduğu için G katsayısı daha büyüktür.
                    int griDeger = (int)(0.299 * piksel.R + 0.587 * piksel.G + 0.114 * piksel.B);

                    griDeger = Clamp(griDeger);

                    cikisResmi.SetPixel(x, y, Color.FromArgb(griDeger, griDeger, griDeger));
                }
            }

            return cikisResmi;
        }

        private int Clamp(int deger)
        {
            if (deger < 0) return 0;
            if (deger > 255) return 255;
            return deger;
        }
    }

    // RGB görüntüyü HSV renk uzayına dönüştürür
    public class RenkUzayiDonusumHSV : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        {
            Bitmap cikisResmi = new Bitmap(girisResmi.Width, girisResmi.Height);

            for (int y = 0; y < girisResmi.Height; y++)
            {
                for (int x = 0; x < girisResmi.Width; x++)
                {
                    Color piksel = girisResmi.GetPixel(x, y);

                    // RGB değerleri 0-255 aralığındadır.
                    // HSV hesaplaması için önce 0-1 aralığına normalize edilir.
                    double kirmizi = piksel.R / 255.0;
                    double yesil = piksel.G / 255.0;
                    double mavi = piksel.B / 255.0;

                    double maksimum = Math.Max(kirmizi, Math.Max(yesil, mavi));
                    double minimum = Math.Min(kirmizi, Math.Min(yesil, mavi));
                    double fark = maksimum - minimum;

                    // H: Hue / renk tonu
                    double renkTonu = 0;

                    if (fark == 0)
                    {
                        renkTonu = 0;
                    }
                    else if (maksimum == kirmizi)
                    {
                        renkTonu = 60 * (((yesil - mavi) / fark) % 6);
                    }
                    else if (maksimum == yesil)
                    {
                        renkTonu = 60 * (((mavi - kirmizi) / fark) + 2);
                    }
                    else
                    {
                        renkTonu = 60 * (((kirmizi - yesil) / fark) + 4);
                    }

                    if (renkTonu < 0)
                    {
                        renkTonu += 360;
                    }

                    // S: Saturation / doygunluk
                    double doygunluk = (maksimum == 0) ? 0 : fark / maksimum;

                    // V: Value / parlaklık
                    double parlaklik = maksimum;

                    // HSV değerlerini görüntü olarak gösterebilmek için 0-255 aralığına çeviriyoruz.
                    int H = Clamp((int)(renkTonu / 360.0 * 255));
                    int S = Clamp((int)(doygunluk * 255));
                    int V = Clamp((int)(parlaklik * 255));

                    // HSV kanallarını çıktı görüntüsünde RGB kanalları gibi gösteriyoruz.
                    cikisResmi.SetPixel(x, y, Color.FromArgb(H, S, V));
                }
            }

            return cikisResmi;
        }

        private int Clamp(int deger)
        {
            if (deger < 0) return 0;
            if (deger > 255) return 255;
            return deger;
        }
    }
}