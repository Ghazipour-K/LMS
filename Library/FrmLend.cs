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
    public partial class FrmLend : Form
    {
        public FrmLend()
        {
            InitializeComponent();
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            if (dtStartDate.Value.CompareTo(dtEndDate.Value) == -1)
            {
                Consign C = new Consign("tblConsign");
                C.BookID = txtBookID.Text.Trim();
                C.MemberID = txtMemberID.Text.Trim();
                C.StartDate = dtStartDate.Value;
                C.EndDate = dtEndDate.Value;
                switch (C.Lend())
                {
                    case 0:
                        lblMsg.Text = "ثبت شد";
                        txtBookID.ResetText();
                        txtMemberID.ResetText();
                        dtStartDate.ResetText();
                        dtEndDate.ResetText();
                        break;
                    case 1:
                        lblMsg.Text = "کتاب قبلا امانت داده شده است";
                        break;
                    case 2:
                        lblMsg.Text = "کد کتاب معتبر نیست";
                        break;
                    case 3:
                        lblMsg.Text = "کد عضو معتبر نیست";
                        break;
                    case 4:
                        lblMsg.Text = "خطا در ثبت اطلاعات";
                        break;
                }
            }
            else lblMsg.Text = "تاریخ پایان باید از تاریخ شروع بزرگتر باشد";
        }

        private void FrmLend_Load(object sender, EventArgs e)
        {
            dtStartDate.Value = DateTime.Today;
            dtEndDate.Value = DateTime.Today;
        }

    }
}