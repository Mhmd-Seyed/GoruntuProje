using GoruntuProje.Core;
using System;
using System.Drawing;

namespace GoruntuProje.Filters_Leader
{
    public class KirpmaFiltresi : IImageFilter
    {
        // Kullanıcının fare ile seçtiği alan (Dikdörtgen)
        public Rectangle SeciliAlan { get; set; }

        public Bitmap ApplyFilter(Bitmap kaynakGoruntu)
        {
            // Eğer alan seçilmediyse orijinal görüntüyü döndür
            if (SeciliAlan.Width == 0 || SeciliAlan.Height == 0)
                return kaynakGoruntu;

            // Görüntü sınırlarını aşmamak için güvenli koordinatlar hesapla
            int x = Math.Max(0, SeciliAlan.X);
            int y = Math.Max(0, SeciliAlan.Y);
            int genislik = Math.Min(kaynakGoruntu.Width - x, SeciliAlan.Width);
            int yukseklik = Math.Min(kaynakGoruntu.Height - y, SeciliAlan.Height);

            Rectangle guvenliAlan = new Rectangle(x, y, genislik, yukseklik);

            // C#'ın yerleşik Clone metodu ile seçili alanı pikselleriyle birlikte kesip alıyoruz
            Bitmap kirpilmisGoruntu = kaynakGoruntu.Clone(guvenliAlan, kaynakGoruntu.PixelFormat);

            return kirpilmisGoruntu;
        }
    }
}