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
    public partial class frmAddNewAuths : Form
    {
        public frmAddNewAuths()
        {
            InitializeComponent();
            
        }
        // To set placeholders
        private void tbName_Enter(object sender, EventArgs e)
        {
            if (tbName.Text == "Họ tên")
            {
                tbName.Text = "";
                tbName.ForeColor = Color.Black;
            }
        }
        private void tbName_Leave(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {
                tbName.Text = "Họ tên";
                tbName.ForeColor = Color.Gray;
            }
        }
        private void tbAuthCode_Enter(object sender, EventArgs e)
        {
            if (tbAuthCode.Text == "Họ tên")
            {
                tbAuthCode.Text = "";
                tbAuthCode.ForeColor = Color.Black;
            }
        }
        private void tbAuthCode_Leave(object sender, EventArgs e)
        {
            if (tbAuthCode.Text == "")
            {
                tbAuthCode.Text = "Họ tên";
                tbAuthCode.ForeColor = Color.Gray;
            }
        }
        //To end placeholders
    }
}
