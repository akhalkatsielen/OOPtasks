using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBook;

internal static class PhotoBookTest
{
    internal static void Test()
    {
        PhotoBook defaultPhotoBook = new PhotoBook();
        Console.WriteLine(defaultPhotoBook.GetNumberPages()); //16

        PhotoBook curr24PhotoBook = new PhotoBook(24);
        Console.WriteLine(curr24PhotoBook.GetNumberPages()); //24

        BigPhotoBook bigPhotoBook = new BigPhotoBook();
        Console.WriteLine(bigPhotoBook.GetNumberPages()); //64
    }
}
