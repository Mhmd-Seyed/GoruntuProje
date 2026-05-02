using GoruntuProje.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoruntuProje.Filters_Dev2
{
    internal class GurultuEkleme:IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        {
            //  Çıkış resmi giriş resmiyle aynı boyutta oluşturulur
            Bitmap cikisResmi = new Bitmap(girisResmi.Width, girisResmi.Height);

            //  Rastgele sayı üretici oluşturulur
            Random rastgele = new Random();

            //  Gürültü oranı belirlenir
            double gurultuOrani = 0.05; // 0.05 değeri yaklaşık %5 pikselin gürültüye dönüşmesi demektir

            //  Her piksel tek tek gezilir
            for (int y = 0; y < girisResmi.Height; y++)
            {
                for (int x = 0; x < girisResmi.Width; x++)
                {
                    //  0 ile 1 arasında rastgele sayı üretilir
                    double rastgeleDeger = rastgele.NextDouble();

                    //  Mevcut piksel okunur
                    Color mevcutPiksel = girisResmi.GetPixel(x, y);

                    //  Rastgele değer gürültü oranının yarısından küçükse piksel siyah yapılır
                    if (rastgeleDeger < gurultuOrani / 2)
                    {
                        cikisResmi.SetPixel(x, y, Color.Black);
                    }
                    //  Rastgele değer gürültü oranı içindeyse piksel beyaz yapılır
                    else if (rastgeleDeger < gurultuOrani)
                    {
                        cikisResmi.SetPixel(x, y, Color.White);
                    }
                    //  Diğer pikseller aynen korunur
                    else
                    {
                        cikisResmi.SetPixel(x, y, mevcutPiksel);
                    }
                }
            }

            return cikisResmi;
        }
    }
}
