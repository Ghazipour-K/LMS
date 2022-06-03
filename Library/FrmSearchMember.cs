using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    public partial class FrmSearchMember : Form
    {
        public FrmSearchMember()
        {
            InitializeComponent();
        }

        private void FrmSearchMember_Load(object sender, EventArgs e)
        {
            Member M = new Member("tblMember");
            lstMember.DataSource = M.List().Tables["tblMember"].DefaultView;
        }

        private void btnIDSearch_Click(object sender, EventArgs e)
        {
            string MemberID = txtMemberID.Text.Trim();
            if (MemberID != "")
            {
                Member M = new Member("tblMember");
                lstMember.DataSource = M.FindByField("MemberID", MemberID).Tables["tblMember"].DefaultView;
            }
        }

        private void btnAdvSearch_Click(object sender, EventArgs e)
        {
            string FName, LName, RegDate;
            FName = txtMemberFName.Text.Trim();
            LName = txtMemberLname.Text.Trim();
            RegDate = dtMemberRegDate.Value.ToShortDateString();
            string strCnn = "Data Source=Kiumars-PC; Initial Catalog=Library; Integrated Security=True";
            SqlConnection LibraryCnn = new SqlConnection(strCnn);
            string strSelect = "SELECT * FROM tblMember WHERE [FName] Like '" + FName + "' OR [LName] Like '" + LName + "' OR [RegDate] Like '" + RegDate + "'";
            LibraryCnn.Open();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect, strCnn);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, "tblMember");
            lstMember.DataSource = DataSet.Tables["tblMember"].DefaultView;
        }
    }
}
