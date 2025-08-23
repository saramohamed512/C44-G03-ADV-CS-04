using System;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("20190234", "Effective C#", new string[] { "Bill Wagner" }, new DateTime(2018, 1, 1)) { Price = 60.00m },
                new Book("20190084", "C# in Depth", new string[] { "Jon Skeet" }, new DateTime(2019, 4, 1)) { Price = 45.20m },
                new Book("20190163", "Clean Code", new string[] { "Robert C. Martin" }, new DateTime(2008, 8, 1)) { Price = 50.66m }
            };
            #region User Defined Delegate Datatype
            BookFunctionDelegate titleDelegate = BookFunctions.GetTitle;
            Console.WriteLine("=============== Book Titles ===============");
            LibraryEngine.ProcessBooks(books, titleDelegate);
            #endregion
        }
    }
}