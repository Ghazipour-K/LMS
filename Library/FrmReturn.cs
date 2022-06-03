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
    public partial class FrmReturn : Form
    {
        public FrmReturn()
        {
            InitializeComponent();
        }

        private void btnCheckDelay_Click(object sender, EventArgs e)
        {
            string BookID = txtBookCode.Text.Trim();
            if (BookID != "")
            {
                Consign C = new Consign("tblConsign");
                int DelayDays = C.CheckDelay(BookID);
                switch (DelayDays)
                {
                    case -1:
                        lblMsg.Text = "کد کتاب معتبر نیست";
                        break;
                    case 0:
                        lblMsg.Text = "تاخیر ندارد";
                        break;
                    default:
                        lblMsg.Text = DelayDays.ToString() + "روز تاخیر دارد";
                        break;
                }
            }
            else
                lblMsg.Text = "کد کتاب را وراد کنید";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            string BookID = txtBookCode.Text.Trim();
            if (BookID != "")
            {
                Consign C = new Consign("tblConsign");
                int DelayDays = C.CheckDelay(BookID);
                switch (DelayDays)
                {
                    case -1:
                        lblMsg.Text = "کد کتاب معتبر نیست";
                        break;
                    case 0:
                        lblMsg.Text = "ثبت شد"; C.GiveBack(BookID);
                        txtBookCode.ResetText();
                        break;
                    default:
                        string Msg = "این کتاب " + C.CheckDelay(BookID).ToString() + "روز تاخیر دارد. آیا می خواهید ادامه دهید؟";
                        DialogResult R = MessageBox.Show(Msg, "سیستم کتابخانه", MessageBoxButtons.YesNo);
                        if (R == DialogResult.Yes) { C.GiveBack(BookID); lblMsg.Text = "ثبت شد"; txtBookCode.ResetText(); }
                        break;
                }
            }
            else
                lblMsg.Text = "کد کتاب را وراد کنید";
        }
    }
}