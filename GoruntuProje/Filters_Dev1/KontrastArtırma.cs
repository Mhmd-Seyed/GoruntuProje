using GoruntuProje.Core;
using System;
using System.Drawing;

namespace GoruntuProje.Filters_Dev1
{
    // Kontrast Artırma
    public class KontrastArtirma : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap inputImage)
        {
            int genislik = inputImage.Width;
            int yukseklik = inputImage.Height;

            Bitmap cikis = new Bitmap(genislik, yukseklik);

            //Kontrast artırma, piksel değerleri arasındaki farkı büyütmektir

            double faktor = 1.5; // kontrast gücü (1 = değişmez) ancak 1 den büyük olunca kontrast artırılır 

            for (int x = 0; x < genislik; x++)
            {
                for (int y = 0; y < yukseklik; y++)
                {
                    Color piksel = inputImage.GetPixel(x, y);

                    /* Pikselin kontrastını artırmak için RGB değerlerini merkeze göre genişletiyoruz
                       128 değeri orta nokta olduğu için (0-255), kontrast artırmada referans olarak kullanılır
                       128’e göre uzaklaştırarak kontrastı artırıyoruz
                       128 sabit noktadır, kontrast işleminde değişmez  */

                    int r = (int)((piksel.R - 128) * faktor + 128);
                    int g = (int)((piksel.G - 128) * faktor + 128);
                    int b = (int)((piksel.B - 128) * faktor + 128);

                    // sınır kontrolü (0-255)
                    r = Math.Max(0, Math.Min(255, r));
                    g = Math.Max(0, Math.Min(255, g));
                    b = Math.Max(0, Math.Min(255, b));

                    cikis.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return cikis;
        }
    }
}