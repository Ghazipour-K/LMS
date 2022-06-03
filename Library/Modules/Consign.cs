using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    class Consign
    {
        private string _BookID = "";
        private string _MemberID = "";
        private DateTime _StartDate;
        private DateTime _EndDate;
        private int _Delay = 0;

        private SqlConnection LibraryCnn;
        private string strCnn = "";
        private string strtblName = "";

        public string BookID { get { return _BookID; } set { _BookID = value; } }
        public string MemberID { get { return _MemberID; } set { _MemberID = value; } }
        public DateTime StartDate { get { return _StartDate; } set { _StartDate = value; } }
        public DateTime EndDate { get { return _EndDate; } set { _EndDate = value; } }
        public int Delay { get { return _Delay; } }

        public Consign(string ConsignTblName)
        {
            strCnn = "Data Source=Kiumars-PC; Initial Catalog=Library; Integrated Security=True";
            strtblName = ConsignTblName;
            LibraryCnn = new SqlConnection(strCnn);
        }

        public bool Find(string strID)
        {
            bool Status;
            string strSelect = "SELECT [BookID] FROM " + strtblName + " WHERE [BookID] = '" + strID + "'";
            LibraryCnn.Open();
            SqlCommand CmdSelect = new SqlCommand(strSelect, LibraryCnn);
            SqlDataReader ConsignReader = CmdSelect.ExecuteReader();
            Status = ConsignReader.HasRows;
            LibraryCnn.Close();
            return Status;
        }

        public int Lend()
        {
            int Status = 0;
            if (this.Find(_BookID)) Status = 1;
            else
            {
                Book B = new Book("tblBook");
                if (!B.Find(_BookID)) Status = 2;
                else
                {
                    Member M = new Member("tblMember");
                    if (!M.Find(_MemberID)) Status = 3;
                    else
                    {
                        string strInsert = "INSERT INTO " + strtblName + " VALUES('" + _BookID + "','" + _MemberID + "','";
                        strInsert += _StartDate + "','" + _EndDate + "')";
                        LibraryCnn.Open();
                        SqlCommand CmdInsert = new SqlCommand(strInsert, LibraryCnn);
                        SqlDataReader ConsignReader = CmdInsert.ExecuteReader();
                        Status = (ConsignReader.RecordsAffected == 0) ? 4 : 0;
                        LibraryCnn.Close();
                    }
                }
            }
            return Status;
        }

        public int GiveBack(string strBookID)
        {
            int Status = 0;
            string strSelect = "DELETE FROM " + strtblName + " WHERE [BookID] = '" + strBookID + "'";
            LibraryCnn.Open();
            SqlCommand CmdSelect = new SqlCommand(strSelect, LibraryCnn);
            SqlDataReader ConsignReader = CmdSelect.ExecuteReader();
            Status = ConsignReader.RecordsAffected;
            LibraryCnn.Close();
            return Status;
        }

        public DataSet AvailableBooks()
        {
            string strSelect = "SELECT * FROM Available_Books";
            LibraryCnn.Open();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect, strCnn);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, strtblName);
            LibraryCnn.Close();
            return DataSet;
        }

        public int CheckDelay(string strBookID)
        {
            int Delay = -1;
            string strSelect = "SELECT EndDate FROM tblConsign WHERE [BookID] = '" + strBookID + "'";
            LibraryCnn.Open();
            SqlCommand CmdSelect = new SqlCommand(strSelect, LibraryCnn);
            SqlDataReader BookReader = CmdSelect.ExecuteReader();
            BookReader.Read();
            if (BookReader.HasRows)
            {
                DateTime t1 = DateTime.Now.Date;
                int totalDay=Convert.ToInt32(t1.Subtract(Convert.ToDateTime(BookReader.GetValue(0))).TotalDays);
                Delay = (totalDay < 0) ? 0 : totalDay;
            }
            LibraryCnn.Close();
            return Delay;
        }

        public DataSet IndebtedMembers()
        {
            string strSelect = "SELECT * FROM Indebted_Members";
            LibraryCnn.Open();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect, strCnn);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, strtblName);
            LibraryCnn.Close();
            return DataSet;
        }

        public DataSet IndebtedMember(string MemberID)
        {
            string strSelect = "SELECT * FROM Indebted_Members WHERE [MemberID] = '" + MemberID + "'";
            LibraryCnn.Open();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect, strCnn);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, strtblName);
            LibraryCnn.Close();
            return DataSet;
        }

        public DataSet LendBooks()
        {
            string strSelect = "SELECT * FROM Lend_Books";
            LibraryCnn.Open();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect, strCnn);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, strtblName);
            LibraryCnn.Close();
            return DataSet;
        }

        public SqlDataReader FindByField(string FieldName, string ValueToSearch)
        {
            string strSelect = "SELECT * FROM " + strtblName + " WHERE [" + FieldName + "] = '" + ValueToSearch + "'";
            LibraryCnn.Open();
            SqlCommand CmdSelect = new SqlCommand(strSelect, LibraryCnn);
            SqlDataReader BookReader = CmdSelect.ExecuteReader();
            BookReader.Read();
            return BookReader;
        }

        public DataSet List()
        {
            string strSelect = "SELECT * FROM " + strtblName;
            LibraryCnn.Open();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect, strCnn);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, strtblName);
            LibraryCnn.Close();
            return DataSet;
        }
    }
}