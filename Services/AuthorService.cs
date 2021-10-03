using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Bookish.Models;
using Bookish.Database;
using System.Linq;

namespace Bookish.Services

{
    public interface IAuthorService
    {
        // signitures of author methods
        public void CreateAuthor(Author author);
        public List<Author> GetAuthorList();
    }
    public class AuthorService : IAuthorService
    {
        private readonly LibraryContext _libraryContext;    
        public AuthorService (LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public void CreateAuthor(Author author)
        {
            _libraryContext.Author.Add(author);
            _libraryContext.SaveChanges();
        }

        public List<Author> GetAuthorList()
        {
            List<Author> authors = _libraryContext.Author.ToList();
            return authors;
        }
    }
}