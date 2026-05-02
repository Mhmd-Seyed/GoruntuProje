using GoruntuProje.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoruntuProje.Filters_Dev2
{
    internal class MedianFiltre:IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap girisResmi)
        {
            // Çıkış resmi giriş resmiyle aynı boyutta oluşturulur
            Bitmap cikisResmi = new Bitmap(girisResmi.Width, girisResmi.Height);

            //  Kenar pikselleri aynen kopyalanır
            // Çünkü 3x3 komşuluk kenarlarda tam uygulanamaz
            for (int y = 0; y < girisResmi.Height; y++)
            {
                for (int x = 0; x < girisResmi.Width; x++)
                {
                    cikisResmi.SetPixel(x, y, girisResmi.GetPixel(x, y));
                }
            }

            //  Kenarlar hariç tüm pikseller gezilir
            for (int y = 1; y < girisResmi.Height - 1; y++)
            {
                for (int x = 1; x < girisResmi.Width - 1; x++)
                {
                    //  3x3 komşuluktaki renk değerleri için diziler oluşturulur
                    int[] kirmiziDegerler = new int[9];
                    int[] yesilDegerler = new int[9];
                    int[] maviDegerler = new int[9];

                    int sayac = 0;

                    //  3x3 komşuluk pikselleri gezilir
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color komsuPiksel = girisResmi.GetPixel(x + i, y + j);

                            kirmiziDegerler[sayac] = komsuPiksel.R;
                            yesilDegerler[sayac] = komsuPiksel.G;
                            maviDegerler[sayac] = komsuPiksel.B;

                            sayac++;
                        }
                    }

                    //  Renk değerleri küçükten büyüğe sıralanır
                    Array.Sort(kirmiziDegerler);
                    Array.Sort(yesilDegerler);
                    Array.Sort(maviDegerler);

                    //  9 elemanlı dizide ortanca değer 4. indistedir
                    int yeniKirmizi = kirmiziDegerler[4];
                    int yeniYesil = yesilDegerler[4];
                    int yeniMavi = maviDegerler[4];

                    //  Ortanca değerlerden yeni piksel oluşturulur
                    Color yeniPiksel = Color.FromArgb(yeniKirmizi, yeniYesil, yeniMavi);

                    //  Yeni piksel çıkış resmine yazılır
                    cikisResmi.SetPixel(x, y, yeniPiksel);
                }
            }

            return cikisResmi;
        }
    }
}
