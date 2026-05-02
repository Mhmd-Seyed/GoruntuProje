using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoruntuProje.Filters_Dev2
{
    internal class GoruntuYaklastirma
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        { //  Yaklaştırma oranı belirlenir
            int yaklastirmaOrani = 2;

            //  Çıkış resmi giriş resmiyle aynı boyutta oluşturulur
            Bitmap cikisResmi = new Bitmap(girisResmi.Width, girisResmi.Height);

            //  Merkezden alınacak alanın boyutu hesaplanır
            int kirpilanGenislik = girisResmi.Width / yaklastirmaOrani;
            int kirpilanYukseklik = girisResmi.Height / yaklastirmaOrani;

            //  Merkez bölgenin başlangıç koordinatları bulunur
            int baslangicX = (girisResmi.Width - kirpilanGenislik) / 2;
            int baslangicY = (girisResmi.Height - kirpilanYukseklik) / 2;

            //  Çıkış resmindeki her piksel tek tek gezilir
            for (int y = 0; y < cikisResmi.Height; y++)
            {
                for (int x = 0; x < cikisResmi.Width; x++)
                {
                    //  Çıkış pikselinin giriş resmindeki karşılığı hesaplanır
                    int kaynakX = baslangicX + (x / yaklastirmaOrani);
                    int kaynakY = baslangicY + (y / yaklastirmaOrani);

                    //  Güvenlik kontrolü yapılır
                    if (kaynakX >= 0 && kaynakX < girisResmi.Width &&
                        kaynakY >= 0 && kaynakY < girisResmi.Height)
                    {
                        //  Kaynak piksel okunur
                        Color mevcutPiksel = girisResmi.GetPixel(kaynakX, kaynakY);

                        //  Piksel çıkış resmine yazılır
                        cikisResmi.SetPixel(x, y, mevcutPiksel);
                    }
                }
            }
            return cikisResmi;
        }
    }
}
