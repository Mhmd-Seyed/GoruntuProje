using System;
using System.Drawing;
using GoruntuProje.Core;

namespace GoruntuProje.Filters_Dev1
{
    public class GriDonusum : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap inputImage)
        {
            
            if (inputImage == null)
                throw new ArgumentNullException(nameof(inputImage));

            int genislik = inputImage.Width;
            int yukseklik = inputImage.Height;

            Bitmap cikisGoruntu = new Bitmap(genislik, yukseklik);

            for (int x = 0; x < genislik; x++)
            {
                for (int y = 0; y < yukseklik; y++)
                {
                    // Giriş görüntüdeki pikselin konumunu belirledik
                    Color piksel = inputImage.GetPixel(x, y);

                    // RGB değerlerini ağırlıklı ortalama ile gri tona çevirdik (daha doğru yöntem)
                    int gri = (int)(0.3 * piksel.R + 0.59 * piksel.G + 0.11 * piksel.B);

                    // Pikseli gri renge çevirip yeni görüntüye yerleştiriyoruz
                    cikisGoruntu.SetPixel(x, y, Color.FromArgb(gri, gri, gri));
                }
            }

            return cikisGoruntu;
        }
    }
}