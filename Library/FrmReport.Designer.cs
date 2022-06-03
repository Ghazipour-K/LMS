namespace Library
{
    partial class FrmReport
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
            this.RdoIndebtedMembers = new System.Windows.Forms.RadioButton();
            this.RdoLend = new System.Windows.Forms.RadioButton();
            this.RdoAvailable = new System.Windows.Forms.RadioButton();
            this.lstbook = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstbook)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoIndebtedMembers);
            this.groupBox1.Controls.Add(this.RdoLend);
            this.groupBox1.Controls.Add(this.RdoAvailable);
            this.groupBox1.Location = new System.Drawing.Point(332, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(490, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "یکی از گزینه های زیر را برای مشاهده ی فهرست مربوطه انتخاب کنید";
            // 
            // RdoIndebtedMembers
            // 
            this.RdoIndebtedMembers.AutoSize = true;
            this.RdoIndebtedMembers.Location = new System.Drawing.Point(6, 28);
            this.RdoIndebtedMembers.Name = "RdoIndebtedMembers";
            this.RdoIndebtedMembers.Size = new System.Drawing.Size(148, 17);
            this.RdoIndebtedMembers.TabIndex = 3;
            this.RdoIndebtedMembers.Text = "اعضایی که کتاب گرفته اند";
            this.RdoIndebtedMembers.UseVisualStyleBackColor = true;
            this.RdoIndebtedMembers.CheckedChanged += new System.EventHandler(this.RdoIndebtedMembers_CheckedChanged);
            // 
            // RdoLend
            // 
            this.RdoLend.AutoSize = true;
            this.RdoLend.Location = new System.Drawing.Point(164, 28);
            this.RdoLend.Name = "RdoLend";
            this.RdoLend.Size = new System.Drawing.Size(175, 17);
            this.RdoLend.TabIndex = 1;
            this.RdoLend.Text = "مشاهده کتابهای امانت داده شده";
            this.RdoLend.UseVisualStyleBackColor = true;
            this.RdoLend.CheckedChanged += new System.EventHandler(this.RdoLend_CheckedChanged);
            // 
            // RdoAvailable
            // 
            this.RdoAvailable.AutoSize = true;
            this.RdoAvailable.Checked = true;
            this.RdoAvailable.Location = new System.Drawing.Point(345, 28);
            this.RdoAvailable.Name = "RdoAvailable";
            this.RdoAvailable.Size = new System.Drawing.Size(135, 17);
            this.RdoAvailable.TabIndex = 0;
            this.RdoAvailable.TabStop = true;
            this.RdoAvailable.Text = "مشاهده کتابهای موجود";
            this.RdoAvailable.UseVisualStyleBackColor = true;
            this.RdoAvailable.CheckedChanged += new System.EventHandler(this.RdoAvailable_CheckedChanged);
            // 
            // lstbook
            // 
            this.lstbook.AllowUserToAddRows = false;
            this.lstbook.AllowUserToDeleteRows = false;
            this.lstbook.AllowUserToOrderColumns = true;
            this.lstbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstbook.Location = new System.Drawing.Point(12, 79);
            this.lstbook.Name = "lstbook";
            this.lstbook.ReadOnly = true;
            this.lstbook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstbook.Size = new System.Drawing.Size(811, 336);
            this.lstbook.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMemberID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSeack);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(314, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "کتابهای امانت داده شده به یک عضو خاص";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(17, 25);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 20);
            this.txtMemberID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد عضویت :";
            // 
            // btnSeack
            // 
            this.btnSeack.Location = new System.Drawing.Point(191, 21);
            this.btnSeack.Name = "btnSeack";
            this.btnSeack.Size = new System.Drawing.Size(107, 30);
            this.btnSeack.TabIndex = 0;
            this.btnSeack.Text = "بررسی";
            this.btnSeack.UseVisualStyleBackColor = true;
            this.btnSeack.Click += new System.EventHandler(this.btnSeack_Click);
            // 
            // FrmReport
            // 
            this.AcceptButton = this.btnSeack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 422);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstbook);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReport";
            this.Text = "فرم گزارش گیری";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstbook)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView lstbook;
        private System.Windows.Forms.RadioButton RdoLend;
        private System.Windows.Forms.RadioButton RdoAvailable;
        private System.Windows.Forms.RadioButton RdoIndebtedMembers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeack;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label1;
    }
}