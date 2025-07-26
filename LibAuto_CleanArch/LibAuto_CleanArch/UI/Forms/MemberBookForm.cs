using LibAuto_CleanArch.Context;
using LibAuto_CleanArch.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibAuto_CleanArch.UI.Forms
{
    public partial class MemberBookForm: Form
    {
        LibraryDbContext db = new LibraryDbContext(); 
        public MemberBookForm()
        {
            InitializeComponent();
        }

        private void MemberBookForm_Load(object sender, EventArgs e)
        {

                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var kitaplar = db.Books.Select(b => new
            {
                b.BookId,
                b.BookName,
                b.WriterName,
                b.PageCount,
                Status = b.Status ? "Book Available" : "Book Not Available"
            }).ToList();


            dataGridView1.DataSource = kitaplar;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            

    }


    }
}
