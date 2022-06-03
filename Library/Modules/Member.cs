using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
 //Customer Class
    class Member
    {
        private string strCnn = "";
        private string strtblName = "";
        private SqlConnection LibraryCnn;

        private string _MemberID = "";
        private string _Fname = "";
        private string _Lname = "";
        private string _FatherName = "";
        private string _RegDate;
        private string _ExpDate;
        private string _ContactNO = "";
        private string _Address = "";

        public string MemberID { get { return _MemberID; } set { _MemberID = value.ToString(); } }
        public string Fname { get { return _Fname; } set { _Fname = value.ToString(); } }
        public string Lname { get { return _Lname; } set { _Lname = value.ToString(); } }
        public string FatherName { get { return _FatherName; } set { _FatherName = value.ToString(); } }
        public string RegDate { get { return _RegDate; } set { _RegDate = value.ToString(); } }
        public string ExpDate { get { return _ExpDate; } set { _ExpDate = value.ToString(); } }
        public string ContactNO { get { return _ContactNO; } set { _ContactNO = value.ToString(); } }
        public string Address { get { return _Address; } set { _Address = value.ToString(); } }

        public Member(string MemberTblName)
        {
            strCnn = "Data Source=Kiumars-PC; Initial Catalog=Library; Integrated Security=True";
            strtblName = MemberTblName;
            LibraryCnn = new SqlConnection(strCnn);
        }

        ~Member() { }

        public bool Login(string strID, string strPassword)
        {
            bool Status;
            string strSelect = "SELECT [UID] FROM " + strtblName + " WHERE [UID] = '" + strID + "'";
            strSelect += " WHERE [UID] = '" + strID + "' AND [PWD] = '" + strPassword + "'";
            LibraryCnn.Open();
            SqlCommand CmdSelect = new SqlCommand(strSelect, LibraryCnn);
            SqlDataReader CustomerReader = CmdSelect.ExecuteReader();
            Status = CustomerReader.HasRows;
            LibraryCnn.Close();
            return Status;
        }

        public bool ChangePassword(string strID, string strOldPass, string strNewPass)
        {
            bool Status;
            string strSelect = "UPDATE " + strtblName + " SET [PWD] = '" + strNewPass;
            strSelect += "' WHERE [UID] = '" + strID + "'AND [PWD] = '" + strOldPass + "'";
            LibraryCnn.Open();
            SqlCommand CmdSelect = new SqlCommand(strSelect, LibraryCnn);
            SqlDataReader CustomerReader = CmdSelect.ExecuteReader();
            Status = Convert.ToBoolean(CustomerReader.RecordsAffected);
            LibraryCnn.Close();
            return Status;
        }

        private bool InfoIsCorrect()
        {
            return (!Find(MemberID));
        }

        public bool Save()
        {
            bool Status = false;
            if (InfoIsCorrect())
            {                
                string strInsert = "INSERT INTO " + strtblName + " VALUES('" + _MemberID + "','" + _Fname + "','";
                strInsert += _Lname + "','" + _FatherName + "','" + _RegDate + "','" + _ExpDate + "','";
                strInsert += _ContactNO + "','" + _Address + "')";
                LibraryCnn.Open();
                SqlCommand CmdInsert = new SqlCommand(strInsert, LibraryCnn);
                SqlDataReader MemberReader = CmdInsert.ExecuteReader();
                Status = Convert.ToBoolean(MemberReader.RecordsAffected);
                LibraryCnn.Close();
            }
            return Status;
        }

        public bool Delete(string strID)
        {
            bool Status;
            string strSelect = "DELETE FROM " + strtblName + " WHERE [MemberID] = '" + strID + "'";
            LibraryCnn.Open();
            SqlCommand CmdSelect = new SqlCommand(strSelect, LibraryCnn);                        
            SqlDataReader MemberReader = CmdSelect.ExecuteReader();
            Status = Convert.ToBoolean(MemberReader.RecordsAffected);
            LibraryCnn.Close();
            return Status;
        }
        
        public bool UpdateInfo()
        {
            bool Status = true;
            string strCmdUpdate = "UPDATE " + strtblName + " SET Fname=@_Fname, Lname=@_Lname, ";
            strCmdUpdate += "FatherName=@_FatherName, RegDate=@_RegDate, ExpDate=@_ExpDate, ";
            strCmdUpdate += "ContactNo=@_ContactNo, Address=@_Address WHERE [MemberID]=@_MemberID";
            LibraryCnn.Open();
            SqlCommand CmdUpdate = new SqlCommand(strCmdUpdate, LibraryCnn);
            CmdUpdate.Parameters.AddWithValue("@_MemberID", _MemberID);
            CmdUpdate.Parameters.AddWithValue("@_Fname", _Fname);
            CmdUpdate.Parameters.AddWithValue("@_Lname", _Lname);
            CmdUpdate.Parameters.AddWithValue("@_FatherName", _FatherName);
            CmdUpdate.Parameters.AddWithValue("@_RegDate", _RegDate);
            CmdUpdate.Parameters.AddWithValue("@_ExpDate", _ExpDate);
            CmdUpdate.Parameters.AddWithValue("@_ContactNO", _ContactNO);
            CmdUpdate.Parameters.AddWithValue("@_Address", _Address);
            SqlDataReader UpdateReader = CmdUpdate.ExecuteReader();           
            Status = Convert.ToBoolean(UpdateReader.RecordsAffected);
            LibraryCnn.Close();
            return Status;
        }

        public DataSet FindByField(string FieldName, string ValueToSearch)
        {
            string strSelect = "SELECT * FROM " + strtblName + " WHERE [" + FieldName + "] = '" + ValueToSearch + "'";
            LibraryCnn.Open();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect, strCnn);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, strtblName);
            return DataSet;
        }

        public SqlDataReader GetRowOf(string FieldName, string ValueToSearch)
        {
            string strSelect = "SELECT * FROM " + strtblName + " WHERE [" + FieldName + "] = '" + ValueToSearch + "'";
            LibraryCnn.Close();
            LibraryCnn.Open();
            SqlCommand CmdSelect = new SqlCommand(strSelect, LibraryCnn);
            SqlDataReader BookReader = CmdSelect.ExecuteReader();
            BookReader.Read();
            return BookReader;
        }
        
        public bool Find(string strID)
        {
            bool Status;
            string strSelect = "SELECT [MemberID] FROM " + strtblName + " WHERE [MemberID] = '" + strID + "'";
            LibraryCnn.Open();
            SqlCommand CmdSelect = new SqlCommand(strSelect, LibraryCnn);
            SqlDataReader CustomerReader = CmdSelect.ExecuteReader();
            Status = CustomerReader.HasRows;
            LibraryCnn.Close();
            return Status;
        }
        
        public DataSet List()
        {
            string strSelect = "SELECT * FROM " + strtblName;
            LibraryCnn.Open();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect, strCnn);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, strtblName);
            return DataSet;
        }
    }
}