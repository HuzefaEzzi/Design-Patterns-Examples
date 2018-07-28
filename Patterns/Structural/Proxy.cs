using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural
{
    /// <summary>
    /// The Proxy Pattern provides a surrogate or placeholder for another object to control access to it.
    /// we have three types of proxies
    /// 1. Remote
    /// 2. Virtual
    /// 3. Protection
    /// 
    /// here we are using example of virtual proxy
    /// </summary>
    /// 

     

    interface IBookParser
    {
        int GetNumberOfPages();
    }

    //this is resourse intensive book and goal is to avoid instantialing this unless we relly have to
    class BookParser : IBookParser
    {
        public BookParser(string book)
        {
            //Assume this constructor is doing some resourse intevsive operation
        }

        public int GetNumberOfPages()
        {
            return 100; // again assume this is based to the parsed book
        }
    }

    class LazyBookParser : IBookParser
    {
        private string book;
        BookParser parser;

        public LazyBookParser(string book)
        {
            this.book = book;
        }

        public int GetNumberOfPages()
        {
            if (parser ==null)
            {
                parser = new BookParser(book);
            }
            return parser.GetNumberOfPages();
        }
    }
}
