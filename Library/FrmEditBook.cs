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
    public partial class FrmEditBook : Form
    {
        public FrmEditBook()
        {
            InitializeComponent();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string BookID;
            Book B = new Book("tblBook");
            BookID = txtEnteredBookID.Text.Trim();
            if (BookID != "" && B.Find(BookID))
            {
                lblMsg.Text = "";
                txtTitle.Text = B.GetRowOf("BookID", BookID).GetValue(0).ToString();
                txtAuthor.Text = B.GetRowOf("BookID", BookID).GetValue(1).ToString();
                txtImpression.Text = B.GetRowOf("BookID", BookID).GetValue(3).ToString();
                txtPrintRun.Text = B.GetRowOf("BookID", BookID).GetValue(4).ToString();
                txtPublisher.Text = B.GetRowOf("BookID", BookID).GetValue(5).ToString();
                txtPrice.Text = B.GetRowOf("BookID", BookID).GetValue(6).ToString();
                txtISBN.Text = B.GetRowOf("BookID", BookID).GetValue(7).ToString();
                txtTitle.Focus();
            }
            else
                lblMsg.Text = "کتابی با کد وارد شده موجود نیست";
            txtEnteredBookID.Focus();
            txtEnteredBookID.SelectAll();
        }

        private void btnUpdateBookInfo_Click(object sender, EventArgs e)
        {
            Book B = new Book("tblBook");
            try
            {
                B.BookID = txtEnteredBookID.Text.Trim();
                B.Title = txtTitle.Text.Trim();
                B.Year = dtYear.Value.Year.ToString();
                B.Author = txtAuthor.Text.Trim();
                B.Impression = Convert.ToInt32(txtImpression.Text.Trim());
                B.Price = (int)Convert.ToDouble(txtPrice.Text.Trim());
                B.PrintRun = Convert.ToInt32(txtPrintRun.Text.Trim());
                B.Publisher = txtPublisher.Text.Trim();
                B.RegDate = dtRegDate.Value.ToShortDateString();
                if (!B.UpdateInfo())
                    lblMsg.Text = "خطا در ثبت اطلاعات!";
                else
                {
                    lblMsg.Text = "اطلاعات با موفقیت ثبت شد";
                    txtEnteredBookID.ResetText();
                    txtEnteredBookID.Focus();
                }
            }
            catch { lblMsg.Text = "تمامی اطلاعات را وارد کنید"; }
        }

    }
}