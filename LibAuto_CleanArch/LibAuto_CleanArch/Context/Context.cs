using LibAuto_CleanArch.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibAuto_CleanArch.Context
{
  public  class LibraryDbContext : DbContext
    {
        public LibraryDbContext() : base("Context")
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
