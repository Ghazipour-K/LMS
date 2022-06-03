namespace Library
{
    partial class FrmSearchBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAdvSearch = new System.Windows.Forms.Button();
            this.lstbook = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnISBNSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoAvailabe = new System.Windows.Forms.RadioButton();
            this.rdoLend = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.btnDisplayAllBooks = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstbook)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.btnAdvSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(569, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجوی پیشرفته";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "مؤلف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "سال نشر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ناشر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "عنوان";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(242, 42);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(106, 20);
            this.txtAuthor.TabIndex = 6;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(130, 42);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(106, 20);
            this.txtPublisher.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(18, 42);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(106, 20);
            this.txtYear.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(354, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(106, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // btnAdvSearch
            // 
            this.btnAdvSearch.Location = new System.Drawing.Point(469, 23);
            this.btnAdvSearch.Name = "btnAdvSearch";
            this.btnAdvSearch.Size = new System.Drawing.Size(89, 42);
            this.btnAdvSearch.TabIndex = 0;
            this.btnAdvSearch.Text = "جستجو";
            this.btnAdvSearch.UseVisualStyleBackColor = true;
            this.btnAdvSearch.Click += new System.EventHandler(this.btnAdvSearch_Click);
            // 
            // lstbook
            // 
            this.lstbook.AllowUserToAddRows = false;
            this.lstbook.AllowUserToDeleteRows = false;
            this.lstbook.AllowUserToOrderColumns = true;
            this.lstbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstbook.Location = new System.Drawing.Point(12, 145);
            this.lstbook.Name = "lstbook";
            this.lstbook.ReadOnly = true;
            this.lstbook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstbook.Size = new System.Drawing.Size(811, 311);
            this.lstbook.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnISBNSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtISBN);
            this.groupBox2.Location = new System.Drawing.Point(587, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(236, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجوی ساده";
            // 
            // btnISBNSearch
            // 
            this.btnISBNSearch.Location = new System.Drawing.Point(137, 20);
            this.btnISBNSearch.Name = "btnISBNSearch";
            this.btnISBNSearch.Size = new System.Drawing.Size(85, 45);
            this.btnISBNSearch.TabIndex = 14;
            this.btnISBNSearch.Text = "جستجو";
            this.btnISBNSearch.UseVisualStyleBackColor = true;
            this.btnISBNSearch.Click += new System.EventHandler(this.btnISBNSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "شابک";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(17, 42);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(114, 20);
            this.txtISBN.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoAvailabe);
            this.groupBox3.Controls.Add(this.rdoLend);
            this.groupBox3.Controls.Add(this.rdoAll);
            this.groupBox3.Location = new System.Drawing.Point(411, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(412, 49);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "محدوده ی جستجو را انتخاب کنید";
            // 
            // rdoAvailabe
            // 
            this.rdoAvailabe.AutoSize = true;
            this.rdoAvailabe.Location = new System.Drawing.Point(39, 19);
            this.rdoAvailabe.Name = "rdoAvailabe";
            this.rdoAvailabe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoAvailabe.Size = new System.Drawing.Size(112, 17);
            this.rdoAvailabe.TabIndex = 9;
            this.rdoAvailabe.Text = "کتابهای در دسترس";
            this.rdoAvailabe.UseVisualStyleBackColor = true;
            this.rdoAvailabe.CheckedChanged += new System.EventHandler(this.rdoAvailabe_CheckedChanged);
            // 
            // rdoLend
            // 
            this.rdoLend.AutoSize = true;
            this.rdoLend.Location = new System.Drawing.Point(169, 19);
            this.rdoLend.Name = "rdoLend";
            this.rdoLend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoLend.Size = new System.Drawing.Size(136, 17);
            this.rdoLend.TabIndex = 8;
            this.rdoLend.Tag = "b";
            this.rdoLend.Text = "کتابهای امانت داده شده";
            this.rdoLend.UseVisualStyleBackColor = true;
            this.rdoLend.CheckedChanged += new System.EventHandler(this.rdoLend_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(314, 19);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoAll.Size = new System.Drawing.Size(85, 17);
            this.rdoAll.TabIndex = 7;
            this.rdoAll.TabStop = true;
            this.rdoAll.Tag = "a";
            this.rdoAll.Text = "تمامی کتابها";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // btnDisplayAllBooks
            // 
            this.btnDisplayAllBooks.Location = new System.Drawing.Point(24, 96);
            this.btnDisplayAllBooks.Name = "btnDisplayAllBooks";
            this.btnDisplayAllBooks.Size = new System.Drawing.Size(375, 42);
            this.btnDisplayAllBooks.TabIndex = 11;
            this.btnDisplayAllBooks.Text = "نمایش فهرست کلیه ی کتاب ها";
            this.btnDisplayAllBooks.UseVisualStyleBackColor = true;
            this.btnDisplayAllBooks.Click += new System.EventHandler(this.btnDisplayAllBooks_Click);
            // 
            // FrmSearchBook
            // 
            this.AcceptButton = this.btnDisplayAllBooks;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 468);
            this.Controls.Add(this.btnDisplayAllBooks);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstbook);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSearchBook";
            this.Text = "جستجوی کتاب";
            this.Load += new System.EventHandler(this.FrmSearchBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstbook)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView lstbook;
        private System.Windows.Forms.Button btnAdvSearch;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnISBNSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoAvailabe;
        private System.Windows.Forms.RadioButton rdoLend;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.Button btnDisplayAllBooks;
    }
}