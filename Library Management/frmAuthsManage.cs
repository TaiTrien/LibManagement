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
    public partial class frmAuthsManage : Form
    {
        public frmAuthsManage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // create a form to add a new auth
            frmAddNewAuths frmAddNewAuths = new frmAddNewAuths();
            frmAddNewAuths.ShowDialog();
        }
    }
}
