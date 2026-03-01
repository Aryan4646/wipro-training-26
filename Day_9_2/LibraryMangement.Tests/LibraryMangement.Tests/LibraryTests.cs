using NUnit.Framework;
using LibraryManagement;
using System.Linq;

namespace LibraryManagement.Tests
{
    public class LibraryTests
    {
        private Library library;
        private Book book;
        private Borrower borrower;

        [SetUp]
        public void Setup()
        {
            library = new Library();
            book = new Book("Clean Code", "Robert Martin", "123");
            borrower = new Borrower("Aryan", "C001");

            library.AddBook(book);
            library.RegisterBorrower(borrower);
        }

        [Test]
        public void AddBook_AddsBookSuccessfully()
        {
            Assert.AreEqual(1, library.Books.Count);
        }

        [Test]
        public void RegisterBorrower_AddsBorrowerSuccessfully()
        {
            Assert.AreEqual(1, library.Borrowers.Count);
        }

        [Test]
        public void BorrowBook_MarksBookAsBorrowed()
        {
            library.BorrowBook("123", "C001");

            Assert.IsTrue(book.IsBorrowed);
            Assert.Contains(book, borrower.BorrowedBooks);
        }

        [Test]
        public void ReturnBook_MarksBookAsAvailable()
        {
            library.BorrowBook("123", "C001");
            library.ReturnBook("123", "C001");

            Assert.IsFalse(book.IsBorrowed);
            Assert.IsEmpty(borrower.BorrowedBooks);
        }

        [Test]
        public void ViewBooks_ReturnsCorrectList()
        {
            var books = library.ViewBooks();
            Assert.AreEqual(1, books.Count);
        }

        [Test]
        public void ViewBorrowers_ReturnsCorrectList()
        {
            var borrowers = library.ViewBorrowers();
            Assert.AreEqual(1, borrowers.Count);
        }
    }
}
