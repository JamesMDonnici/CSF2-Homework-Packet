using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //fields
        private string _title;
        private string _author;
        private int _numberOfPages;

        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        
        //ctors
        public Book(string Title, string Author, int NumberOfPages)
        {
            Title = _title;
            Author = _author;
            NumberOfPages = _numberOfPages;
        }

        public Book()
        {

        }

        //methods
        public override string ToString()
        {
            return string.Format("Title: {1}\n" +
                "Author: {2}\n" +
                "Number Of Pages: {3}\n", 
                Title, Author, NumberOfPages);
        }
    }
}
