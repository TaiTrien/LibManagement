namespace Library_Management
{
    partial class frmSearchBooks
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
            this.cbPublisher = new System.Windows.Forms.ComboBox();
            this.cbPublishYear = new System.Windows.Forms.ComboBox();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.cbAuth = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbBookName = new System.Windows.Forms.ComboBox();
            this.cbBookCode = new System.Windows.Forms.ComboBox();
            this.lbGoogle = new System.Windows.Forms.Label();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPublisher
            // 
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(328, 350);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(121, 24);
            this.cbPublisher.TabIndex = 18;
            this.cbPublisher.Text = "Nhà xuất bản";
            // 
            // cbPublishYear
            // 
            this.cbPublishYear.FormattingEnabled = true;
            this.cbPublishYear.Location = new System.Drawing.Point(328, 302);
            this.cbPublishYear.Name = "cbPublishYear";
            this.cbPublishYear.Size = new System.Drawing.Size(121, 24);
            this.cbPublishYear.TabIndex = 17;
            this.cbPublishYear.Text = "Năm xuất bản";
            // 
            // cbValue
            // 
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(568, 252);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(121, 24);
            this.cbValue.TabIndex = 16;
            this.cbValue.Text = "Trị giá";
            // 
            // cbAuth
            // 
            this.cbAuth.FormattingEnabled = true;
            this.cbAuth.Location = new System.Drawing.Point(328, 252);
            this.cbAuth.Name = "cbAuth";
            this.cbAuth.Size = new System.Drawing.Size(121, 24);
            this.cbAuth.TabIndex = 15;
            this.cbAuth.Text = "Tác giả";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(111, 350);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 24);
            this.cbCategory.TabIndex = 14;
            this.cbCategory.Text = "Thể loại";
            // 
            // cbBookName
            // 
            this.cbBookName.FormattingEnabled = true;
            this.cbBookName.Location = new System.Drawing.Point(111, 302);
            this.cbBookName.Name = "cbBookName";
            this.cbBookName.Size = new System.Drawing.Size(121, 24);
            this.cbBookName.TabIndex = 13;
            this.cbBookName.Text = "Tên sách";
            // 
            // cbBookCode
            // 
            this.cbBookCode.FormattingEnabled = true;
            this.cbBookCode.Location = new System.Drawing.Point(111, 252);
            this.cbBookCode.Name = "cbBookCode";
            this.cbBookCode.Size = new System.Drawing.Size(121, 24);
            this.cbBookCode.TabIndex = 12;
            this.cbBookCode.Text = "Mã sách";
            // 
            // lbGoogle
            // 
            this.lbGoogle.AutoSize = true;
            this.lbGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoogle.Location = new System.Drawing.Point(223, 77);
            this.lbGoogle.Name = "lbGoogle";
            this.lbGoogle.Size = new System.Drawing.Size(355, 44);
            this.lbGoogle.TabIndex = 11;
            this.lbGoogle.Text = "LIBRARY GOOGLE";
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchBar.Location = new System.Drawing.Point(111, 141);
            this.tbSearchBar.Multiline = true;
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(578, 55);
            this.tbSearchBar.TabIndex = 10;
            this.tbSearchBar.Text = "Tìm kiếm....";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.BackgroundImage = global::Library_Management.Properties.Resources.loupe;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(630, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 46);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // frmSearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbPublisher);
            this.Controls.Add(this.cbPublishYear);
            this.Controls.Add(this.cbValue);
            this.Controls.Add(this.cbAuth);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbBookName);
            this.Controls.Add(this.cbBookCode);
            this.Controls.Add(this.lbGoogle);
            this.Controls.Add(this.tbSearchBar);
            this.Name = "frmSearchBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbPublisher;
        private System.Windows.Forms.ComboBox cbPublishYear;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.ComboBox cbAuth;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbBookName;
        private System.Windows.Forms.ComboBox cbBookCode;
        private System.Windows.Forms.Label lbGoogle;
        private System.Windows.Forms.TextBox tbSearchBar;
    }
}