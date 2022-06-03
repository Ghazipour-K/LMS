namespace Library
{
    partial class FrmSearchMember
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
            this.dtMemberRegDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberLname = new System.Windows.Forms.TextBox();
            this.txtMemberFName = new System.Windows.Forms.TextBox();
            this.btnAdvSearch = new System.Windows.Forms.Button();
            this.btnIDSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lstMember = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMember)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtMemberRegDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMemberLname);
            this.groupBox1.Controls.Add(this.txtMemberFName);
            this.groupBox1.Controls.Add(this.btnAdvSearch);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(569, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجوی پیشرفته";
            // 
            // dtMemberRegDate
            // 
            this.dtMemberRegDate.Location = new System.Drawing.Point(39, 42);
            this.dtMemberRegDate.Name = "dtMemberRegDate";
            this.dtMemberRegDate.Size = new System.Drawing.Size(200, 20);
            this.dtMemberRegDate.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "نام خانوادگی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "تاریخ ثبت نام";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "نام";
            // 
            // txtMemberLname
            // 
            this.txtMemberLname.Location = new System.Drawing.Point(245, 42);
            this.txtMemberLname.Name = "txtMemberLname";
            this.txtMemberLname.Size = new System.Drawing.Size(106, 20);
            this.txtMemberLname.TabIndex = 6;
            // 
            // txtMemberFName
            // 
            this.txtMemberFName.Location = new System.Drawing.Point(357, 42);
            this.txtMemberFName.Name = "txtMemberFName";
            this.txtMemberFName.Size = new System.Drawing.Size(106, 20);
            this.txtMemberFName.TabIndex = 1;
            // 
            // btnAdvSearch
            // 
            this.btnAdvSearch.Location = new System.Drawing.Point(472, 23);
            this.btnAdvSearch.Name = "btnAdvSearch";
            this.btnAdvSearch.Size = new System.Drawing.Size(89, 42);
            this.btnAdvSearch.TabIndex = 0;
            this.btnAdvSearch.Text = "جستجو";
            this.btnAdvSearch.UseVisualStyleBackColor = true;
            this.btnAdvSearch.Click += new System.EventHandler(this.btnAdvSearch_Click);
            // 
            // btnIDSearch
            // 
            this.btnIDSearch.Location = new System.Drawing.Point(140, 20);
            this.btnIDSearch.Name = "btnIDSearch";
            this.btnIDSearch.Size = new System.Drawing.Size(85, 45);
            this.btnIDSearch.TabIndex = 14;
            this.btnIDSearch.Text = "جستجو";
            this.btnIDSearch.UseVisualStyleBackColor = true;
            this.btnIDSearch.Click += new System.EventHandler(this.btnIDSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "کد عضویت :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIDSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMemberID);
            this.groupBox2.Location = new System.Drawing.Point(578, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(236, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجوی ساده";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(20, 42);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(114, 20);
            this.txtMemberID.TabIndex = 12;
            // 
            // lstMember
            // 
            this.lstMember.AllowUserToAddRows = false;
            this.lstMember.AllowUserToDeleteRows = false;
            this.lstMember.AllowUserToOrderColumns = true;
            this.lstMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstMember.Location = new System.Drawing.Point(3, 93);
            this.lstMember.Name = "lstMember";
            this.lstMember.ReadOnly = true;
            this.lstMember.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstMember.Size = new System.Drawing.Size(811, 323);
            this.lstMember.TabIndex = 4;
            // 
            // FrmSearchMember
            // 
            this.AcceptButton = this.btnIDSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSearchMember";
            this.Text = "جستجوی اعضا";
            this.Load += new System.EventHandler(this.FrmSearchMember_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberLname;
        private System.Windows.Forms.TextBox txtMemberFName;
        private System.Windows.Forms.Button btnAdvSearch;
        private System.Windows.Forms.Button btnIDSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.DataGridView lstMember;
        private System.Windows.Forms.DateTimePicker dtMemberRegDate;
    }
}