using GoruntuProje.Core;
using System.Drawing;

namespace GoruntuProje.Filters_Leader
{
    public class AcmaFiltresi : IImageFilter
    {
        public Bitmap ApplyFilter(Bitmap kaynakGoruntu)
        {
            // Açma (Opening) İşlemi = Önce Aşınma (Erosion), sonra Genişleme (Dilation)

            // 1. Önce Aşınma filtresini uygula (Gürültüleri yok etmek için)
            AsinmaFiltresi asinma = new AsinmaFiltresi();
            Bitmap asinmisGoruntu = asinma.ApplyFilter(kaynakGoruntu);

            // 2. Elde edilen aşınmış görüntü üzerine Genişleme filtresini uygula (Orijinal boyuta dönmek için)
            GenislemeFiltresi genisleme = new GenislemeFiltresi();
            Bitmap acilmisGoruntu = genisleme.ApplyFilter(asinmisGoruntu);

            return acilmisGoruntu;
        }
    }
}