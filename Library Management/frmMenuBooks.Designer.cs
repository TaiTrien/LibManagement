namespace Library_Management
{
    partial class frmMenuBooks
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
            this.pnControl = new System.Windows.Forms.Panel();
            this.lbBooksManage = new System.Windows.Forms.Label();
            this.lbTitleManage = new System.Windows.Forms.Label();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.lbContact = new System.Windows.Forms.Label();
            this.btnBooksManage = new System.Windows.Forms.Button();
            this.btnTitleManage = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnControl.SuspendLayout();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnControl.Controls.Add(this.lbBooksManage);
            this.pnControl.Controls.Add(this.lbTitleManage);
            this.pnControl.Controls.Add(this.btnBooksManage);
            this.pnControl.Controls.Add(this.btnTitleManage);
            this.pnControl.Location = new System.Drawing.Point(64, 13);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(748, 358);
            this.pnControl.TabIndex = 12;
            // 
            // lbBooksManage
            // 
            this.lbBooksManage.AutoSize = true;
            this.lbBooksManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBooksManage.Location = new System.Drawing.Point(451, 305);
            this.lbBooksManage.Name = "lbBooksManage";
            this.lbBooksManage.Size = new System.Drawing.Size(165, 25);
            this.lbBooksManage.TabIndex = 7;
            this.lbBooksManage.Text = "QUẢN LÍ SÁCH";
            // 
            // lbTitleManage
            // 
            this.lbTitleManage.AutoSize = true;
            this.lbTitleManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleManage.Location = new System.Drawing.Point(119, 305);
            this.lbTitleManage.Name = "lbTitleManage";
            this.lbTitleManage.Size = new System.Drawing.Size(216, 25);
            this.lbTitleManage.TabIndex = 6;
            this.lbTitleManage.Text = "QUẢN LÍ ĐẦU SÁCH";
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.pictureBox3);
            this.pnFooter.Controls.Add(this.pictureBox2);
            this.pnFooter.Controls.Add(this.pictureBox1);
            this.pnFooter.Controls.Add(this.lbContact);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 477);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(882, 82);
            this.pnFooter.TabIndex = 13;
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.Location = new System.Drawing.Point(594, 45);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(90, 25);
            this.lbContact.TabIndex = 17;
            this.lbContact.Text = "Liên hệ:";
            // 
            // btnBooksManage
            // 
            this.btnBooksManage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBooksManage.BackgroundImage = global::Library_Management.Properties.Resources.studying;
            this.btnBooksManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBooksManage.Location = new System.Drawing.Point(418, 108);
            this.btnBooksManage.Name = "btnBooksManage";
            this.btnBooksManage.Size = new System.Drawing.Size(211, 145);
            this.btnBooksManage.TabIndex = 5;
            this.btnBooksManage.UseVisualStyleBackColor = false;
            this.btnBooksManage.Click += new System.EventHandler(this.btnBooksManage_Click);
            // 
            // btnTitleManage
            // 
            this.btnTitleManage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTitleManage.BackgroundImage = global::Library_Management.Properties.Resources.title;
            this.btnTitleManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTitleManage.Location = new System.Drawing.Point(126, 108);
            this.btnTitleManage.Name = "btnTitleManage";
            this.btnTitleManage.Size = new System.Drawing.Size(209, 145);
            this.btnTitleManage.TabIndex = 4;
            this.btnTitleManage.UseVisualStyleBackColor = false;
            this.btnTitleManage.Click += new System.EventHandler(this.btnTitleManage_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Library_Management.Properties.Resources.facebook;
            this.pictureBox3.Location = new System.Drawing.Point(820, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Management.Properties.Resources.linkedin;
            this.pictureBox2.Location = new System.Drawing.Point(762, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.github;
            this.pictureBox1.Location = new System.Drawing.Point(702, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 559);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.pnFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuBooks";
            this.Text = "frmMenuBooks";
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            this.pnFooter.ResumeLayout(false);
            this.pnFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Label lbBooksManage;
        private System.Windows.Forms.Label lbTitleManage;
        private System.Windows.Forms.Button btnBooksManage;
        private System.Windows.Forms.Button btnTitleManage;
        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbContact;
    }
}