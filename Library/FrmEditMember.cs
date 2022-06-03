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
    public partial class FrmEditMember : Form
    {
        public FrmEditMember()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string MemberID;
            Member M = new Member("tblMember");
            MemberID = txtEnteredMemberID.Text.Trim();
            if (MemberID != "" && M.Find(MemberID))
            {
                lblMsg.Text = "";
                txtFname.Text = M.GetRowOf("MemberID", MemberID).GetValue(1).ToString();
                txtLName.Text = M.GetRowOf("MemberID", MemberID).GetValue(2).ToString();
                txtFatherName.Text = M.GetRowOf("MemberID", MemberID).GetValue(3).ToString();
                txtMemberID.Text = M.GetRowOf("MemberID", MemberID).GetValue(0).ToString();
                txtContactNO.Text = M.GetRowOf("MemberID", MemberID).GetValue(6).ToString();
                txtAddress.Text = M.GetRowOf("MemberID", MemberID).GetValue(7).ToString();
            }
            else
                lblMsg.Text = "کاربری با کد وارد شده موجود نیست";
        }

        private void btnUpdateMemberInfo_Click(object sender, EventArgs e)
        {
            DateTime RegDate;
            Member M = new Member("tblMember");
            M.Fname = txtFname.Text.Trim();
            M.Lname = txtLName.Text.Trim();
            M.FatherName = txtFatherName.Text.Trim();
            M.ContactNO = txtContactNO.Text.Trim();
            M.MemberID = txtMemberID.Text.Trim();
            M.Address = txtAddress.Text.Trim();
            RegDate = dtRegDate.Value;
            M.RegDate = RegDate.ToShortDateString();
            M.ExpDate = RegDate.AddYears(2).ToShortDateString();
            if (M.Fname == "" || M.Lname == "" || M.FatherName == "" || M.ContactNO == "" || M.Address == "")
                lblMsg.Text = "تمامی اطلاعات را وارد کنید";
            else
            if (M.UpdateInfo()) lblMsg.Text = "بروز رسانی اطلاعات با موفقیت انجام شد";
        }
    }
}
