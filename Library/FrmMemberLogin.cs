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
    public partial class FrmMemberLogin : Form
    {
        static public bool LogedIn = false;
        static public object[] MemberInfo = new object[8];
        public FrmMemberLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUID = txtUID.Text.Trim();
            Member M = new Member("tblMember");
            if (strUID == "")
            {
                lblMsg.Text = "کد عضویت را وارد کنید";
                txtUID.Focus();
            }
            else if (M.Find(strUID))
            {
                LogedIn = true;
                M.GetRowOf("MemberID", strUID).GetValues(MemberInfo);
                this.Close();
            }
            else
            {
                lblMsg.Text = "کد عضویت معتبر نیست";
                txtUID.Focus();
                txtUID.SelectAll();
            }
        }
    }
}
