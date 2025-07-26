using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibAuto_CleanArch.Context;
using LibAuto_CleanArch.Entity;
namespace LibAuto_CleanArch.UI.Forms
{
    
    public partial class EmployeeBookForm: Form
    {
        LibraryDbContext db = new LibraryDbContext();

        public EmployeeBookForm()
        {
            InitializeComponent();  

        }

        private void EmployeeBookForm_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            var deger = db.Books.Add(new Book
            {
                BookName = txtBookName.Text,
                PageCount = int.Parse(txtPageCount.Text),
                WriterName = txtWriterName.Text,
                Status = checkBox1.Checked
            });
            
            db.SaveChanges();
            MessageBox.Show("Basariyla Eklendi" );
            var select = db.Books.Select(x=>x);
            dataGridView2.DataSource = select.ToList();

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


            dataGridView2.DataSource = kitaplar; 

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                txtBookId.Text = row.Cells["BookId"].Value.ToString();
                txtBookName.Text = row.Cells["BookName"].Value.ToString();
                txtWriterName.Text = row.Cells["WriterName"].Value.ToString();
                txtPageCount.Text = row.Cells["PageCount"].Value.ToString();
            string status = row.Cells["Status"].Value.ToString();
            checkBox1.Checked = (status == "Book Available");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ogrenciid = Convert.ToInt32(txtBookId.Text);
            var query = db.Books.Find(ogrenciid);
            query.BookName = txtBookName.Text;
            query.WriterName = txtWriterName.Text;
            query.Status = checkBox1.Checked;
            query.PageCount = int.Parse(txtPageCount.Text);
            
            db.SaveChanges();
            var kitaplar = db.Books.Select(b => new
            {
                b.BookId,
                b.BookName,
                b.WriterName,
                b.PageCount,
                Status = b.Status ? "Book Available" : "Book Not Available"
            }).ToList();


            dataGridView2.DataSource = kitaplar;

            MessageBox.Show("Guncellendi");
        }

        
    }
    
}