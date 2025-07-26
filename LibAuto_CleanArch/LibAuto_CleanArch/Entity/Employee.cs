using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAuto_CleanArch.Entity
{
   public class Employee
    {


        [Key] public int EmployeeID { get; set; }

        public int EmployeeUserName { get; set; }
        public int EmployeePassword { get; set; }

        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }





    }
}
