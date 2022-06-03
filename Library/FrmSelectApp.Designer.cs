namespace Library
{
    partial class FrmSelectApp
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
            this.btnMemberPart = new System.Windows.Forms.Button();
            this.btnAdminPart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdminPart);
            this.groupBox1.Controls.Add(this.btnMemberPart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(461, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "برای شروع یکی از زیر سیستم ها را انتخاب کنید";
            // 
            // btnMemberPart
            // 
            this.btnMemberPart.Location = new System.Drawing.Point(233, 19);
            this.btnMemberPart.Name = "btnMemberPart";
            this.btnMemberPart.Size = new System.Drawing.Size(222, 213);
            this.btnMemberPart.TabIndex = 0;
            this.btnMemberPart.Text = "ورود به بخش کاربر";
            this.btnMemberPart.UseVisualStyleBackColor = true;
            this.btnMemberPart.Click += new System.EventHandler(this.btnMemberPart_Click);
            // 
            // btnAdminPart
            // 
            this.btnAdminPart.Location = new System.Drawing.Point(6, 19);
            this.btnAdminPart.Name = "btnAdminPart";
            this.btnAdminPart.Size = new System.Drawing.Size(222, 213);
            this.btnAdminPart.TabIndex = 1;
            this.btnAdminPart.Text = "ورود به بخش کتابدار";
            this.btnAdminPart.UseVisualStyleBackColor = true;
            this.btnAdminPart.Click += new System.EventHandler(this.btnAdminPart_Click);
            // 
            // FrmSelectApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 262);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSelectApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم کتابخانه";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdminPart;
        private System.Windows.Forms.Button btnMemberPart;
    }
}