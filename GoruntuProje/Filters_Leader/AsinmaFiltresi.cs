using GoruntuProje.Core;
using System;
using System.Drawing;

namespace GoruntuProje.Filters_Leader
{
    public class AsinmaFiltresi : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap kaynakGoruntu)
        {
            Bitmap islenmisGoruntu = new Bitmap(kaynakGoruntu.Width, kaynakGoruntu.Height);

            // Kenarları orijinal haliyle kopyala
            for (int y = 0; y < kaynakGoruntu.Height; y++)
            {
                for (int x = 0; x < kaynakGoruntu.Width; x++)
                {
                    islenmisGoruntu.SetPixel(x, y, kaynakGoruntu.GetPixel(x, y));
                }
            }

            // 3x3 matris ile Aşınma (Erosion) işlemi
            for (int y = 1; y < kaynakGoruntu.Height - 1; y++)
            {
                for (int x = 1; x < kaynakGoruntu.Width - 1; x++)
                {
                    // Minimum değerleri bulmak için başlangıç değerlerini 255 yapıyoruz
                    int minR = 255;
                    int minG = 255;
                    int minB = 255;

                    // 3x3 komşuluk piksellerini dolaş
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color pikselRengi = kaynakGoruntu.GetPixel(x + i, y + j);

                            // Komşuluktaki en KÜÇÜK (koyu) renk değerlerini bul (Aşınma mantığı)
                            if (pikselRengi.R < minR) minR = pikselRengi.R;
                            if (pikselRengi.G < minG) minG = pikselRengi.G;
                            if (pikselRengi.B < minB) minB = pikselRengi.B;
                        }
                    }

                    // Bulunan minimum değerleri merkez piksele ata
                    islenmisGoruntu.SetPixel(x, y, Color.FromArgb(minR, minG, minB));
                }
            }

            return islenmisGoruntu;
        }
    }
}