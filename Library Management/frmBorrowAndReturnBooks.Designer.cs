namespace Library_Management
{
    partial class frmBorrowAndReturnBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbReaderCode = new System.Windows.Forms.Label();
            this.lbBookCode = new System.Windows.Forms.Label();
            this.tbReaderCode = new System.Windows.Forms.TextBox();
            this.tbBookCode = new System.Windows.Forms.TextBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbReaderCode
            // 
            this.lbReaderCode.AutoSize = true;
            this.lbReaderCode.Location = new System.Drawing.Point(96, 136);
            this.lbReaderCode.Name = "lbReaderCode";
            this.lbReaderCode.Size = new System.Drawing.Size(77, 17);
            this.lbReaderCode.TabIndex = 0;
            this.lbReaderCode.Text = "Mã độc giả";
            // 
            // lbBookCode
            // 
            this.lbBookCode.AutoSize = true;
            this.lbBookCode.Location = new System.Drawing.Point(96, 233);
            this.lbBookCode.Name = "lbBookCode";
            this.lbBookCode.Size = new System.Drawing.Size(127, 17);
            this.lbBookCode.TabIndex = 1;
            this.lbBookCode.Text = "Mã sách cần mượn";
            // 
            // tbReaderCode
            // 
            this.tbReaderCode.Location = new System.Drawing.Point(302, 130);
            this.tbReaderCode.Name = "tbReaderCode";
            this.tbReaderCode.Size = new System.Drawing.Size(330, 22);
            this.tbReaderCode.TabIndex = 2;
            // 
            // tbBookCode
            // 
            this.tbBookCode.Location = new System.Drawing.Point(302, 230);
            this.tbBookCode.Name = "tbBookCode";
            this.tbBookCode.Size = new System.Drawing.Size(330, 22);
            this.tbBookCode.TabIndex = 3;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(245, 343);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(270, 75);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "Mượn";
            this.btnBorrow.UseVisualStyleBackColor = true;
            // 
            // frmBorrowAndReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.tbBookCode);
            this.Controls.Add(this.tbReaderCode);
            this.Controls.Add(this.lbBookCode);
            this.Controls.Add(this.lbReaderCode);
            this.Name = "frmBorrowAndReturnBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbReaderCode;
        private System.Windows.Forms.Label lbBookCode;
        private System.Windows.Forms.TextBox tbReaderCode;
        private System.Windows.Forms.TextBox tbBookCode;
        private System.Windows.Forms.Button btnBorrow;
    }
}