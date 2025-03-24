namespace LibraryManagementSystem.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class LibraryTests
    {
        private Library library;

        [SetUp]
        public void SetUp()
        {
            library = new Library();
        }

        [Test]
        public void TestAddBook()
        {
            var book = new Book("C# Programming", "John Doe", "1234567890");
            library.AddBook(book);

            Assert.AreEqual(1, library.Books.Count);
            Assert.AreEqual("C# Programming", library.Books[0].Title);
        }

        [Test]
        public void TestRegisterBorrower()
        {
            var borrower = new Borrower("Alice", "LC123");
            library.RegisterBorrower(borrower);

            Assert.AreEqual(1, library.Borrowers.Count);
            Assert.AreEqual("Alice", library.Borrowers[0].Name);
        }

        [Test]
        public void TestBorrowBook()
        {
            var book = new Book("C# Programming", "John Doe", "1234567890");
            var borrower = new Borrower("Alice", "LC123");
            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("1234567890", "LC123");

            Assert.IsTrue(book.IsBorrowed);
            Assert.AreEqual(1, borrower.BorrowedBooks.Count);
        }

        [Test]
        public void TestReturnBook()
        {
            var book = new Book("C# Programming", "John Doe", "1234567890");
            var borrower = new Borrower("Alice", "LC123");
            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("1234567890", "LC123");
            library.ReturnBook("1234567890", "LC123");

            Assert.IsFalse(book.IsBorrowed);
            Assert.AreEqual(0, borrower.BorrowedBooks.Count);
        }

        [Test]
        public void TestViewBooksAndBorrowers()
        {
            var book = new Book("C# Programming", "John Doe", "1234567890");
            var borrower = new Borrower("Alice", "LC123");
            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("1234567890", "LC123");

            // Test Viewing Books
            library.ViewBooks();
            // Test Viewing Borrowers
            library.ViewBorrowers();
        }
    }
}
