using System;
using System.Collections.Generic;

namespace Bookish.Models
{
    public class LoanModel
    {
        public int Id { get; set;}
        public DateTime DateBorrowed { get; set;}
        public string BookCopyId {get; set;}
        public int MemberId {get; set;} 
        public DateTime DateReturned {get; set;} 
        public DateTime DueDate {get; set;}
    }
}