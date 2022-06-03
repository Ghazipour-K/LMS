namespace Library
{
    partial class FrmEditMember
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
            this.txtEnteredMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtRegDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNO = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateMemberInfo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.txtEnteredMemberID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(579, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود اطلاعات جستجو";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMsg.Location = new System.Drawing.Point(51, 29);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 3;
            // 
            // txtEnteredMemberID
            // 
            this.txtEnteredMemberID.Location = new System.Drawing.Point(258, 27);
            this.txtEnteredMemberID.Name = "txtEnteredMemberID";
            this.txtEnteredMemberID.Size = new System.Drawing.Size(122, 20);
            this.txtEnteredMemberID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد عضویت :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(471, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtRegDate
            // 
            this.dtRegDate.CustomFormat = "";
            this.dtRegDate.Location = new System.Drawing.Point(265, 164);
            this.dtRegDate.Name = "dtRegDate";
            this.dtRegDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtRegDate.Size = new System.Drawing.Size(200, 20);
            this.dtRegDate.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = " تاریخ ثبت نام :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(19, 190);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(446, 20);
            this.txtAddress.TabIndex = 13;
            // 
            // txtContactNO
            // 
            this.txtContactNO.Location = new System.Drawing.Point(365, 140);
            this.txtContactNO.Name = "txtContactNO";
            this.txtContactNO.Size = new System.Drawing.Size(100, 20);
            this.txtContactNO.TabIndex = 12;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(365, 114);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(100, 20);
            this.txtMemberID.TabIndex = 11;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(287, 88);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(178, 20);
            this.txtFatherName.TabIndex = 10;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(287, 62);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(178, 20);
            this.txtLName.TabIndex = 9;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(287, 38);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(178, 20);
            this.txtFname.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "شماره تماس :";
            // 
            // btnUpdateMemberInfo
            // 
            this.btnUpdateMemberInfo.Location = new System.Drawing.Point(483, 324);
            this.btnUpdateMemberInfo.Name = "btnUpdateMemberInfo";
            this.btnUpdateMemberInfo.Size = new System.Drawing.Size(88, 23);
            this.btnUpdateMemberInfo.TabIndex = 6;
            this.btnUpdateMemberInfo.Text = "ثبت اطلاعات";
            this.btnUpdateMemberInfo.UseVisualStyleBackColor = true;
            this.btnUpdateMemberInfo.Click += new System.EventHandler(this.btnUpdateMemberInfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "آدرس :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "کد عضویت :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "نام پدر :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtRegDate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtContactNO);
            this.groupBox2.Controls.Add(this.txtMemberID);
            this.groupBox2.Controls.Add(this.txtFatherName);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.txtFname);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(579, 228);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تغییر اطلاعات عضو";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "نام :";
            // 
            // FrmEditMember
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 355);
            this.Controls.Add(this.btnUpdateMemberInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmEditMember";
            this.Text = "ویرایش اطلاعات اعضا";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEnteredMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtRegDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNO;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateMemberInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMsg;
    }
}