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
    public partial class FrmRegisterMember : Form
    {
        public FrmRegisterMember()
        {
            InitializeComponent();
        }

        private void btnRegisterBook_Click(object sender, EventArgs e)
        {
            DateTime RegDate;
            Member M = new Member("tblMember");
            M.Fname = txtFName.Text.Trim();
            M.Lname = txtLName.Text.Trim();
            M.FatherName = txtFatherName.Text.Trim();
            M.ContactNO = txtContact.Text.Trim();
            M.MemberID = txtMemberID.Text.Trim();
            M.Address = txtAddress.Text.Trim();
            RegDate = dtRegDate.Value;
            M.RegDate = RegDate.ToShortDateString();
            M.ExpDate = RegDate.AddYears(2).ToShortDateString();

            if (M.Fname == "" || M.Lname == "" || M.FatherName == "" || M.ContactNO == "" || M.MemberID == "" || M.Address == "")
                lblMsg.Text = "تمامی اطلاعات را وارد کنید";
            else 
                if (!M.Save()) lblMsg.Text = "کد کاربری تکراری است";
                else { lblMsg.Text = "اطلاعات با موفقیت ثبت شد"; btnResetFrom.PerformClick(); txtFName.Focus(); }
        }

        private void btnResetFrom_Click(object sender, EventArgs e)
        {
            txtFName.ResetText();
            txtLName.ResetText();
            txtFatherName.ResetText();
            txtMemberID.ResetText();
            txtContact.ResetText();
            dtRegDate.ResetText();
            txtAddress.ResetText();
            txtFName.Focus();
        }
    }
}