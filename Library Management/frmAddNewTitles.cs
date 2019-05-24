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
    public partial class frmAddNewTitles : Form
    {
        public frmAddNewTitles()
        {
            InitializeComponent();
        }
        // To create placeholders
        private void tbTitlesCode_Enter(object sender, EventArgs e)
        {
            if (tbTitlesCode.Text == "Mã đầu sách")
            {
                tbTitlesCode.Text = "";
                tbTitlesCode.ForeColor = Color.Black;
            }
        }
        private void tbTitlesCode_Leave(object sender, EventArgs e)
        {
            if (tbTitlesCode.Text == "")
            {
                tbTitlesCode.Text = "Mã đầu sách";
                tbTitlesCode.ForeColor = Color.Gray;
            }
        }
        private void tbBookCode_Enter(object sender, EventArgs e)
        {
            if (tbBookCode.Text == "Tên đầu sách")
            {
                tbBookCode.Text = "";
                tbBookCode.ForeColor = Color.Black;
            }
        }
        private void tbBookCode_Leave(object sender, EventArgs e)
        {
            if (tbBookCode.Text == "")
            {
                tbBookCode.Text = "Tên đầu sách";
                tbBookCode.ForeColor = Color.Gray;
            }
        }
        //end placeholders
    }
}
