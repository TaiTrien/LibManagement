namespace Library_Management
{
    partial class frmReturnBooks
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbBookCode = new System.Windows.Forms.TextBox();
            this.tbReaderCode = new System.Windows.Forms.TextBox();
            this.lbBookCode = new System.Windows.Forms.Label();
            this.lbReaderCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(281, 294);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(270, 75);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Trả";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // tbBookCode
            // 
            this.tbBookCode.Location = new System.Drawing.Point(338, 181);
            this.tbBookCode.Name = "tbBookCode";
            this.tbBookCode.Size = new System.Drawing.Size(330, 22);
            this.tbBookCode.TabIndex = 8;
            // 
            // tbReaderCode
            // 
            this.tbReaderCode.Location = new System.Drawing.Point(338, 81);
            this.tbReaderCode.Name = "tbReaderCode";
            this.tbReaderCode.Size = new System.Drawing.Size(330, 22);
            this.tbReaderCode.TabIndex = 7;
            // 
            // lbBookCode
            // 
            this.lbBookCode.AutoSize = true;
            this.lbBookCode.Location = new System.Drawing.Point(132, 184);
            this.lbBookCode.Name = "lbBookCode";
            this.lbBookCode.Size = new System.Drawing.Size(109, 17);
            this.lbBookCode.TabIndex = 6;
            this.lbBookCode.Text = "Mã sách cần trả";
            // 
            // lbReaderCode
            // 
            this.lbReaderCode.AutoSize = true;
            this.lbReaderCode.Location = new System.Drawing.Point(132, 87);
            this.lbReaderCode.Name = "lbReaderCode";
            this.lbReaderCode.Size = new System.Drawing.Size(77, 17);
            this.lbReaderCode.TabIndex = 5;
            this.lbReaderCode.Text = "Mã độc giả";
            // 
            // frmReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbBookCode);
            this.Controls.Add(this.tbReaderCode);
            this.Controls.Add(this.lbBookCode);
            this.Controls.Add(this.lbReaderCode);
            this.Name = "frmReturnBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhận trả sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbBookCode;
        private System.Windows.Forms.TextBox tbReaderCode;
        private System.Windows.Forms.Label lbBookCode;
        private System.Windows.Forms.Label lbReaderCode;
    }
}