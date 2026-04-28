using GoruntuProje.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoruntuProje.Filters_Dev3
{
    // Mean Filtre (Ortalama Filtre)
    // Amaç: Gürültüyü azaltmak ve görüntüyü yumuşatmak
    public class MeanFilter : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        {
            Bitmap cikisResmi = new Bitmap(girisResmi.Width, girisResmi.Height);

            // 🔹 1. Kenar pikselleri aynen kopyalanır
            // Çünkü 3x3 filtre kenarlarda tam uygulanamaz
            for (int y = 0; y < girisResmi.Height; y++)
            {
                for (int x = 0; x < girisResmi.Width; x++)
                {
                    cikisResmi.SetPixel(x, y, girisResmi.GetPixel(x, y));
                }
            }

            // 🔹 2. 3x3 komşuluk üzerinde ortalama alınır
            for (int y = 1; y < girisResmi.Height - 1; y++)
            {
                for (int x = 1; x < girisResmi.Width - 1; x++)
                {
                    int toplamKirmizi = 0;
                    int toplamYesil = 0;
                    int toplamMavi = 0;

                    // 🔸 Komşu 3x3 piksel gezilir
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color komsuPiksel = girisResmi.GetPixel(x + i, y + j);

                            toplamKirmizi += komsuPiksel.R;
                            toplamYesil += komsuPiksel.G;
                            toplamMavi += komsuPiksel.B;
                        }
                    }

                    // 🔸 Ortalama alınır (9 piksel)
                    int yeniKirmizi = toplamKirmizi / 9;
                    int yeniYesil = toplamYesil / 9;
                    int yeniMavi = toplamMavi / 9;

                    cikisResmi.SetPixel(x, y, Color.FromArgb(yeniKirmizi, yeniYesil, yeniMavi));
                }
            }

            return cikisResmi;
        }
    }
}
