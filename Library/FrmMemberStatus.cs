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
    public partial class FrmMemberStatus : Form
    {
        public FrmMemberStatus()
        {
            InitializeComponent();
        }

        private void FrmMemberStatus_Load(object sender, EventArgs e)
        {
            Consign C = new Consign("tblConsign");
            lblMemberCode.Text = FrmMemberLogin.MemberInfo[0].ToString();
            txtfname.Text = FrmMemberLogin.MemberInfo[1].ToString();
            txtlname.Text = FrmMemberLogin.MemberInfo[2].ToString();
            txtRegDate.Text = FrmMemberLogin.MemberInfo[4].ToString();
            txtExpire.Text = FrmMemberLogin.MemberInfo[5].ToString();
            DateTime tStart = Convert.ToDateTime(FrmMemberLogin.MemberInfo[4]);
            DateTime tEnd = Convert.ToDateTime(FrmMemberLogin.MemberInfo[5]);
            txtActivityDays.Text = DateTime.Now.Date.Subtract(tStart).TotalDays.ToString();
            txtRemainedDays.Text = tEnd.Subtract(DateTime.Now.Date).TotalDays.ToString();
            lstReceivedBooks.DataSource = C.IndebtedMember(FrmMemberLogin.MemberInfo[0].ToString()).Tables[0].DefaultView;
        }
    }
}
