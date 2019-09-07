using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manning.MyPhotoAlbum;
using System.Drawing;
namespace DemoFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomPhotoFormatter photoFormatter = new CustomPhotoFormatter();
            Photograph photo = new Photograph(@"D:\red.bmp");
            Console.WriteLine(string.Format(photoFormatter, "The pixel at (100,100) is {0:p100,100}", photo));
            Console.ReadKey();
        }
    }
}
