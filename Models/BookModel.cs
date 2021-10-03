using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bookish.Models
{
    public class BookModel
    {
        public int Id { get; set;}
        [Required]
        public string Title { get; set;}
        [Required]
        public AuthorModel Author {get; set;}
        public int AuthorModelId { get; set;}
        [Required]
        public string Category { get; set;}
        public List<BookCopyModel> Bookcopies { get; set; }
    }
}