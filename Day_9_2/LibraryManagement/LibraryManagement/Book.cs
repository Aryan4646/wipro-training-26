using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }
        public bool IsBorrowed { get; private set; } 

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false;
        }

        public void Borrow()
        {
            if (IsBorrowed)
                throw new InvalidOperationException("Book is not available");

            IsBorrowed = true;
        }

        public void Return()
        {
            if (!IsBorrowed)
                throw new InvalidOperationException("Book was not borrowed");

            IsBorrowed = false;
        }

    }
}
