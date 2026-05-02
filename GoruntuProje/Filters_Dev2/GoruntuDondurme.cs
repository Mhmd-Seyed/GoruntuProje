using GoruntuProje.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoruntuProje.Filters_Dev2
{
    internal class GoruntuDondurme : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        {
            //  Çıkış resmi oluşturulur
            // 90 derece döndürmede genişlik ve yükseklik yer değiştirir
            Bitmap cikisResmi = new Bitmap(girisResmi.Height, girisResmi.Width);

            //  Giriş resmindeki her piksel gezilir
            for (int y = 0; y < girisResmi.Height; y++)
            {
                for (int x = 0; x < girisResmi.Width; x++)
                {
                    //  Mevcut piksel okunur
                    Color mevcutPiksel = girisResmi.GetPixel(x, y);

                    //  90 derece sağa döndürme formülü
                    // Eski koordinat: (x, y) Yeni koordinat: (yeniX, yeniY)
                    int yeniX = girisResmi.Height - 1 - y;
                    int yeniY = x;

                    //  Piksel yeni yerine yazılır
                    cikisResmi.SetPixel(yeniX, yeniY, mevcutPiksel);
                }
            }

            return cikisResmi;
        }
    }
}
