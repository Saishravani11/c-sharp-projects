namespace LibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Borrower> Borrowers { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Borrowers = new List<Borrower>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Book '{book.Title}' has been added to the library.");
        }

        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
            Console.WriteLine($"Borrower '{borrower.Name}' has been registered.");
        }

        public void BorrowBook(string isbn, string libraryCardNumber)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn && !b.IsBorrowed);
            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

            if (book != null && borrower != null)
            {
                book.Borrow();
                borrower.BorrowBook(book);
                Console.WriteLine($"Book '{book.Title}' has been borrowed by '{borrower.Name}'.");
            }
            else
            {
                Console.WriteLine("Book not available or borrower not registered.");
            }
        }

        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn && b.IsBorrowed);
            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

            if (book != null && borrower != null)
            {
                book.Return();
                borrower.ReturnBook(book);
                Console.WriteLine($"Book '{book.Title}' has been returned by '{borrower.Name}'.");
            }
            else
            {
                Console.WriteLine("Book not borrowed or borrower not registered.");
            }
        }

        public void ViewBooks()
        {
            Console.WriteLine("Books in the library:");
            foreach (var book in Books)
            {
                string status = book.IsBorrowed ? "Borrowed" : "Available";
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Status: {status}");
            }
        }

        public void ViewBorrowers()
        {
            Console.WriteLine("Borrowers registered:");
            foreach (var borrower in Borrowers)
            {
                Console.WriteLine($"Name: {borrower.Name}, Library Card: {borrower.LibraryCardNumber}");
                Console.WriteLine("Borrowed Books:");
                foreach (var book in borrower.BorrowedBooks)
                {
                    Console.WriteLine($"  - {book.Title}");
                }
            }
        }
    }
}
