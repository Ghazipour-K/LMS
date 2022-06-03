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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuRegisterBook_Click(object sender, EventArgs e)
        {
            FrmRegisterBook RegBook = new FrmRegisterBook();
            RegBook.Show();
        }

        private void MnuDeleteBook_Click(object sender, EventArgs e)
        {
            FrmDeleteBook DelBook = new FrmDeleteBook();
            DelBook.Show();
        }

        private void MnuSearchBook_Click(object sender, EventArgs e)
        {
            FrmSearchBook SearchBook = new FrmSearchBook();
            SearchBook.Show();
        }

        private void MnuEditBook_Click(object sender, EventArgs e)
        {
            FrmEditBook EditBook = new FrmEditBook();
            EditBook.Show();
        }

        private void MnuGive_Click(object sender, EventArgs e)
        {
            FrmLend LendBook = new FrmLend();
            LendBook.Show();
        }

        private void MnuReturnBook_Click(object sender, EventArgs e)
        {
            FrmReturn ReturnBook = new FrmReturn();
            ReturnBook.Show();
        }

        private void MnuRegisterMember_Click(object sender, EventArgs e)
        {
            FrmRegisterMember RegisterMember = new FrmRegisterMember();
            RegisterMember.Show();
        }

        private void MnuDeleteMember_Click(object sender, EventArgs e)
        {
            FrmDeleteMember DeleteMember = new FrmDeleteMember();
            DeleteMember.Show();
        }

        private void MnuEditMember_Click(object sender, EventArgs e)
        {
            FrmEditMember EditMember = new FrmEditMember();
            EditMember.Show();
        }

        private void MnuSearchMember_Click(object sender, EventArgs e)
        {
            FrmSearchMember SearchMember = new FrmSearchMember();
            SearchMember.Show();
        }

        private void MnuReport_Click(object sender, EventArgs e)
        {
            FrmReport Report = new FrmReport();
            Report.Show();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            StatuslblDate.Text = DateTime.Now.ToLongDateString();
            StatuslblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            StatuslblDate.Text = DateTime.Now.ToLongDateString();
            StatuslblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            FrmAboutBox About = new FrmAboutBox();
            About.ShowDialog();
        }

    }
}