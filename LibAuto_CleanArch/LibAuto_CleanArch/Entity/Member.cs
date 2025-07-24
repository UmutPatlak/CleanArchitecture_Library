using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAuto_CleanArch.Entity
{
    public class Member
    {


        [Key]   public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberSurName { get; set; }
        public string MemberAddress { get; set; }
        public string MemberMail { get; set; }

        public ICollection<Loan> Loans { get; set; }

    }
}
