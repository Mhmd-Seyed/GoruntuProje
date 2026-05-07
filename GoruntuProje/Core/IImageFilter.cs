using System.Drawing;

namespace GoruntuProje.Core
{
    public interface IImageFilter
    {
        Bitmap ApplyFilter(Bitmap inputImage);
       


    }
    public interface IImageFilter2
    {
        Bitmap ApplyFilter(Bitmap inputImage, Bitmap inputImage2);
    }
   


}