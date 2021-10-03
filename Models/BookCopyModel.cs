using System;
using System.Collections.Generic;

namespace Bookish.Models
{
    public class BookCopyModel
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Status Status { get; set; }

        
    }

    public enum Status
        {
            Available,
            OnLoan,
            Overdue
        }
    
}