using GoruntuProje.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoruntuProje.Filters_Dev3
{
    // Histogram Germe (Kontrast Genişletme)
    // Amaç: Görüntüdeki piksel değerlerini 0-255 aralığına yayarak kontrastı artırmak
    public class HistogramGerme : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        {
            Bitmap cikisResmi = new Bitmap(girisResmi.Width, girisResmi.Height);

            // 🔹 Minimum ve maksimum değerleri bulmak için başlangıç değerleri
            int minKirmizi = 255, minYesil = 255, minMavi = 255;
            int maxKirmizi = 0, maxYesil = 0, maxMavi = 0;

            // 🔹 1. Aşama: Tüm görüntü taranır ve min-max değerler bulunur
            for (int y = 0; y < girisResmi.Height; y++)
            {
                for (int x = 0; x < girisResmi.Width; x++)
                {
                    Color piksel = girisResmi.GetPixel(x, y);

                    if (piksel.R < minKirmizi) minKirmizi = piksel.R;
                    if (piksel.G < minYesil) minYesil = piksel.G;
                    if (piksel.B < minMavi) minMavi = piksel.B;

                    if (piksel.R > maxKirmizi) maxKirmizi = piksel.R;
                    if (piksel.G > maxYesil) maxYesil = piksel.G;
                    if (piksel.B > maxMavi) maxMavi = piksel.B;
                }
            }

            // 🔹 2. Aşama: Her piksel yeni aralığa taşınır (0-255)
            for (int y = 0; y < girisResmi.Height; y++)
            {
                for (int x = 0; x < girisResmi.Width; x++)
                {
                    Color piksel = girisResmi.GetPixel(x, y);

                    int yeniKirmizi = Germe(piksel.R, minKirmizi, maxKirmizi);
                    int yeniYesil = Germe(piksel.G, minYesil, maxYesil);
                    int yeniMavi = Germe(piksel.B, minMavi, maxMavi);

                    cikisResmi.SetPixel(x, y, Color.FromArgb(yeniKirmizi, yeniYesil, yeniMavi));
                }
            }

            return cikisResmi;
        }

        // 🔹 Histogram germe formülü uygulanır
        // g(x) = (L-1 / (max - min)) * (f(x) - min)
        private int Germe(int pikselDegeri, int minDeger, int maxDeger)
        {
            // Eğer tüm görüntü aynı değerdeyse (kontrast yoksa)
            if (maxDeger == minDeger)
                return pikselDegeri;

            // 🔸 Yeni değer hesaplanır
            //yeni = (eski - min) * 255 / (max - min)
            int yeniDeger = (pikselDegeri - minDeger) * 255 / (maxDeger - minDeger);

            // 🔸 Taşma kontrolü (0-255 aralığında tut)
            if (yeniDeger < 0) return 0;
            if (yeniDeger > 255) return 255;

            return yeniDeger;
        }


        public int[] HistogramHesapla(Bitmap resim)
        {
            int[] histogram = new int[256];

            for (int y = 0; y < resim.Height; y++)
            {
                for (int x = 0; x < resim.Width; x++)
                {
                    Color piksel = resim.GetPixel(x, y);

                    int gri = (piksel.R + piksel.G + piksel.B) / 3;

                    histogram[gri]++;
                }
            }

            return histogram;
        }
    }
}
    