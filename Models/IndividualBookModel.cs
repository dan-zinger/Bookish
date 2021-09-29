using System;
using System.Collections.Generic;

namespace Bookish.Models
{
    public class IndividualBookMod
    {
        public int IndividualBookId { get; set; }
        public int FirsBookId { get; set; }
        public Status Status { get; set; }

        
    }

    public enum Status
        {
            Available,
            OnLoan,
            Overdue
        }
    
}