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
    public partial class FrmSearchBook : Form
    {
        public FrmSearchBook()
        {
            InitializeComponent();
        }
        private string QrySrc = "tblBook";
        private void FrmSearchBook_Load(object sender, EventArgs e)
        {
            Book B = new Book("Book_ShortList");
            lstbook.DataSource = B.List().Tables["Book_ShortList"].DefaultView;
        }

        private void btnAdvSearch_Click(object sender, EventArgs e)
        {
            string Title, Author, Publisher,Year;
            Title = txtTitle.Text.Trim();
            Author = txtAuthor.Text.Trim();
            Publisher = txtPublisher.Text.Trim();
            Year = txtYear.Text.Trim();
            string strCnn = "Data Source=Kiumars-PC; Initial Catalog=Library; Integrated Security=True";
            SqlConnection LibraryCnn = new SqlConnection(strCnn);
            string strSelect = "SELECT * FROM "+ QrySrc +" WHERE [Title] Like '" + Title + "' OR [Author] Like '" + Author + "' OR [Publisher] Like '" + Publisher + "' OR [Year] Like '" + Year + "'";
            LibraryCnn.Open();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect, strCnn);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, "tblBook");
            lstbook.DataSource = DataSet.Tables["tblBook"].DefaultView;
            LibraryCnn.Close();
        }

        private void btnISBNSearch_Click(object sender, EventArgs e)
        {
            string strCnn = "Data Source=Kiumars-PC; Initial Catalog=Library; Integrated Security=True";
            SqlConnection LibraryCnn = new SqlConnection(strCnn);
            string strSelect = "SELECT * FROM " + QrySrc + " WHERE [ISBN] LIKE '" + txtISBN.Text.Trim() + "'";
            LibraryCnn.Open();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(strSelect, strCnn);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, "tblBook");
            lstbook.DataSource = DataSet.Tables["tblBook"].DefaultView;
            LibraryCnn.Close();
        }

        private void rdoLend_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLend.Checked)
            {
                QrySrc = "Lend_Books";
                Book B = new Book(QrySrc);
                lstbook.DataSource = B.List().Tables[QrySrc].DefaultView;
            }
        }

        private void rdoAvailabe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAvailabe.Checked)
            {
                QrySrc = "Available_Books";
                Book B = new Book(QrySrc);
                lstbook.DataSource = B.List().Tables[QrySrc].DefaultView;
            }

        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAll.Checked)
            {
                QrySrc = "tblBook";
                Book B = new Book(QrySrc);
                lstbook.DataSource = B.List().Tables[QrySrc].DefaultView;
            }
        }

        private void btnDisplayAllBooks_Click(object sender, EventArgs e)
        {
            Book B = new Book("Book_ShortList");
            lstbook.DataSource = B.List().Tables["Book_ShortList"].DefaultView;
        }
    }
}
