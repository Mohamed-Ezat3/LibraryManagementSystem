using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibraryUser : User
    {
        public LibraryCard Card { get; set; }
        public void BorrowBook(Book book,Library library)
        {
           library.BorrowBook(book);
        }
        public void ReturnBook(Book book,Library library)
        {
            library.ReturnBook(book);
        }
    }
}
