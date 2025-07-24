using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAuto_CleanArch.Entity
{
    public class Loan
    {
        [Key] public int LoanID { get; set; }

        public int BookID { get; set; }

        public int MemberID { get; set; }

        public DateTime DateIssued { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool wasitReturned { get; set; }

        [ForeignKey("MemberID")] public virtual Member Member { get; set; }
        [ForeignKey("BookID")] public virtual Book Book { get; set; }

    }
}
