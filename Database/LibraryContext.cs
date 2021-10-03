using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Bookish.Models;

namespace Bookish.Database
{
    public class LibraryContext : DbContext
    {
        public DbSet<BookModel> Book {get; set;}
        public DbSet<BookCopyModel> BookCopy {get; set;}
        public DbSet<AuthorModel> Author {get; set;}
        public DbSet<LoanModel> Loan {get; set;}
        public DbSet<MemberModel> Member {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=BEARDEDDRAGON;Database=BookishDatabase;Trusted_Connection=True;");
        }
    }

    
}