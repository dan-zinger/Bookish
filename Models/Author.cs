using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookish.Models
{
    public class Author
    {
        
        public int AuthorId { get; set;}
        
        [Required]
        public string Name { get; set;}

        public List<Book> Books { get; set; }
    }
}