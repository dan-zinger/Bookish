using System;
using System.Collections.Generic;

namespace Bookish.Models
{
    public class BookModel
    {
        public int BookId { get; set;}
        public string Title { get; set;}
        public string Author {get; set;}
        public string Category { get; set;}
        public List <BookModel> books {get; set;}
    }
}