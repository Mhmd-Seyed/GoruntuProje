using GoruntuProje.Core;
using System.Drawing;

namespace GoruntuProje.Filters_Leader
{
    public class KapamaFiltresi : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap kaynakGoruntu)
        {
            // Kapama (Closing) İşlemi = Önce Genişleme (Dilation), sonra Aşınma (Erosion)

            // 1. Önce Genişleme filtresini uygula (Delikleri kapatmak için)
            GenislemeFiltresi genisleme = new GenislemeFiltresi();
            Bitmap genislemisGoruntu = genisleme.ApplyFilter(kaynakGoruntu);

            // 2. Elde edilen genişlemiş görüntü üzerine Aşınma filtresini uygula (Orijinal boyuta dönmek için)
            AsinmaFiltresi asinma = new AsinmaFiltresi();
            Bitmap kapanmisGoruntu = asinma.ApplyFilter(genislemisGoruntu);

            return kapanmisGoruntu;
        }
    }
}