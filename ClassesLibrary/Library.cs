using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //fields
        //private List<Book> _books;
        //private string _libraryName;
        //private string _streetAddress;
        //private string _city;
        //private string _state;
        //private string _zip;

        //properties
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        //ctor
        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        public Library()
        {

        }

        //methods
        public override string ToString()
        {
            return string.Format("Books: {0}\n" +
                "Library Name: {1}\n" +
                "Street Address: {2}\n" +
                "City: {3}\n" +
                "State: {4}\n" +
                "Zip: {5}", Books, LibraryName, StreetAddress, City, State, Zip);
        }



    }
}
