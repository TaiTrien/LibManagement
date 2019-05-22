namespace Library_Management
{
    partial class frmAddNewTitles
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbBookCode = new System.Windows.Forms.TextBox();
            this.tbTitlesCode = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.tbAuth = new System.Windows.Forms.TextBox();
            this.lsbType = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(487, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 31;
            // 
            // tbBookCode
            // 
            this.tbBookCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbBookCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBookCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbBookCode.Location = new System.Drawing.Point(183, 148);
            this.tbBookCode.Name = "tbBookCode";
            this.tbBookCode.Size = new System.Drawing.Size(200, 15);
            this.tbBookCode.TabIndex = 27;
            this.tbBookCode.Text = "Tên đầu sách";
            // 
            // tbTitlesCode
            // 
            this.tbTitlesCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbTitlesCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitlesCode.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTitlesCode.Location = new System.Drawing.Point(183, 76);
            this.tbTitlesCode.Name = "tbTitlesCode";
            this.tbTitlesCode.Size = new System.Drawing.Size(200, 15);
            this.tbTitlesCode.TabIndex = 26;
            this.tbTitlesCode.Text = "Mã đầu sách";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(90, 275);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(59, 17);
            this.lbType.TabIndex = 22;
            this.lbType.Text = "Thể loại";
            // 
            // tbAuth
            // 
            this.tbAuth.BackColor = System.Drawing.SystemColors.Control;
            this.tbAuth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAuth.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbAuth.Location = new System.Drawing.Point(183, 215);
            this.tbAuth.Multiline = true;
            this.tbAuth.Name = "tbAuth";
            this.tbAuth.Size = new System.Drawing.Size(200, 22);
            this.tbAuth.TabIndex = 28;
            this.tbAuth.Text = "Tác giả";
            // 
            // lsbType
            // 
            this.lsbType.FormattingEnabled = true;
            this.lsbType.ItemHeight = 16;
            this.lsbType.Location = new System.Drawing.Point(183, 276);
            this.lsbType.Name = "lsbType";
            this.lsbType.Size = new System.Drawing.Size(200, 148);
            this.lsbType.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(180, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 2);
            this.label1.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(180, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 2);
            this.label2.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(180, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 2);
            this.label3.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.notebook;
            this.pictureBox1.Location = new System.Drawing.Point(93, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Management.Properties.Resources.agenda;
            this.pictureBox2.Location = new System.Drawing.Point(93, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Library_Management.Properties.Resources.author_sign;
            this.pictureBox3.Location = new System.Drawing.Point(93, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImage = global::Library_Management.Properties.Resources.plus_128;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(487, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(272, 188);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // frmAddNewTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbType);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tbAuth);
            this.Controls.Add(this.tbBookCode);
            this.Controls.Add(this.tbTitlesCode);
            this.Controls.Add(this.lbType);
            this.Name = "frmAddNewTitles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đầu sách mới";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tbBookCode;
        private System.Windows.Forms.TextBox tbTitlesCode;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TextBox tbAuth;
        private System.Windows.Forms.ListBox lsbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAdd;
    }
}