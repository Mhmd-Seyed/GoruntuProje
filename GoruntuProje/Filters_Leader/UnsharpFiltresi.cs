using System;
using System.Drawing;
using GoruntuProje.Core;

namespace GoruntuProje.Filters.Leader
{
    public class UnsharpFiltresi : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap kaynakGoruntu)
        {
            // 1. Görüntünün boyutlarını al
            int genislik = kaynakGoruntu.Width;
            int yukseklik = kaynakGoruntu.Height;

            // 2. Sonucu kaydedeceğimiz yeni boş görüntüyü oluştur
            Bitmap islenmisGoruntu = new Bitmap(genislik, yukseklik);

            // 3. Keskinleştirme (Unsharp / Sharpen) için 3x3 Matris (Kernel)
            int[,] filtreMatrisi = {
                {  0, -1,  0 },
                { -1,  5, -1 },
                {  0, -1,  0 }
            };

            // 4. Görüntünün piksellerini dolaş (Kenarları atlıyoruz ki IndexOutOfRange hatası almayalım)
            for (int x = 1; x < genislik - 1; x++)
            {
                for (int y = 1; y < yukseklik - 1; y++)
                {
                    int toplamR = 0;
                    int toplamG = 0;
                    int toplamB = 0;

                    // 5. 3x3 maskeyi (matrisi) merkez piksel ve komşularına uygula
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            // Komşu pikselin rengini al
                            Color komsuPiksel = kaynakGoruntu.GetPixel(x + i, y + j);

                            // Matristeki karşılık gelen ağırlık değeri
                            int matrisDegeri = filtreMatrisi[i + 1, j + 1];

                            // Renk değerlerini matris ağırlığı ile çarp ve toplama ekle
                            toplamR += komsuPiksel.R * matrisDegeri;
                            toplamG += komsuPiksel.G * matrisDegeri;
                            toplamB += komsuPiksel.B * matrisDegeri;
                        }
                    }

                    // 6. Değerlerin 0 ile 255 sınırları dışına çıkmasını engelle (Clamping işlemi)
                    toplamR = Math.Max(0, Math.Min(255, toplamR));
                    toplamG = Math.Max(0, Math.Min(255, toplamG));
                    toplamB = Math.Max(0, Math.Min(255, toplamB));

                    // 7. Hesaplanan yeni rengi işlenmiş görüntüye ata
                    islenmisGoruntu.SetPixel(x, y, Color.FromArgb(toplamR, toplamG, toplamB));
                }
            }

            return islenmisGoruntu;
        }
    }
}