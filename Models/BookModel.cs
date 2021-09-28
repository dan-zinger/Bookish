using System;
using System.Collections.Generic;

namespace Bookish.Models
{
    public class BookModel
    {
        public string Title { get; set;}
        public string Author {get; set;}
        public List <BookModel> books {get; set;}
    }
}