namespace Library
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.MnuMember = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRegisterMember = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDeleteMember = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEditMember = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSearchMember = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRegisterBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEditBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSearchBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsign = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuGive = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.SatusBar = new System.Windows.Forms.StatusStrip();
            this.StatuslblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatuslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.MnuMain.SuspendLayout();
            this.SatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMain
            // 
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMember,
            this.MnuBook,
            this.MnuConsign,
            this.MnuSystem,
            this.MnuExit});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MnuMain.Size = new System.Drawing.Size(923, 24);
            this.MnuMain.TabIndex = 1;
            this.MnuMain.Text = "menuStrip1";
            // 
            // MnuMember
            // 
            this.MnuMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRegisterMember,
            this.MnuDeleteMember,
            this.MnuEditMember,
            this.MnuSearchMember});
            this.MnuMember.Name = "MnuMember";
            this.MnuMember.Size = new System.Drawing.Size(43, 20);
            this.MnuMember.Text = "اعضا";
            // 
            // MnuRegisterMember
            // 
            this.MnuRegisterMember.Name = "MnuRegisterMember";
            this.MnuRegisterMember.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.A)));
            this.MnuRegisterMember.Size = new System.Drawing.Size(243, 22);
            this.MnuRegisterMember.Text = "ثبت عضو جدید";
            this.MnuRegisterMember.Click += new System.EventHandler(this.MnuRegisterMember_Click);
            // 
            // MnuDeleteMember
            // 
            this.MnuDeleteMember.Name = "MnuDeleteMember";
            this.MnuDeleteMember.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D)));
            this.MnuDeleteMember.Size = new System.Drawing.Size(243, 22);
            this.MnuDeleteMember.Text = "لغو عضویت";
            this.MnuDeleteMember.Click += new System.EventHandler(this.MnuDeleteMember_Click);
            // 
            // MnuEditMember
            // 
            this.MnuEditMember.Name = "MnuEditMember";
            this.MnuEditMember.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.E)));
            this.MnuEditMember.Size = new System.Drawing.Size(243, 22);
            this.MnuEditMember.Text = "ویرایش اطلاعات اعضا";
            this.MnuEditMember.Click += new System.EventHandler(this.MnuEditMember_Click);
            // 
            // MnuSearchMember
            // 
            this.MnuSearchMember.Name = "MnuSearchMember";
            this.MnuSearchMember.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.MnuSearchMember.Size = new System.Drawing.Size(243, 22);
            this.MnuSearchMember.Text = "جستجوی اعضا";
            this.MnuSearchMember.Click += new System.EventHandler(this.MnuSearchMember_Click);
            // 
            // MnuBook
            // 
            this.MnuBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRegisterBook,
            this.MnuDeleteBook,
            this.MnuEditBook,
            this.MnuSearchBook});
            this.MnuBook.Name = "MnuBook";
            this.MnuBook.Size = new System.Drawing.Size(46, 20);
            this.MnuBook.Text = "کتابها";
            // 
            // MnuRegisterBook
            // 
            this.MnuRegisterBook.Name = "MnuRegisterBook";
            this.MnuRegisterBook.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.A)));
            this.MnuRegisterBook.Size = new System.Drawing.Size(237, 22);
            this.MnuRegisterBook.Text = "ثبت کتاب جدید";
            this.MnuRegisterBook.Click += new System.EventHandler(this.MnuRegisterBook_Click);
            // 
            // MnuDeleteBook
            // 
            this.MnuDeleteBook.Name = "MnuDeleteBook";
            this.MnuDeleteBook.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.D)));
            this.MnuDeleteBook.Size = new System.Drawing.Size(237, 22);
            this.MnuDeleteBook.Text = "حذف کتاب";
            this.MnuDeleteBook.Click += new System.EventHandler(this.MnuDeleteBook_Click);
            // 
            // MnuEditBook
            // 
            this.MnuEditBook.Name = "MnuEditBook";
            this.MnuEditBook.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.E)));
            this.MnuEditBook.Size = new System.Drawing.Size(237, 22);
            this.MnuEditBook.Text = "ویرایش اطلاعات کتابها";
            this.MnuEditBook.Click += new System.EventHandler(this.MnuEditBook_Click);
            // 
            // MnuSearchBook
            // 
            this.MnuSearchBook.Name = "MnuSearchBook";
            this.MnuSearchBook.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.S)));
            this.MnuSearchBook.Size = new System.Drawing.Size(237, 22);
            this.MnuSearchBook.Text = "جستجوی کتاب";
            this.MnuSearchBook.Click += new System.EventHandler(this.MnuSearchBook_Click);
            // 
            // MnuConsign
            // 
            this.MnuConsign.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGive,
            this.MnuReturnBook,
            this.MnuReport});
            this.MnuConsign.Name = "MnuConsign";
            this.MnuConsign.Size = new System.Drawing.Size(47, 20);
            this.MnuConsign.Text = "امانات";
            // 
            // MnuGive
            // 
            this.MnuGive.Name = "MnuGive";
            this.MnuGive.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.MnuGive.Size = new System.Drawing.Size(174, 22);
            this.MnuGive.Text = "امانت دادن";
            this.MnuGive.Click += new System.EventHandler(this.MnuGive_Click);
            // 
            // MnuReturnBook
            // 
            this.MnuReturnBook.Name = "MnuReturnBook";
            this.MnuReturnBook.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.MnuReturnBook.Size = new System.Drawing.Size(174, 22);
            this.MnuReturnBook.Text = "برگشت کتاب";
            this.MnuReturnBook.Click += new System.EventHandler(this.MnuReturnBook_Click);
            // 
            // MnuReport
            // 
            this.MnuReport.Name = "MnuReport";
            this.MnuReport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.MnuReport.Size = new System.Drawing.Size(174, 22);
            this.MnuReport.Text = "گزارش گیری";
            this.MnuReport.Click += new System.EventHandler(this.MnuReport_Click);
            // 
            // MnuSystem
            // 
            this.MnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuHelp,
            this.MnuAbout});
            this.MnuSystem.Name = "MnuSystem";
            this.MnuSystem.Size = new System.Drawing.Size(50, 20);
            this.MnuSystem.Text = "سیستم";
            // 
            // MnuHelp
            // 
            this.MnuHelp.Name = "MnuHelp";
            this.MnuHelp.Size = new System.Drawing.Size(160, 22);
            this.MnuHelp.Text = "راهنما";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(160, 22);
            this.MnuAbout.Text = "درباره ی نرم افزار";
            this.MnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // MnuExit
            // 
            this.MnuExit.AccessibleName = "Exit";
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.MnuExit.Size = new System.Drawing.Size(44, 20);
            this.MnuExit.Text = "خروج";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // SatusBar
            // 
            this.SatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatuslblDate,
            this.toolStripSplitButton1,
            this.StatuslblTime});
            this.SatusBar.Location = new System.Drawing.Point(0, 404);
            this.SatusBar.Name = "SatusBar";
            this.SatusBar.Size = new System.Drawing.Size(923, 22);
            this.SatusBar.TabIndex = 3;
            this.SatusBar.Text = "statusStrip1";
            // 
            // StatuslblDate
            // 
            this.StatuslblDate.Name = "StatuslblDate";
            this.StatuslblDate.Size = new System.Drawing.Size(33, 17);
            this.StatuslblDate.Text = "تاریخ";
            this.StatuslblDate.ToolTipText = "تاریخ";
            // 
            // StatuslblTime
            // 
            this.StatuslblTime.Name = "StatuslblTime";
            this.StatuslblTime.Size = new System.Drawing.Size(29, 17);
            this.StatuslblTime.Text = "زمان";
            this.StatuslblTime.ToolTipText = "زمان";
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(26, 20);
            this.toolStripSplitButton1.Text = "|";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 426);
            this.Controls.Add(this.SatusBar);
            this.Controls.Add(this.MnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuMain;
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "سیستم کتابخانه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            this.SatusBar.ResumeLayout(false);
            this.SatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MnuMember;
        private System.Windows.Forms.ToolStripMenuItem MnuBook;
        private System.Windows.Forms.ToolStripMenuItem MnuConsign;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem MnuRegisterMember;
        private System.Windows.Forms.ToolStripMenuItem MnuDeleteMember;
        private System.Windows.Forms.ToolStripMenuItem MnuEditMember;
        private System.Windows.Forms.ToolStripMenuItem MnuSearchMember;
        private System.Windows.Forms.ToolStripMenuItem MnuRegisterBook;
        private System.Windows.Forms.ToolStripMenuItem MnuDeleteBook;
        private System.Windows.Forms.ToolStripMenuItem MnuEditBook;
        private System.Windows.Forms.ToolStripMenuItem MnuSearchBook;
        private System.Windows.Forms.ToolStripMenuItem MnuGive;
        private System.Windows.Forms.ToolStripMenuItem MnuReturnBook;
        private System.Windows.Forms.StatusStrip SatusBar;
        private System.Windows.Forms.ToolStripMenuItem MnuReport;
        private System.Windows.Forms.ToolStripStatusLabel StatuslblDate;
        private System.Windows.Forms.ToolStripStatusLabel StatuslblTime;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.ToolStripMenuItem MnuSystem;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
    }
}