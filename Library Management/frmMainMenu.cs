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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            //To create & add menu books to main menu
            this.lbMessage.Hide();
            frmMenuBooks frmMenuBooks = new frmMenuBooks();
            frmMenuBooks.TopLevel = false;
            this.pnDisplay.Controls.Clear();
            this.pnDisplay.Controls.Add(frmMenuBooks);
            frmMenuBooks.Show();
        }

        private void btnReaders_Click(object sender, EventArgs e)
        {
            //To create & add menu readers to main menu
            this.lbMessage.Hide();
            frmReadersManage frmReadersManage = new frmReadersManage();
            frmReadersManage.TopLevel = false;
            this.pnDisplay.Controls.Clear();
            this.pnDisplay.Controls.Add(frmReadersManage);
            frmReadersManage.Show();
        }

    }
}
