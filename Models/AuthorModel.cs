using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookish.Models
{
    public class AuthorModel
    {
        
        public int AuthorModelId { get; set;}
        
        [Required]
        public string Name { get; set;}

        public List<BookModel> Books { get; set; }
    }
}