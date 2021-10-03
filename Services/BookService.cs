using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Bookish.Models;
using Bookish.Database;
using System.Linq;

namespace Bookish.Services

{
    public interface IBookService
    {
        public Book GetBook(int bookId);
        public List<Book> GetAllBooks();
        public  void CreateBook(Book book);
        public void AddCopyOfBook(int parentBookId);
        public void DeleteBook(int bookId);
    }
    public class BookService : IBookService
    {
        private readonly LibraryContext _libraryContext;    
        public BookService (LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public Book GetBook(int bookId)
        {
            //List<BookModel> books = _libraryContext.Books.ToList();
            //BookModel book = books.Where(b => b.Id == bookId).Single();
            Book book =  _libraryContext.Book.Where(b => b.BookId == bookId).Single();
            return book;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = _libraryContext.Book.Include(b => b.Author).ToList();
            return books;
        }
        // pass in bookmodel
        public void CreateBook(Book book)
        {
            _libraryContext.Book.Add(book);
            _libraryContext.SaveChanges();       
        }

        public void AddCopyOfBook(int bookId)
        {
            BookCopy copy = new BookCopy
            {
                BookId = bookId
            };
            _libraryContext.BookCopy.Add(copy);
            _libraryContext.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            Book book =  _libraryContext.Book.Where(b => b.BookId == bookId).Single();
            _libraryContext.Book.Remove(book);
            _libraryContext.SaveChanges();
        }
    }
}