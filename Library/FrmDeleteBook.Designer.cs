namespace Library
{
    partial class FrmDeleteBook
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
            this.lstBook = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.btnDeleteByID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBook
            // 
            this.lstBook.AllowUserToAddRows = false;
            this.lstBook.AllowUserToOrderColumns = true;
            this.lstBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstBook.Location = new System.Drawing.Point(12, 78);
            this.lstBook.Name = "lstBook";
            this.lstBook.ReadOnly = true;
            this.lstBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstBook.Size = new System.Drawing.Size(675, 261);
            this.lstBook.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.txtBookID);
            this.groupBox1.Controls.Add(this.btnDeleteByID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(674, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حذف با کد";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMsg.Location = new System.Drawing.Point(74, 27);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 2;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(382, 24);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(145, 20);
            this.txtBookID.TabIndex = 1;
            // 
            // btnDeleteByID
            // 
            this.btnDeleteByID.Location = new System.Drawing.Point(590, 22);
            this.btnDeleteByID.Name = "btnDeleteByID";
            this.btnDeleteByID.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteByID.TabIndex = 0;
            this.btnDeleteByID.Text = "حذف";
            this.btnDeleteByID.UseVisualStyleBackColor = true;
            this.btnDeleteByID.Click += new System.EventHandler(this.btnDeleteByID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "کد کتاب :";
            // 
            // FrmDeleteBook
            // 
            this.AcceptButton = this.btnDeleteByID;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDeleteBook";
            this.Text = "حذف کتاب";
            this.Load += new System.EventHandler(this.FrmDeleteBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lstBook;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Button btnDeleteByID;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impressionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printRunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
    }
}