using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LibroDeFotos
{
    public class PhotoBook
    {
        private int numPages;
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int pages)
        {
            numPages = pages;
        }
        public virtual void GetNumberPages()
        {
            Console.WriteLine(numPages);
        }
    }
}
