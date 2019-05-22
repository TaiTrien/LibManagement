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
            this.lbDateIn = new System.Windows.Forms.Label();
            this.tbTitlesCode = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.tbBookCode = new System.Windows.Forms.TextBox();
            this.tbAuth = new System.Windows.Forms.TextBox();
            this.tbPublishYear = new System.Windows.Forms.TextBox();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDateIn
            // 
            this.lbDateIn.AutoSize = true;
            this.lbDateIn.Location = new System.Drawing.Point(97, 12);
            this.lbDateIn.Name = "lbDateIn";
            this.lbDateIn.Size = new System.Drawing.Size(77, 17);
            this.lbDateIn.TabIndex = 5;
            this.lbDateIn.Text = "Ngày nhập";
            // 
            // tbTitlesCode
            // 
            this.tbTitlesCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbTitlesCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitlesCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitlesCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTitlesCode.Location = new System.Drawing.Point(213, 82);
            this.tbTitlesCode.Name = "tbTitlesCode";
            this.tbTitlesCode.Size = new System.Drawing.Size(262, 20);
            this.tbTitlesCode.TabIndex = 2;
            this.tbTitlesCode.Text = "Mã đầu sách";
            this.tbTitlesCode.Enter += new System.EventHandler(this.tbTitlesCode_Enter);
            this.tbTitlesCode.Leave += new System.EventHandler(this.tbTitlesCode_Leave);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(536, 2);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.CalendarForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpDateIn.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtpDateIn.Location = new System.Drawing.Point(207, 12);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(264, 22);
            this.dtpDateIn.TabIndex = 1;
            // 
            // nudValue
            // 
            this.nudValue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.nudValue.Location = new System.Drawing.Point(213, 401);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(257, 22);
            this.nudValue.TabIndex = 17;
            this.nudValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbBookCode
            // 
            this.tbBookCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbBookCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbBookCode.Location = new System.Drawing.Point(213, 145);
            this.tbBookCode.Name = "tbBookCode";
            this.tbBookCode.Size = new System.Drawing.Size(262, 20);
            this.tbBookCode.TabIndex = 3;
            this.tbBookCode.Text = "Mã sách";
            this.tbBookCode.Enter += new System.EventHandler(this.tbBookCode_Enter);
            this.tbBookCode.Leave += new System.EventHandler(this.tbBookCode_Leave);
            // 
            // tbAuth
            // 
            this.tbAuth.BackColor = System.Drawing.SystemColors.Control;
            this.tbAuth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuth.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbAuth.Location = new System.Drawing.Point(213, 206);
            this.tbAuth.Name = "tbAuth";
            this.tbAuth.Size = new System.Drawing.Size(262, 20);
            this.tbAuth.TabIndex = 4;
            this.tbAuth.Text = "Tác giả";
            this.tbAuth.Enter += new System.EventHandler(this.tbAuth_Enter);
            this.tbAuth.Leave += new System.EventHandler(this.tbAuth_Leave);
            // 
            // tbPublishYear
            // 
            this.tbPublishYear.BackColor = System.Drawing.SystemColors.Control;
            this.tbPublishYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPublishYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPublishYear.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbPublishYear.Location = new System.Drawing.Point(213, 271);
            this.tbPublishYear.Name = "tbPublishYear";
            this.tbPublishYear.Size = new System.Drawing.Size(262, 20);
            this.tbPublishYear.TabIndex = 6;
            this.tbPublishYear.Text = "Năm xuất bản";
            this.tbPublishYear.Enter += new System.EventHandler(this.tbPublishYear_Enter);
            this.tbPublishYear.Leave += new System.EventHandler(this.tbPublishYear_Leave);
            // 
            // tbPublisher
            // 
            this.tbPublisher.BackColor = System.Drawing.SystemColors.Control;
            this.tbPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPublisher.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbPublisher.Location = new System.Drawing.Point(213, 334);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(262, 20);
            this.tbPublisher.TabIndex = 7;
            this.tbPublisher.Text = "Nhà xuất bản";
            this.tbPublisher.Enter += new System.EventHandler(this.tbPublisher_Enter);
            this.tbPublisher.Leave += new System.EventHandler(this.tbPublisher_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(209, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 2);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(209, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 2);
            this.label2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(209, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 2);
            this.label3.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(207, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 2);
            this.label4.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(209, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 2);
            this.label5.TabIndex = 27;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Library_Management.Properties.Resources.money_bag;
            this.pictureBox6.Location = new System.Drawing.Point(99, 381);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(59, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Library_Management.Properties.Resources.pub;
            this.pictureBox5.Location = new System.Drawing.Point(99, 315);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Library_Management.Properties.Resources.calendar;
            this.pictureBox4.Location = new System.Drawing.Point(99, 250);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Library_Management.Properties.Resources.author_sign;
            this.pictureBox3.Location = new System.Drawing.Point(99, 189);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Management.Properties.Resources.agenda;
            this.pictureBox2.Location = new System.Drawing.Point(99, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.notebook;
            this.pictureBox1.Location = new System.Drawing.Point(99, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImage = global::Library_Management.Properties.Resources.plus_128;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(570, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 188);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // frmAddNewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.tbPublishYear);
            this.Controls.Add(this.tbAuth);
            this.Controls.Add(this.tbBookCode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudValue);
            this.Controls.Add(this.dtpDateIn);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tbTitlesCode);
            this.Controls.Add(this.lbDateIn);
            this.Name = "frmAddNewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiếp nhận sách mới";
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDateIn;
        private System.Windows.Forms.TextBox tbTitlesCode;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dtpDateIn;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.TextBox tbBookCode;
        private System.Windows.Forms.TextBox tbAuth;
        private System.Windows.Forms.TextBox tbPublishYear;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnAdd;
    }
}