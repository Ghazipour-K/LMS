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
    public partial class FrmDeleteMember : Form
    {
        public FrmDeleteMember()
        {
            InitializeComponent();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            string MemberID = txtMemberID.Text.Trim();
            Consign C = new Consign("tblConsign");
            if (MemberID != "")
            {
                if (MessageBox.Show("آیا مطمئن از حذف هستید؟", "تایید حذف", MessageBoxButtons.YesNo).ToString() == "Yes")
                {
                    if (!C.FindByField("MemberID", MemberID).HasRows)
                    {
                        Member M = new Member("tblMember");
                        if (M.Delete(MemberID))
                        {
                            lblMsg.Text = "کاربر مورد نظر با موفقیت حذف شد";
                            LstMember.DataSource = M.List().Tables["tblMember"].DefaultView;
                        }
                        else
                            lblMsg.Text = " کاربری با کد  " + MemberID + "  در سیستم موجود نیست  ";
                    }
                    else
                        lblMsg.Text = "خطا : در حال حاضر عضو در فهرست امانات وجود دارد";
                }
            }
            else
                lblMsg.Text = "کد عضو را وارد کنید";
            txtMemberID.Focus();
            txtMemberID.SelectAll();
        }

        private void FrmDeleteMember_Load(object sender, EventArgs e)
        {
            Member M = new Member("tblMember");
            LstMember.DataSource = M.List().Tables["tblMember"].DefaultView;
        }
    }
}
