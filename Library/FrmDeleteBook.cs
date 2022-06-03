using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class FrmDeleteBook : Form
    {
        public FrmDeleteBook()
        {
            InitializeComponent();
        }

        private void FrmDeleteBook_Load(object sender, EventArgs e)
        {
            Book B = new Book("tblBook");
            lstBook.DataSource = B.List().Tables["tblBook"].DefaultView;
        }

        private void btnDeleteByID_Click(object sender, EventArgs e)
        {
            string BookID = txtBookID.Text.Trim();
            Consign C = new Consign("tblConsign");
            if (BookID != "")
            {
                if (MessageBox.Show("آیا مطمئن از حذف هستید؟", "تایید حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (!C.FindByField("BookID", BookID).HasRows)
                    {
                        Book B = new Book("tblBook");
                        if (B.Delete(BookID))
                        {
                            lblMsg.Text = "کتاب مورد نظر با موفقیت حذف شد";
                            lstBook.DataSource = B.List().Tables["tblBook"].DefaultView;
                        }
                        else
                            lblMsg.Text = " کتابی با کد  " + BookID + "  در سیستم موجود نیست  ";
                    }
                    else
                        lblMsg.Text = "خطا : در حال حاضر کتاب در فهرست امانات وجود دارد";
                }
            }
            else
                lblMsg.Text = "کد کتاب را وارد کنید";
            txtBookID.Focus();
            txtBookID.SelectAll();
        }
    }
}