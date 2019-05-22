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
    public partial class frmTitlesManage : Form
    {
        public frmTitlesManage()
        {
            InitializeComponent();
        }
        // to create a form to add new titles
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewTitles frmAddNewTitles = new frmAddNewTitles();
            frmAddNewTitles.ShowDialog();
        }
    }
}
