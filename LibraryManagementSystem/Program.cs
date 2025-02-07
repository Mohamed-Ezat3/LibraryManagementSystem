namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t======= Welcome to the Library Management System =======\n");
            Library library = new Library();
            Console.WriteLine("You are: 1. Librarian - 2. User");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Welcome Librarian, enter your name:");
                Librarian librarian = new Librarian();
                librarian.Name = Console.ReadLine();
                Console.WriteLine($"Welcome {librarian.Name}");
                while (true)
                {
                    Console.WriteLine("What do you want to do? 1. Add Book 2. Remove Book 3. Display Books 4. Exit");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            var book= GetBookDetails();
                            librarian.AddBook(book, library);
                            break;
                        case "2":
                            book = GetBookDetails();
                            librarian.RemoveBook(book, library);
                            break;
                        case "3":
                            Console.WriteLine("The book list:");
                            librarian.Display(library);
                            break;
                        case "4":
                            Exit();
                            break;
                        default:
                            Console.WriteLine("Please enter a correct choice");
                            break;
                    }
                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Welcome User, enter your name:");
                LibraryUser libraryUser = new LibraryUser();
                libraryUser.Name = Console.ReadLine();
                Console.WriteLine($"Welcome {libraryUser.Name}");
                while (true)
                {
                    Console.WriteLine("What do you want to do? 1. Borrow Book 2. Return Book 3. Display Books 4. Exit");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            var book = GetBookDetails();
                            libraryUser.BorrowBook(book, library);
                            break;
                        case "2":
                            Console.WriteLine("Enter book details to return (Title - Author - Publisher - Publication Year)");
                            book = GetBookDetails();
                            libraryUser.ReturnBook(book, library);
                            break;
                        case "3":
                            Console.WriteLine("The book list:");
                            libraryUser.Display(library);
                            break;
                        case "4":
                            Exit();
                            break;
                        default:
                            Console.WriteLine("Please enter a correct choice");
                            break;
                    }
                    Console.WriteLine("Press Enter to return to the menu.");
                    Console.ReadLine();
                    Console.Clear();
                }


            }
        }
        static public Book GetBookDetails()
        {
            Console.WriteLine("Enter book details (Title - Author - Publisher - Publication Year):");
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            string publisher = Console.ReadLine();
            int publicationYear= int.Parse(Console.ReadLine());
            
            return new Book(title, author, publisher, publicationYear);
        }
        static void Exit()
        {
            Console.WriteLine("Are you sure you want to exit? (Y/N)");
            if (Console.ReadLine().ToUpper() == "Y")
                Environment.Exit(0);
        }
    }
}
