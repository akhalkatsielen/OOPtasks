using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBook;

//public class BigPhotoBook
//{
//    public PhotoBook PhotoBook { get; set; }
//    public BigPhotoBook()
//    {
//        PhotoBook = new PhotoBook(64);
//    }
//}
public class BigPhotoBook : PhotoBook
{
    public BigPhotoBook() : base(64)
    {
        //_numPages = 64; //protected
    }
}
