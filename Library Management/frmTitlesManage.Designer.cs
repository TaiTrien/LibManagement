﻿namespace Library_Management
{
    partial class frmTitlesManage
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
            this.dgvTitlesManage = new System.Windows.Forms.DataGridView();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbContact = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDel = new System.Windows.Forms.Label();
            this.lbAdd = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitlesManage)).BeginInit();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTitlesManage
            // 
            this.dgvTitlesManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitlesManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTitlesManage.Location = new System.Drawing.Point(0, 0);
            this.dgvTitlesManage.Name = "dgvTitlesManage";
            this.dgvTitlesManage.RowTemplate.Height = 24;
            this.dgvTitlesManage.Size = new System.Drawing.Size(882, 430);
            this.dgvTitlesManage.TabIndex = 0;
            // 
            // pnFooter
            // 
            this.pnFooter.Controls.Add(this.pictureBox3);
            this.pnFooter.Controls.Add(this.pictureBox2);
            this.pnFooter.Controls.Add(this.pictureBox1);
            this.pnFooter.Controls.Add(this.lbContact);
            this.pnFooter.Controls.Add(this.label2);
            this.pnFooter.Controls.Add(this.lbDel);
            this.pnFooter.Controls.Add(this.lbAdd);
            this.pnFooter.Controls.Add(this.btnMod);
            this.pnFooter.Controls.Add(this.btnDel);
            this.pnFooter.Controls.Add(this.btnAdd);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 451);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(882, 108);
            this.pnFooter.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Library_Management.Properties.Resources.facebook;
            this.pictureBox3.Location = new System.Drawing.Point(820, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_Management.Properties.Resources.linkedin;
            this.pictureBox2.Location = new System.Drawing.Point(762, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management.Properties.Resources.github;
            this.pictureBox1.Location = new System.Drawing.Point(702, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContact.Location = new System.Drawing.Point(594, 62);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(90, 25);
            this.lbContact.TabIndex = 17;
            this.lbContact.Text = "Liên hệ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sửa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDel
            // 
            this.lbDel.AutoSize = true;
            this.lbDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDel.Location = new System.Drawing.Point(85, 79);
            this.lbDel.Name = "lbDel";
            this.lbDel.Size = new System.Drawing.Size(48, 24);
            this.lbDel.TabIndex = 15;
            this.lbDel.Text = "Xóa";
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd.Location = new System.Drawing.Point(6, 80);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(64, 24);
            this.lbAdd.TabIndex = 14;
            this.lbAdd.Text = "Thêm";
            // 
            // btnMod
            // 
            this.btnMod.BackgroundImage = global::Library_Management.Properties.Resources.maintenance;
            this.btnMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Location = new System.Drawing.Point(143, 12);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(77, 61);
            this.btnMod.TabIndex = 13;
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.BackgroundImage = global::Library_Management.Properties.Resources.delete;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(77, 14);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(67, 59);
            this.btnDel.TabIndex = 12;
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Library_Management.Properties.Resources.book_add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(6, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 61);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmTitlesManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 559);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.dgvTitlesManage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTitlesManage";
            this.Text = "frmBooks";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitlesManage)).EndInit();
            this.pnFooter.ResumeLayout(false);
            this.pnFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTitlesManage;
        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDel;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
    }
}