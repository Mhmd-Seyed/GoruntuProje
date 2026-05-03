using GoruntuProje.Core;
using System.Drawing;

namespace GoruntuProje.Filters_Leader
{
    public class KirpmaFiltresi : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap kaynakGoruntu)
        {
            // Görüntünün ortasından daha dar bir alanı (%33) kırpan yaklaşım

            // 1. Kırpılacak çerçevenin başlangıç koordinatlarını ve yeni boyutları hesapla
            int baslangicX = kaynakGoruntu.Width / 3;    // Soldan %33 boşluk bırak
            int baslangicY = kaynakGoruntu.Height / 3;   // Yukarıdan %33 boşluk bırak
            int yeniGenislik = kaynakGoruntu.Width / 3;  // Orijinal genişliğin 3'te 1'ini al
            int yeniYukseklik = kaynakGoruntu.Height / 3;// Orijinal yüksekliğin 3'te 1'ini al

            // 2. Hesaplanmış yeni boyutlarda boş bir görüntü (Bitmap) oluştur
            Bitmap kirpilmisGoruntu = new Bitmap(yeniGenislik, yeniYukseklik);

            // 3. Pikselleri yeni görüntüye taşı (Geometrik öteleme / Kaydırma)
            for (int y = 0; y < yeniYukseklik; y++)
            {
                for (int x = 0; x < yeniGenislik; x++)
                {
                    // Orijinal görüntüden ötekilenmiş (offset) pikseli al
                    Color piksel = kaynakGoruntu.GetPixel(x + baslangicX, y + baslangicY);

                    // Yeni görüntünün (0,0) noktasından başlayarak yerleştir
                    kirpilmisGoruntu.SetPixel(x, y, piksel);
                }
            }

            return kirpilmisGoruntu;
        }
    }
}