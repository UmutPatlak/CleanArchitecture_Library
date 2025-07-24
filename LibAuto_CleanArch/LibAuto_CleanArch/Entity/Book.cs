using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAuto_CleanArch.Entity
{
   public class Book
    {
        [Key] public int BookId { get; set; }
        public string BookName { get; set; }
        public string WriterName { get; set; }
        public int PageCount { get; set; }
        public bool Status { get; set; }

        public ICollection<Loan> Loans { get; set; }

    }
}
