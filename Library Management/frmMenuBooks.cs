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
    public partial class frmMenuBooks : Form
    {
        public frmMenuBooks()
        {
            InitializeComponent();
        }

        public static implicit operator frmMenuBooks(frmTitlesManage v)
        {
            throw new NotImplementedException();
        }
        // create a form to add, delete, modify title
        private void btnTitleManage_Click(object sender, EventArgs e)
        {
            frmTitlesManage frmAddDelModTitles = new frmTitlesManage(); 
            frmAddDelModTitles.TopLevel = false;
            this.Controls.Add(frmAddDelModTitles);
            this.pnControl.Hide();
            this.pnFooter.Hide();
            frmAddDelModTitles.Show();
        }
        // create a form to add, delete, modify, search, borrow and return books
        private void btnBooksManage_Click(object sender, EventArgs e)
        {
            frmBooksManage frmBooksManage = new frmBooksManage(); 
            frmBooksManage.TopLevel = false;
            this.Controls.Add(frmBooksManage);
            this.pnControl.Hide();
            this.pnFooter.Hide();
            frmBooksManage.Show();
        }
    }
}
