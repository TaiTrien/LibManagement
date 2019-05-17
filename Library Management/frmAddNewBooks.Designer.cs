namespace Library_Management
{
    partial class frmAddNewBooks
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
            this.lbCodeTitles = new System.Windows.Forms.Label();
            this.lbCodeBooks = new System.Windows.Forms.Label();
            this.lbAuth = new System.Windows.Forms.Label();
            this.lbPublishYear = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lbDateIn = new System.Windows.Forms.Label();
            this.lbValue = new System.Windows.Forms.Label();
            this.tbTitlesCode = new System.Windows.Forms.TextBox();
            this.tbBookCode = new System.Windows.Forms.TextBox();
            this.tbAuth = new System.Windows.Forms.TextBox();
            this.tbPublishYear = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodeTitles
            // 
            this.lbCodeTitles.AutoSize = true;
            this.lbCodeTitles.Location = new System.Drawing.Point(100, 58);
            this.lbCodeTitles.Name = "lbCodeTitles";
            this.lbCodeTitles.Size = new System.Drawing.Size(89, 17);
            this.lbCodeTitles.TabIndex = 0;
            this.lbCodeTitles.Text = "Mã đầu sách";
            // 
            // lbCodeBooks
            // 
            this.lbCodeBooks.AutoSize = true;
            this.lbCodeBooks.Location = new System.Drawing.Point(100, 100);
            this.lbCodeBooks.Name = "lbCodeBooks";
            this.lbCodeBooks.Size = new System.Drawing.Size(61, 17);
            this.lbCodeBooks.TabIndex = 1;
            this.lbCodeBooks.Text = "Mã sách";
            // 
            // lbAuth
            // 
            this.lbAuth.AutoSize = true;
            this.lbAuth.Location = new System.Drawing.Point(100, 143);
            this.lbAuth.Name = "lbAuth";
            this.lbAuth.Size = new System.Drawing.Size(55, 17);
            this.lbAuth.TabIndex = 2;
            this.lbAuth.Text = "Tác giả";
            // 
            // lbPublishYear
            // 
            this.lbPublishYear.AutoSize = true;
            this.lbPublishYear.Location = new System.Drawing.Point(100, 179);
            this.lbPublishYear.Name = "lbPublishYear";
            this.lbPublishYear.Size = new System.Drawing.Size(95, 17);
            this.lbPublishYear.TabIndex = 3;
            this.lbPublishYear.Text = "Năm xuất bản";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Location = new System.Drawing.Point(100, 219);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(92, 17);
            this.lbPublisher.TabIndex = 4;
            this.lbPublisher.Text = "Nhà xuất bản";
            // 
            // lbDateIn
            // 
            this.lbDateIn.AutoSize = true;
            this.lbDateIn.Location = new System.Drawing.Point(100, 265);
            this.lbDateIn.Name = "lbDateIn";
            this.lbDateIn.Size = new System.Drawing.Size(77, 17);
            this.lbDateIn.TabIndex = 5;
            this.lbDateIn.Text = "Ngày nhập";
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(100, 315);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(48, 17);
            this.lbValue.TabIndex = 6;
            this.lbValue.Text = "Trị giá";
            // 
            // tbTitlesCode
            // 
            this.tbTitlesCode.Location = new System.Drawing.Point(232, 58);
            this.tbTitlesCode.Name = "tbTitlesCode";
            this.tbTitlesCode.Size = new System.Drawing.Size(200, 22);
            this.tbTitlesCode.TabIndex = 7;
            // 
            // tbBookCode
            // 
            this.tbBookCode.Location = new System.Drawing.Point(232, 100);
            this.tbBookCode.Name = "tbBookCode";
            this.tbBookCode.Size = new System.Drawing.Size(200, 22);
            this.tbBookCode.TabIndex = 9;
            // 
            // tbAuth
            // 
            this.tbAuth.Location = new System.Drawing.Point(232, 140);
            this.tbAuth.Name = "tbAuth";
            this.tbAuth.Size = new System.Drawing.Size(200, 22);
            this.tbAuth.TabIndex = 10;
            // 
            // tbPublishYear
            // 
            this.tbPublishYear.Location = new System.Drawing.Point(232, 179);
            this.tbPublishYear.Name = "tbPublishYear";
            this.tbPublishYear.Size = new System.Drawing.Size(200, 22);
            this.tbPublishYear.TabIndex = 11;
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(232, 219);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(200, 22);
            this.tbPublisher.TabIndex = 12;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(536, 2);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.Location = new System.Drawing.Point(232, 265);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(200, 22);
            this.dtpDateIn.TabIndex = 16;
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(232, 315);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(200, 22);
            this.nudValue.TabIndex = 17;
            this.nudValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(276, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 60);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmAddNewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.dtpDateIn);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.tbPublishYear);
            this.Controls.Add(this.tbAuth);
            this.Controls.Add(this.tbBookCode);
            this.Controls.Add(this.tbTitlesCode);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.lbDateIn);
            this.Controls.Add(this.lbPublisher);
            this.Controls.Add(this.lbPublishYear);
            this.Controls.Add(this.lbAuth);
            this.Controls.Add(this.lbCodeBooks);
            this.Controls.Add(this.lbCodeTitles);
            this.Name = "frmAddNewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiếp nhận sách mới";
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodeTitles;
        private System.Windows.Forms.Label lbCodeBooks;
        private System.Windows.Forms.Label lbAuth;
        private System.Windows.Forms.Label lbPublishYear;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Label lbDateIn;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.TextBox tbTitlesCode;
        private System.Windows.Forms.TextBox tbBookCode;
        private System.Windows.Forms.TextBox tbAuth;
        private System.Windows.Forms.TextBox tbPublishYear;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.Button btnAdd;
    }
}