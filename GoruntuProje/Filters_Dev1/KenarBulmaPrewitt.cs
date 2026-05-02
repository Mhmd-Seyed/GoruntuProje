using GoruntuProje.Core;
using System;
using System.Drawing;

namespace GoruntuProje.Filters_Dev1
{
    // Prewitt yöntemi ile görüntüdeki kenarları buluyoruz
    // Prewitt Kenar Bulma: Komşu piksellerin farkını ölçerek kenarları bulur

    internal class KenarBulmaPrewitt : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap inputImage)
        {
            int genislik = inputImage.Width;
            int yukseklik = inputImage.Height;

            Bitmap cikis = new Bitmap(genislik, yukseklik);

            //  gx Yatay (sağ/sol) farkı ölçmek için Prewitt matrisi

            int[,] gx = {
                { -1, 0, 1 },
                { -1, 0, 1 },
                { -1, 0, 1 }
            };

            // gy Dikey (yukarı/aşağı) farkı ölçmek için Prewitt matrisi

            int[,] gy = {
                { -1, -1, -1 },
                {  0,  0,  0 },
                {  1,  1,  1 }
            };

            // Tüm pikseller üzerinde dolaşıyoruz (kenarlar hariç) Kenar pikseller kullanılmaz çünkü komşuları eksiktir
            //Sadece ortadaki pikseller (8 komşulu olanlar) işlenir

            for (int x = 1; x < genislik - 1; x++) 
            {
                for (int y = 1; y < yukseklik - 1; y++)
                {
                    int toplamX = 0;
                    int toplamY = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color piksel = inputImage.GetPixel(x + i, y + j);

                            int gri = (piksel.R + piksel.G + piksel.B) / 3;

                            // Prewitt matrisi ile çarpıp toplam farkı hesaplıyoruz
                            //Fark küçükse kenar zayıf olur fark büyükse kenar güçlü olur

                            toplamX += gri * gx[i + 1, j + 1];
                            toplamY += gri * gy[i + 1, j + 1];
                        }
                    }

                    int deger = Math.Abs(toplamX) + Math.Abs(toplamY); // X ve Y yönündeki farkları birleştiriyoruz

                    deger = Math.Max(0, Math.Min(255, deger));

                    cikis.SetPixel(x, y, Color.FromArgb(deger, deger, deger)); // Sonucu gri renk olarak çıkış görüntüsüne yazıyoruz
                }
            }

            return cikis;
        }
    }
}