namespace Library
{
    partial class FrmEditBook
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
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtEnteredBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnUpdateBookInfo = new System.Windows.Forms.Button();
            this.dtYear = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtRegDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtImpression = new System.Windows.Forms.TextBox();
            this.txtPrintRun = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.txtEnteredBookID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearchBook);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(579, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود اطلاعات جستجو";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMsg.Location = new System.Drawing.Point(63, 30);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 3;
            // 
            // txtEnteredBookID
            // 
            this.txtEnteredBookID.Location = new System.Drawing.Point(281, 27);
            this.txtEnteredBookID.Name = "txtEnteredBookID";
            this.txtEnteredBookID.Size = new System.Drawing.Size(122, 20);
            this.txtEnteredBookID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد کتاب :";
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(466, 24);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(82, 23);
            this.btnSearchBook.TabIndex = 0;
            this.btnSearchBook.Text = "جستجو";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnUpdateBookInfo
            // 
            this.btnUpdateBookInfo.Location = new System.Drawing.Point(474, 359);
            this.btnUpdateBookInfo.Name = "btnUpdateBookInfo";
            this.btnUpdateBookInfo.Size = new System.Drawing.Size(88, 23);
            this.btnUpdateBookInfo.TabIndex = 2;
            this.btnUpdateBookInfo.Text = "ثبت تغییرات";
            this.btnUpdateBookInfo.UseVisualStyleBackColor = true;
            this.btnUpdateBookInfo.Click += new System.EventHandler(this.btnUpdateBookInfo_Click);
            // 
            // dtYear
            // 
            this.dtYear.CustomFormat = "";
            this.dtYear.Location = new System.Drawing.Point(237, 164);
            this.dtYear.Name = "dtYear";
            this.dtYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtYear.Size = new System.Drawing.Size(200, 20);
            this.dtYear.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(466, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "سال چاپ :";
            // 
            // dtRegDate
            // 
            this.dtRegDate.Location = new System.Drawing.Point(236, 242);
            this.dtRegDate.Name = "dtRegDate";
            this.dtRegDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtRegDate.Size = new System.Drawing.Size(200, 20);
            this.dtRegDate.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(466, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "تاریخ ثبت :";
            // 
            // txtISBN
            // 
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(337, 216);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(337, 190);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 13;
            // 
            // txtImpression
            // 
            this.txtImpression.Location = new System.Drawing.Point(337, 140);
            this.txtImpression.Name = "txtImpression";
            this.txtImpression.Size = new System.Drawing.Size(100, 20);
            this.txtImpression.TabIndex = 12;
            // 
            // txtPrintRun
            // 
            this.txtPrintRun.Location = new System.Drawing.Point(337, 114);
            this.txtPrintRun.Name = "txtPrintRun";
            this.txtPrintRun.Size = new System.Drawing.Size(100, 20);
            this.txtPrintRun.TabIndex = 11;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(259, 88);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(178, 20);
            this.txtPublisher.TabIndex = 10;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(259, 62);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(178, 20);
            this.txtAuthor.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(259, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(178, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(466, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "شابک :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(466, 193);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "قیمت :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(466, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "تیراژ :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(466, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "نوبت چاپ :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtYear);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.dtRegDate);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtISBN);
            this.groupBox4.Controls.Add(this.txtPrice);
            this.groupBox4.Controls.Add(this.txtImpression);
            this.groupBox4.Controls.Add(this.txtPrintRun);
            this.groupBox4.Controls.Add(this.txtPublisher);
            this.groupBox4.Controls.Add(this.txtAuthor);
            this.groupBox4.Controls.Add(this.txtTitle);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new System.Drawing.Point(8, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(579, 270);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "اطلاعات کتاب را وارد  کنید";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(466, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "ناشر :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(466, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "مؤلف :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(466, 38);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "عنوان کتاب :";
            // 
            // FrmEditBook
            // 
            this.AcceptButton = this.btnSearchBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 386);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnUpdateBookInfo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEditBook";
            this.Text = "ویرایش اطلاعات کتاب";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEnteredBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnUpdateBookInfo;
        private System.Windows.Forms.DateTimePicker dtYear;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtRegDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtImpression;
        private System.Windows.Forms.TextBox txtPrintRun;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblMsg;
    }
}