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
    public partial class frmAddNewBooks : Form
    {
        public frmAddNewBooks()
        {
            InitializeComponent();
        }
        // To set placeholders for textboxs
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
            if (tbBookCode.Text == "Mã sách")
            {
                tbBookCode.Text = "";
                tbBookCode.ForeColor = Color.Black;
            }
        }
        private void tbBookCode_Leave(object sender, EventArgs e)
        {
            if (tbBookCode.Text == "")
            {
                tbBookCode.Text = "Mã sách";
                tbBookCode.ForeColor = Color.Gray;
            }
        }
        private void tbAuth_Enter(object sender, EventArgs e)
        {
            if (tbAuth.Text == "Tác giả")
            {
                tbAuth.Text = "";
                tbAuth.ForeColor = Color.Black;
            }
        }
        private void tbAuth_Leave(object sender, EventArgs e)
        {
            if (tbAuth.Text == "")
            {
                tbAuth.Text = "Tác giả";
                tbAuth.ForeColor = Color.Gray;
            }
        }
        private void tbPublishYear_Enter(object sender, EventArgs e)
        {
            if (tbPublishYear.Text == "Năm xuất bản")
            {
                tbPublishYear.Text = "";
                tbPublishYear.ForeColor = Color.Black;
            }
        }
        private void tbPublishYear_Leave(object sender, EventArgs e)
        {
            if (tbPublishYear.Text == "")
            {
                tbPublishYear.Text = "Năm xuất bản";
                tbPublishYear.ForeColor = Color.Gray;
            }
        }
        private void tbPublisher_Enter(object sender, EventArgs e)
        {
            if (tbPublisher.Text == "Nhà xuất bản")
            {
                tbPublisher.Text = "";
                tbPublisher.ForeColor = Color.Black;
            }
        }
        private void tbPublisher_Leave(object sender, EventArgs e)
        {
            if (tbPublisher.Text == "")
            {
                tbPublisher.Text = "Nhà xuất bản";
                tbPublisher.ForeColor = Color.Gray;
            }
        }
        /*End placeholders*/
    }
}
