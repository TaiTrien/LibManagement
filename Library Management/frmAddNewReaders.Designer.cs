namespace Library_Management
{
    partial class frmAddNewReaders
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDateCreateCard = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbDateCreateCard = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbDob = new System.Windows.Forms.Label();
            this.lbTypeofReaders = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.cbTypeofReaders = new System.Windows.Forms.ComboBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(273, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 60);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dtpDateCreateCard
            // 
            this.dtpDateCreateCard.Location = new System.Drawing.Point(183, 291);
            this.dtpDateCreateCard.Name = "dtpDateCreateCard";
            this.dtpDateCreateCard.Size = new System.Drawing.Size(200, 22);
            this.dtpDateCreateCard.TabIndex = 32;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(538, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 31;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(183, 245);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 22);
            this.tbEmail.TabIndex = 30;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(183, 205);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(200, 22);
            this.tbAddress.TabIndex = 29;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(183, 84);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 22);
            this.tbName.TabIndex = 26;
            // 
            // lbDateCreateCard
            // 
            this.lbDateCreateCard.AutoSize = true;
            this.lbDateCreateCard.Location = new System.Drawing.Point(51, 291);
            this.lbDateCreateCard.Name = "lbDateCreateCard";
            this.lbDateCreateCard.Size = new System.Drawing.Size(88, 17);
            this.lbDateCreateCard.TabIndex = 24;
            this.lbDateCreateCard.Text = "Ngày lập thẻ";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(51, 245);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 23;
            this.lbEmail.Text = "Email";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(51, 205);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(51, 17);
            this.lbAddress.TabIndex = 22;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // lbDob
            // 
            this.lbDob.AutoSize = true;
            this.lbDob.Location = new System.Drawing.Point(51, 169);
            this.lbDob.Name = "lbDob";
            this.lbDob.Size = new System.Drawing.Size(71, 17);
            this.lbDob.TabIndex = 21;
            this.lbDob.Text = "Ngày sinh";
            // 
            // lbTypeofReaders
            // 
            this.lbTypeofReaders.AutoSize = true;
            this.lbTypeofReaders.Location = new System.Drawing.Point(51, 126);
            this.lbTypeofReaders.Name = "lbTypeofReaders";
            this.lbTypeofReaders.Size = new System.Drawing.Size(85, 17);
            this.lbTypeofReaders.TabIndex = 20;
            this.lbTypeofReaders.Text = "Loại độc giả";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(51, 84);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(50, 17);
            this.lbName.TabIndex = 19;
            this.lbName.Text = "Họ tên";
            // 
            // cbTypeofReaders
            // 
            this.cbTypeofReaders.FormattingEnabled = true;
            this.cbTypeofReaders.Location = new System.Drawing.Point(183, 126);
            this.cbTypeofReaders.Name = "cbTypeofReaders";
            this.cbTypeofReaders.Size = new System.Drawing.Size(200, 24);
            this.cbTypeofReaders.TabIndex = 35;
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(183, 164);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 22);
            this.dtpDob.TabIndex = 36;
            // 
            // frmAddNewReaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.cbTypeofReaders);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDateCreateCard);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbDateCreateCard);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbDob);
            this.Controls.Add(this.lbTypeofReaders);
            this.Controls.Add(this.lbName);
            this.Name = "frmAddNewReaders";
            this.Text = "Lập thẻ độc giả";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDateCreateCard;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbDateCreateCard;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbDob;
        private System.Windows.Forms.Label lbTypeofReaders;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbTypeofReaders;
        private System.Windows.Forms.DateTimePicker dtpDob;
    }
}