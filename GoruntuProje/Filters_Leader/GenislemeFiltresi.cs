using GoruntuProje.Core;
using System;
using System.Drawing;

namespace GoruntuProje.Filters_Leader
{
    public class GenislemeFiltresi : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap kaynakGoruntu)
        {
            Bitmap islenmisGoruntu = new Bitmap(kaynakGoruntu.Width, kaynakGoruntu.Height);

            // Kenarları orijinal haliyle kopyala (Index sınırlarını aşmamak için)
            for (int y = 0; y < kaynakGoruntu.Height; y++)
            {
                for (int x = 0; x < kaynakGoruntu.Width; x++)
                {
                    islenmisGoruntu.SetPixel(x, y, kaynakGoruntu.GetPixel(x, y));
                }
            }

            // 3x3 matris ile Genişleme (Dilation) işlemi
            for (int y = 1; y < kaynakGoruntu.Height - 1; y++)
            {
                for (int x = 1; x < kaynakGoruntu.Width - 1; x++)
                {
                    // Maksimum değerleri bulmak için başlangıç değerlerini 0 yapıyoruz
                    int maxR = 0;
                    int maxG = 0;
                    int maxB = 0;

                    // 3x3 komşuluk piksellerini dolaş
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color pikselRengi = kaynakGoruntu.GetPixel(x + i, y + j);

                            // Komşuluktaki en BÜYÜK (açık) renk değerlerini bul (Genişleme mantığı)
                            if (pikselRengi.R > maxR) maxR = pikselRengi.R;
                            if (pikselRengi.G > maxG) maxG = pikselRengi.G;
                            if (pikselRengi.B > maxB) maxB = pikselRengi.B;
                        }
                    }

                    // Bulunan maksimum değerleri merkez piksele ata
                    islenmisGoruntu.SetPixel(x, y, Color.FromArgb(maxR, maxG, maxB));
                }
            }

            return islenmisGoruntu;
        }
    }
}