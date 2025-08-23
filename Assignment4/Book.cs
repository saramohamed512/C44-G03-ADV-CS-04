using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public delegate string BookFunctionDelegate(Book book);
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string ISBN, string Title, string[] Author, DateTime PublicationDate)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.PublicationDate = PublicationDate;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {string.Join(", ", Author)}, " +
                   $"Publication Date: {PublicationDate:yyyy-MM-dd}, Price: {Price:C}";
        }
    }
}
