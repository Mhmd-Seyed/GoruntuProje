using GoruntuProje.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoruntuProje.Filters_Dev2
{
    internal class GoruntuUzaklastirma : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        {

            int uzaklastirmaOrani = 2;

            //   Çıkış resmi giriş resmiyle aynı boyutta oluşturulur
            Bitmap cikisResmi = new Bitmap(girisResmi.Width, girisResmi.Height);

            //   Önce çıkış resmi beyaz renkle doldurulur Çünkü küçülen görüntünün etrafında boş alan kalacaktır
            for (int y = 0; y < cikisResmi.Height; y++)
            {
                for (int x = 0; x < cikisResmi.Width; x++)
                {
                    cikisResmi.SetPixel(x, y, Color.White);
                }
            }

            //   Küçültülmüş görüntünün yeni boyutları hesaplanır
            int kucukGenislik = girisResmi.Width / uzaklastirmaOrani;
            int kucukYukseklik = girisResmi.Height / uzaklastirmaOrani;

            //   Küçük görüntünün ortaya yerleşmesi için başlangıç noktaları hesaplanır
            int baslangicX = (girisResmi.Width - kucukGenislik) / 2;
            int baslangicY = (girisResmi.Height - kucukYukseklik) / 2;

            //   Küçük görüntünün her pikseli hesaplanır
            for (int y = 0; y < kucukYukseklik; y++)
            {
                for (int x = 0; x < kucukGenislik; x++)
                {
                    //  Çıkıştaki küçük pikselin giriş resminde karşılık geldiği nokta bulunur
                    int kaynakX = x * uzaklastirmaOrani;
                    int kaynakY = y * uzaklastirmaOrani;

                    //  Giriş resminden piksel okunur
                    Color mevcutPiksel = girisResmi.GetPixel(kaynakX, kaynakY);

                    //  Okunan piksel çıkış resminde ortadaki konuma yazılır
                    int hedefX = baslangicX + x;
                    int hedefY = baslangicY + y;

                    cikisResmi.SetPixel(hedefX, hedefY, mevcutPiksel);
                }
            }

            return cikisResmi;
        }
    }
}
