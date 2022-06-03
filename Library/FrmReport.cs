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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            Consign C=new Consign("tblConsign");
            lstbook.DataSource = C.AvailableBooks().Tables[0].DefaultView;
        }

        private void RdoAvailable_CheckedChanged(object sender, EventArgs e)
        {
            Consign C = new Consign("tblConsign");
            lstbook.DataSource = C.AvailableBooks().Tables[0].DefaultView;
        }

        private void RdoLend_CheckedChanged(object sender, EventArgs e)
        {
            Consign C = new Consign("tblConsign");
            lstbook.DataSource = C.LendBooks().Tables[0].DefaultView;
        }

        private void RdoIndebtedMembers_CheckedChanged(object sender, EventArgs e)
        {
            Consign C = new Consign("tblConsign");
            lstbook.DataSource = C.IndebtedMembers().Tables[0].DefaultView;
        }

        private void btnSeack_Click(object sender, EventArgs e)
        {
            string MemberID = txtMemberID.Text.Trim();
            if (MemberID != "")
            {
                Consign C = new Consign("tblConsign");
                lstbook.DataSource = C.IndebtedMember(MemberID).Tables[0].DefaultView;
            }
        }
    }
}
