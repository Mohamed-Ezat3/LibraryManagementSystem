using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem
{
    internal class Librarian : User
    {
        public void AddBook(Book newbook, Library library)
        {
            library.AddBook(newbook);
        }
        public void RemoveBook(Book book, Library library) 
        {
            library.RemoveBook(book);
        }   
    }
}
