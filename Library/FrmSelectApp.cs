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
    public partial class FrmSelectApp : Form
    {
        static public int Mode = 0;
        public FrmSelectApp()
        {
            InitializeComponent();
        }

        private void btnMemberPart_Click(object sender, EventArgs e)
        {
            Mode = 1;
            this.Close();
        }

        private void btnAdminPart_Click(object sender, EventArgs e)
        {
            Mode = 2;
            this.Close();
        }

    }
}
