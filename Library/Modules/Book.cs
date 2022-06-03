using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    //Book Class
    class Book
    {
        
        private string _Title = "";
        private string _Author = "";
        private string _Year;
        private int _Impression = 0;
        private int _PrintRun = 0;
        private string _Publisher = "";
        private int _Price = 0;
        private string _ISBN = "";
        private string _BookID = "";
        private string _RegDate;

        public string Title { get { return _Title; } set { _Title = value.ToString(); } }
        public string Author { get { return _Author; } set { _Author = value.ToString(); } }
        public string Year { get { return _Year; } set { _Year = value.ToString(); } }
        public int Impression { get { return _Impression; } set { _Impression = Convert.ToInt32(value); } }
        public int PrintRun { get { return _PrintRun; } set { _PrintRun = Convert.ToInt32(value); } }
        public string Publisher { get { return _Publisher; } set { _Publisher = value.ToString(); } }
        public int Price { get { return _Price; } set { _Price = Convert.ToInt32(value); } }
        public string ISBN { get { return _ISBN; } set { _ISBN = value.ToString(); } }
        public string BookID { get { return _BookID; } set { _BookID = value.ToString(); } }
        public string RegDate { get { return _RegDate; } set { _RegDate = value.ToString(); } }

        private SqlConnection LibraryCnn;
        private string strCnn = "";
        private string strtblName = "";

        public Book(string BookTblName)
        {
            strCnn = "Data Source=Kiumars-PC; Initial Catalog=Library; Integrated Security=True";
            strtblName = BookTblName;
            LibraryCnn = new SqlConnection(strCnn);
        }

        private bool InfoIsCorrect()
        {
            return (!Find(_BookID));
        }

        public bool Save()
        {
            bool Status = false;
            if (InfoIsCorrect())
            {
                string strInsert = "INSERT INTO " + strtblName + " VALUES('" + _Title + "','" + _Author + "','";
                strInsert += _Year + "','" + _Impression + "','" + _PrintRun + "','" + _Publisher + "','";
                strInsert += _Price + "','" + _ISBN + "','" + _BookID + "','" + _RegDate + "')";
                LibraryCnn.Open();
                SqlCommand CmdInsert = new SqlCommand(strInsert, LibraryCnn);
                SqlDataReader BookReader = CmdInsert.ExecuteReader();
                Status = Convert.ToBoolean(BookReader.RecordsAffected);
                LibraryCnn.Close();

                Consign More = new Consign("tblMoreBookInfo");

                if (More.FindByField("ISBN",_ISBN).HasRows)
                    strInsert = "UPDATE [tblMoreBookInfo] SET [Count] = ([Count]+1) WHERE [ISBN] LIKE '" + _ISBN + "'";
                else
                    strInsert = "INSERT INTO [tblMoreBookInfo] VALUES('" + _ISBN + "','" + 1 + "')";

                LibraryCnn.Open();
                CmdInsert.CommandText = strInsert;
                BookReader = CmdInsert.ExecuteReader();
                Status = (Status && Convert.ToBoolean(BookReader.RecordsAffected));
                LibraryCnn.Close();
            }
            return Status;
        }

        public bool Delete(string strID)
        {
            bool Status = false;
            if (GetRowOf("BookID", strID).HasRows)
            {
                string strCmd;
                int Count = 0;
                Consign More = new Consign("tblMoreBookInfo");
                string DISBN = GetRowOf("BookID", strID).GetValue(7).ToString();
                Count = Convert.ToInt32(More.FindByField("ISBN", DISBN).GetValue(1));

                if (Count > 1)
                    strCmd = "UPDATE [tblMoreBookInfo] SET [Count] = ([Count]-1) WHERE [ISBN] LIKE '" + DISBN + "'";
                else
                    strCmd = "DELETE FROM [tblMoreBookInfo] WHERE [ISBN] = '" + DISBN + "'";

                string strDelete = "DELETE FROM " + strtblName + " WHERE [BookID] = '" + strID + "'";
                LibraryCnn.Close();
                LibraryCnn.Open();
                SqlCommand CmdSelect = new SqlCommand(strCmd, LibraryCnn);
                SqlDataReader BookReader = CmdSelect.ExecuteReader();
                Status = Convert.ToBoolean(BookReader.RecordsAffected);
                BookReader.Close();
                CmdSelect.CommandText = strDelete;
                BookReader = CmdSelect.ExecuteReader();
                Status = (Status && Convert.ToBoolean(BookReader.RecordsAffected));
                LibraryCnn.Close();
            }
            return Status;
        }

        public bool UpdateInfo()
        {
            bool Status = true;
            if (_BookID != "")
            {
                string strCmdUpdate = "UPDATE " + strtblName + " SET Title=@_Title, Author=@_Author, ";
                strCmdUpdate += "Year=@_Year, Impression=@_Impression, PrintRun=@_PrintRun, ";
                strCmdUpdate += "Publisher=@_Publisher, Price=@_Price, ";
                strCmdUpdate += "RegDate=@_RegDate WHERE [BookID]=@_BookID";
                LibraryCnn.Open();
                SqlCommand CmdUpdate = new SqlCommand(strCmdUpdate, LibraryCnn);

                CmdUpdate.Parameters.AddWithValue("@_Title", _Title);
                CmdUpdate.Parameters.AddWithValue("@_Author", _Author);
                CmdUpdate.Parameters.AddWithValue("@_Year", _Year);
                CmdUpdate.Parameters.AddWithValue("@_Impression", _Impression);
                CmdUpdate.Parameters.AddWithValue("@_PrintRun", _PrintRun);
                CmdUpdate.Parameters.AddWithValue("@_Publisher", _Publisher);
                CmdUpdate.Parameters.AddWithValue("@_Price", _Price);
                CmdUpdate.Parameters.AddWithValue("@_BookID", _BookID);
                CmdUpdate.Parameters.AddWithValue("@_RegDate", _RegDate);

                SqlDataReader UpdateReader = CmdUpdate.ExecuteReader();
                Status = Convert.ToBoolean(UpdateReader.RecordsAffected);
                LibraryCnn.Close();
                return Status;
            }
            else
            {
                LibraryCnn.Close();
                Status = false;
                return Status;
            }
        }

        public bool Find(string strID)
        {
            bool Status;
            string strSelect = "SELECT [BookID] FROM " + strtblName + " WHERE [BookID] = '" + strID + "'";
            LibraryCnn.Open();
            SqlCommand CmdSelect = new SqlCommand(strSelect, LibraryCnn);
            SqlDataReader BookReader = CmdSelect.ExecuteReader();
            Status = BookReader.HasRows;
            LibraryCnn.Close();
            return Status;
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

        public DataSet FindByField(string FieldName, string ValueToSearch)
        {
            string strSelect = "SELECT * FROM " + strtblName + " WHERE [" + FieldName + "] Like '" + ValueToSearch + "'";
            LibraryCnn.Open();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect, strCnn);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, strtblName);
            return DataSet;
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