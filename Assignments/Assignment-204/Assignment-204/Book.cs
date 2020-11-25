using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_204
{
    class Book
    {
        public string BookTitle { get; private set; }
        public string BookISBN { get; private set; }
        public string BookPublisher { get; private set; }

        public Book(string title, string isbn, string publisher)
        {
            BookTitle = title;
            BookISBN = isbn;
            BookPublisher = publisher;
        }
    }
}
