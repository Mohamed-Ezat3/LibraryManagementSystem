using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PublicationYear {get; set; }

        public Book(string title, string author, string publisher,int publicationYear)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            PublicationYear = publicationYear;
        }
        
    }
}
