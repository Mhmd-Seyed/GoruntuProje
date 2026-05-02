using System.Drawing;
using GoruntuProje.Core;

namespace GoruntuProje.Filters_Dev1
{
    public class GriDonusum : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap inputImage)
        {
            int genislik = inputImage.Width;
            int yukseklik = inputImage.Height;

            Bitmap cikisGoruntu = new Bitmap(genislik, yukseklik);

            for (int x = 0; x < genislik; x++)
            {
                for (int y = 0; y < yukseklik; y++)
                {
                    Color piksel = inputImage.GetPixel(x, y); // Giriş görüntüdeki pikselin konumunu belirledik 

                    int gri = (piksel.R + piksel.G + piksel.B) / 3;  //RGB değerlerinin ortalamasını alarak gri ton elde ettim

                    cikisGoruntu.SetPixel(x, y, Color.FromArgb(gri, gri, gri));  // Pikseli gri renge çevirip yeni görüntüye yerleştiriyoruz
                }
            }

            return cikisGoruntu;
        }
    }
}