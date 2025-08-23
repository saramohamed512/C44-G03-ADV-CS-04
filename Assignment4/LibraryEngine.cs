using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bookList, BookFunctionDelegate fPtr)
        {
            foreach (Book B in bookList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }

}
