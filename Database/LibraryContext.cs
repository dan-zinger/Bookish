using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Bookish.Models;

namespace Bookish.Database
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Book {get; set;}
        public DbSet<BookCopy> BookCopy {get; set;}
        public DbSet<Author> Author {get; set;}
        public DbSet<Loan> Loan {get; set;}
        public DbSet<Member> Member {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=BEARDEDDRAGON;Database=BookishDatabase;Trusted_Connection=True;");
        }
    }

    
}