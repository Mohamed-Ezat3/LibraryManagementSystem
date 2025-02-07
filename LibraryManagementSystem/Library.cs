using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
       private List<Book> books = new List<Book>();
       private List<Book> BorrowedBooks = new List<Book>();
       public void Display()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }
            else
            {
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{books[i].Title}");
                }
            }
        }
        public void AddBook( Book newbook)
        {
            books.Add(newbook);
            Console.WriteLine($"Book {newbook.Title} added successfully");
        }
        public void RemoveBook(Book book)
        {
            if (books.Any(b => b.Title == book.Title))
            {
                books.Remove(book);
                Console.WriteLine($"Book{book.Title} Remove successfully");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
            
        }
        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }
         
        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
        }
    }
}
