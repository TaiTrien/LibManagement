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

        public static implicit operator frmMenuBooks(frmAddDelMod v)
        {
            throw new NotImplementedException();
        }

        private void btnTitleManage_Click(object sender, EventArgs e)
        {
            frmAddDelMod frmAddDelModTitle = new frmAddDelMod(); // create a form to add, delete, modify title
            frmAddDelModTitle.TopLevel = false;
            this.Controls.Add(frmAddDelModTitle);
            this.pnControl.Hide();
            this.pnFooter.Hide();
            frmAddDelModTitle.Show();
        }

        private void btnBooksManage_Click(object sender, EventArgs e)
        {
            // create a form to add, delete, modify, search, borrow and return books
            frmBooksManage frmBooksManage = new frmBooksManage(); 
            frmBooksManage.TopLevel = false;
            this.Controls.Add(frmBooksManage);
            this.pnControl.Hide();
            this.pnFooter.Hide();
            frmBooksManage.Show();
        }
    }
}
