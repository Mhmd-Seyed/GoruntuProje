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
            if (inputImage == null)
                throw new ArgumentNullException(nameof(inputImage));

            int genislik = inputImage.Width;
            int yukseklik = inputImage.Height;

            Bitmap cikisGoruntu = new Bitmap(genislik, yukseklik);

            // 🔹 Contrast değeri (görüntüyü netleştirmek için)
            float contrast = 1.5f;

            // gx Yatay (sağ/sol) farkı ölçmek için Prewitt matrisi
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

            // Tüm pikseller üzerinde dolaşıyoruz (kenarlar hariç)
            // Kenar pikseller kullanılmaz çünkü komşuları eksiktir
            // Sadece ortadaki pikseller (8 komşulu olanlar) işlenir

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

                            //  Contrast uygulama 
                            int r = Clamp((int)((piksel.R - 128) * contrast + 128));
                            int g = Clamp((int)((piksel.G - 128) * contrast + 128));
                            int b = Clamp((int)((piksel.B - 128) * contrast + 128));

                            // RGB değerlerini daha doğru griye çeviriyoruz
                            int gri = (int)(0.3 * r + 0.59 * g + 0.11 * b);

                            // Prewitt matrisi ile çarpıp toplam farkı hesaplıyoruz
                            // Fark küçükse kenar zayıf olur fark büyükse kenar güçlü olur

                            toplamX += gri * gx[i + 1, j + 1];
                            toplamY += gri * gy[i + 1, j + 1];
                        }
                    }

                    //  Edge hesaplama (2 seçenek)

                    // 1️⃣ Orijinal (daha doğru)
                    int kenar = (int)Math.Sqrt(toplamX * toplamX + toplamY * toplamY);

                    // 2️⃣ Alternatif hızlı (istersen bunu açıp üsttekini kapatabilirsin)
                    // int kenar = Math.Abs(toplamX) + Math.Abs(toplamY);

                    kenar = Math.Max(0, Math.Min(255, kenar));

                    // Kenarları belirginleştirmek için threshold uygulanır (0 veya 255 yapılır)
                    if (kenar > 100)
                        kenar = 255;
                    else
                        kenar = 0;

                    // Sonucu gri renk olarak çıkış görüntüsüne yazıyoruz
                    Color yeniRenk = Color.FromArgb(kenar, kenar, kenar);
                    cikisGoruntu.SetPixel(x, y, yeniRenk);
                }
            }

            return cikisGoruntu;
        }

        //  Clamp fonksiyonu (değerleri 0-255 aralığında tutar)
        private int Clamp(int value)
        {
            return Math.Max(0, Math.Min(255, value));
        }
    }
}