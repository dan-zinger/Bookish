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
        public BookModel GetBook(int bookId);
        public List<BookModel> GetAllBooks();
        public  void CreateBook(BookModel book);
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

        public BookModel GetBook(int bookId)
        {
            //List<BookModel> books = _libraryContext.Books.ToList();
            //BookModel book = books.Where(b => b.Id == bookId).Single();
            BookModel book =  _libraryContext.Book.Where(b => b.Id == bookId).Single();
            return book;
        }

        public List<BookModel> GetAllBooks()
        {
            List<BookModel> books = _libraryContext.Book.Include(b => b.Author).ToList();
            return books;
        }
        // pass in bookmodel
        public void CreateBook(BookModel book)
        {
            _libraryContext.Book.Add(book);
            _libraryContext.SaveChanges();       
        }

        public void AddCopyOfBook(int bookId)
        {
            BookCopyModel copy = new BookCopyModel
            {
                BookId = bookId
            };
            _libraryContext.BookCopy.Add(copy);
            _libraryContext.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            BookModel book =  _libraryContext.Book.Where(b => b.Id == bookId).Single();
            _libraryContext.Book.Remove(book);
            _libraryContext.SaveChanges();
        }
    }
}