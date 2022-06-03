namespace Library
{
    partial class FrmMemberMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemberMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatuslblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.StatuslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolbox = new System.Windows.Forms.ToolStrip();
            this.toollblWelcom = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnSearchBook = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnStatus = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnExit = new System.Windows.Forms.ToolStripButton();
            this.MemberTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAbout = new System.Windows.Forms.ToolStripButton();
            this.statusStrip.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatuslblDate,
            this.toolStripSplitButton1,
            this.StatuslblTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(828, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // StatuslblDate
            // 
            this.StatuslblDate.Name = "StatuslblDate";
            this.StatuslblDate.Size = new System.Drawing.Size(33, 17);
            this.StatuslblDate.Text = "تاریخ";
            this.StatuslblDate.ToolTipText = "تاریخ";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(26, 20);
            this.toolStripSplitButton1.Text = "|";
            // 
            // StatuslblTime
            // 
            this.StatuslblTime.Name = "StatuslblTime";
            this.StatuslblTime.Size = new System.Drawing.Size(29, 17);
            this.StatuslblTime.Text = "زمان";
            this.StatuslblTime.ToolTipText = "زمان";
            // 
            // toolbox
            // 
            this.toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toollblWelcom,
            this.toolStripSeparator1,
            this.toolbtnSearchBook,
            this.toolStripSeparator3,
            this.toolbtnStatus,
            this.toolStripSeparator2,
            this.toolbtnExit,
            this.toolStripSeparator4,
            this.toolAbout});
            this.toolbox.Location = new System.Drawing.Point(0, 0);
            this.toolbox.Name = "toolbox";
            this.toolbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolbox.Size = new System.Drawing.Size(828, 25);
            this.toolbox.TabIndex = 4;
            this.toolbox.Text = "toolStrip1";
            // 
            // toollblWelcom
            // 
            this.toollblWelcom.Name = "toollblWelcom";
            this.toollblWelcom.Size = new System.Drawing.Size(51, 22);
            this.toollblWelcom.Text = "Welcom";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbtnSearchBook
            // 
            this.toolbtnSearchBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnSearchBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnSearchBook.Name = "toolbtnSearchBook";
            this.toolbtnSearchBook.Size = new System.Drawing.Size(78, 22);
            this.toolbtnSearchBook.Text = "جستجوی کتاب";
            this.toolbtnSearchBook.Click += new System.EventHandler(this.toolbtnSearchBook_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbtnStatus
            // 
            this.toolbtnStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnStatus.Name = "toolbtnStatus";
            this.toolbtnStatus.Size = new System.Drawing.Size(64, 22);
            this.toolbtnStatus.Text = "وضعیت شما";
            this.toolbtnStatus.Click += new System.EventHandler(this.toolbtnStatus_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbtnExit
            // 
            this.toolbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnExit.Name = "toolbtnExit";
            this.toolbtnExit.Size = new System.Drawing.Size(36, 22);
            this.toolbtnExit.Text = "خروج";
            this.toolbtnExit.Click += new System.EventHandler(this.toolbtnExit_Click);
            // 
            // MemberTimer
            // 
            this.MemberTimer.Enabled = true;
            this.MemberTimer.Interval = 1000;
            this.MemberTimer.Tick += new System.EventHandler(this.MemberTimer_Tick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolAbout
            // 
            this.toolAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolAbout.Image")));
            this.toolAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(97, 22);
            this.toolAbout.Text = "درباره ی نرم افزار";
            this.toolAbout.Click += new System.EventHandler(this.toolAbout_Click);
            // 
            // FrmMemberMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 453);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "FrmMemberMain";
            this.Text = "FrmMemberMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMemberMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip toolbox;
        private System.Windows.Forms.ToolStripLabel toollblWelcom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolbtnSearchBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolbtnStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolbtnExit;
        private System.Windows.Forms.ToolStripStatusLabel StatuslblDate;
        private System.Windows.Forms.Timer MemberTimer;
        private System.Windows.Forms.ToolStripStatusLabel StatuslblTime;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolAbout;
    }
}



