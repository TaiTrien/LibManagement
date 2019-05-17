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
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.lbGoogle = new System.Windows.Forms.Label();
            this.cbBookCode = new System.Windows.Forms.ComboBox();
            this.cbBookName = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbAuth = new System.Windows.Forms.ComboBox();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.cbPublishYear = new System.Windows.Forms.ComboBox();
            this.cbPublisher = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchBar.Location = new System.Drawing.Point(91, 156);
            this.tbSearchBar.Multiline = true;
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(578, 64);
            this.tbSearchBar.TabIndex = 0;
            this.tbSearchBar.Text = "Searching....";
            // 
            // lbGoogle
            // 
            this.lbGoogle.AutoSize = true;
            this.lbGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoogle.Location = new System.Drawing.Point(203, 108);
            this.lbGoogle.Name = "lbGoogle";
            this.lbGoogle.Size = new System.Drawing.Size(355, 44);
            this.lbGoogle.TabIndex = 1;
            this.lbGoogle.Text = "LIBRARY GOOGLE";
            // 
            // cbBookCode
            // 
            this.cbBookCode.FormattingEnabled = true;
            this.cbBookCode.Location = new System.Drawing.Point(91, 251);
            this.cbBookCode.Name = "cbBookCode";
            this.cbBookCode.Size = new System.Drawing.Size(121, 24);
            this.cbBookCode.TabIndex = 2;
            this.cbBookCode.Text = "Mã sách";
            // 
            // cbBookName
            // 
            this.cbBookName.FormattingEnabled = true;
            this.cbBookName.Location = new System.Drawing.Point(91, 301);
            this.cbBookName.Name = "cbBookName";
            this.cbBookName.Size = new System.Drawing.Size(121, 24);
            this.cbBookName.TabIndex = 3;
            this.cbBookName.Text = "Tên sách";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(91, 349);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 24);
            this.cbCategory.TabIndex = 4;
            this.cbCategory.Text = "Thể loại";
            // 
            // cbAuth
            // 
            this.cbAuth.FormattingEnabled = true;
            this.cbAuth.Location = new System.Drawing.Point(308, 251);
            this.cbAuth.Name = "cbAuth";
            this.cbAuth.Size = new System.Drawing.Size(121, 24);
            this.cbAuth.TabIndex = 5;
            this.cbAuth.Text = "Tác giả";
            // 
            // cbValue
            // 
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(548, 251);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(121, 24);
            this.cbValue.TabIndex = 6;
            this.cbValue.Text = "Trị giá";
            // 
            // cbPublishYear
            // 
            this.cbPublishYear.FormattingEnabled = true;
            this.cbPublishYear.Location = new System.Drawing.Point(308, 301);
            this.cbPublishYear.Name = "cbPublishYear";
            this.cbPublishYear.Size = new System.Drawing.Size(121, 24);
            this.cbPublishYear.TabIndex = 7;
            this.cbPublishYear.Text = "Năm xuất bản";
            // 
            // cbPublisher
            // 
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(308, 349);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(121, 24);
            this.cbPublisher.TabIndex = 8;
            this.cbPublisher.Text = "Nhà xuất bản";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.BackgroundImage = global::Library_Management.Properties.Resources.loupe;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(607, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 46);
            this.btnSearch.TabIndex = 9;
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

        private System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.Label lbGoogle;
        private System.Windows.Forms.ComboBox cbBookCode;
        private System.Windows.Forms.ComboBox cbBookName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbAuth;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.ComboBox cbPublishYear;
        private System.Windows.Forms.ComboBox cbPublisher;
        private System.Windows.Forms.Button btnSearch;
    }
}