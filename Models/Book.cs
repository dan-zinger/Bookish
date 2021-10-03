using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bookish.Models
{
    public class Book
    {
        public int BookId { get; set;}
        [Required]
        public string Title { get; set;}
        [Required]
        public Author Author {get; set;}
        public int AuthorId { get; set;}
        [Required]
        public string Category { get; set;}
        public List<Book> Bookcopies { get; set; }
    }
}