using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LibroDeFotos
{
    public class BigPhotoBook : PhotoBook
    {
        private int numPages;
        public BigPhotoBook()
        {
            numPages = 64;
        }
        public override void GetNumberPages()
        {
            Console.WriteLine(numPages);
        }
    }
}
