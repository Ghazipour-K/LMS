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
    public partial class FrmMemberMain : Form
    {
        //private int childFormNumber = 0;

        public FrmMemberMain()
        {
            InitializeComponent();
        }

        private void MemberTimer_Tick(object sender, EventArgs e)
        {
            StatuslblDate.Text = DateTime.Now.ToLongDateString();
            StatuslblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmMemberMain_Load(object sender, EventArgs e)
        {
            Member M = new Member("tblMember");
            toollblWelcom.Text = " سلام " + " < " + FrmMemberLogin.MemberInfo[1].ToString() + " " + FrmMemberLogin.MemberInfo[2].ToString() + " > " + "به سیستم کتابخانه خوش آمدید ";
            StatuslblDate.Text = DateTime.Now.ToLongDateString();
            StatuslblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolbtnSearchBook_Click(object sender, EventArgs e)
        {
            FrmSearchBook SearchBoook = new FrmSearchBook();
            SearchBoook.ShowDialog();
        }

        private void toolbtnStatus_Click(object sender, EventArgs e)
        {
            FrmMemberStatus MemberStatus = new FrmMemberStatus();
            MemberStatus.ShowDialog();
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {
            FrmAboutBox FrmAbout = new FrmAboutBox();
            FrmAbout.ShowDialog();
        }

        /*private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }*/
    }
}
