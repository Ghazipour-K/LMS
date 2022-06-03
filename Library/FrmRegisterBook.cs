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
    public partial class FrmRegisterBook : Form
    {
        public FrmRegisterBook()
        {
            InitializeComponent();
        }

        private void btnResetFrom_Click(object sender, EventArgs e)
        {
            txtAuthor.ResetText();
            txtBookID.ResetText();
            txtISBN.ResetText();
            txtPrice.ResetText();
            txtPrintRun.ResetText();
            txtPublisher.ResetText();
            txtTitle.ResetText();
            txtImpression.ResetText();
        }

        private void btnRegisterBook_Click(object sender, EventArgs e)
        {
            Book B = new Book("tblBook");
            try
            {
                B.Title = txtTitle.Text.Trim();
                B.Year = dtYear.Value.Year.ToString();
                B.Author = txtAuthor.Text.Trim();
                B.BookID = txtBookID.Text.Trim();
                B.Impression = Convert.ToInt32(txtImpression.Text.Trim());
                B.ISBN = txtISBN.Text.Trim();
                B.Price = Convert.ToInt32(txtPrice.Text.Trim());
                B.PrintRun = Convert.ToInt32(txtPrintRun.Text.Trim());
                B.Publisher = txtPublisher.Text.Trim();
                B.RegDate = dtRegDate.Value.ToShortDateString();
                if (!B.Save()) lblMsg.Text = "کد کتاب تکراری است";
                else
                {
                    lblMsg.Text = "اطلاعات با موفقیت ثبت شد";
                    btnResetFrom.PerformClick();
                    txtTitle.Focus();
                }
            }
            catch { lblMsg.Text = "تمامی اطلاعات را وارد کنید"; }
        }
    }
}
