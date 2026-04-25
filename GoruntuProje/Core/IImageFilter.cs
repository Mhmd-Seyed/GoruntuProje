using System.Drawing;

namespace GoruntuProje.Core
{
    public interface IImageFilter
    {
        Bitmap ApplyFilter(Bitmap inputImage);
    }
}