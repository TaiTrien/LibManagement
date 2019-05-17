using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class frmBooksManage : Form
    {
        public frmBooksManage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // create a form to add a new book
            frmAddNewBooks frmAddNewBooks = new frmAddNewBooks();
            frmAddNewBooks.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // to create form to search books
            frmSearchBooks frmSearchBooks = new frmSearchBooks();
            frmSearchBooks.ShowDialog();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frmBorrowAndReturnBooks frmBorrowBooks = new frmBorrowAndReturnBooks();
            frmBorrowBooks.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBorrowAndReturnBooks frmReturnBooks = new frmBorrowAndReturnBooks();
            frmReturnBooks.Text = "Nhận trả sách";
            frmReturnBooks.ShowDialog();
        }
    }
}
