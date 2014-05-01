namespace GW2EventTimer
{
    partial class MainForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnTimerSet = new System.Windows.Forms.Button();
            this.LabelTime = new System.Windows.Forms.Label();
            this.tbMins = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSystemTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripServerTime = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripServerTimeVariable = new System.Windows.Forms.ToolStripLabel();
            this.ServerClientTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ToolStripEvent = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripCurrentEvent = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripNextEvent = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripNextCurrentEvent = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMegaTimes = new System.Windows.Forms.TextBox();
            this.cbMegaD = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripDailyReset = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTimerSet
            // 
            this.BtnTimerSet.Location = new System.Drawing.Point(402, 121);
            this.BtnTimerSet.Name = "BtnTimerSet";
            this.BtnTimerSet.Size = new System.Drawing.Size(75, 23);
            this.BtnTimerSet.TabIndex = 0;
            this.BtnTimerSet.Text = "Start";
            this.BtnTimerSet.UseVisualStyleBackColor = true;
            this.BtnTimerSet.Click += new System.EventHandler(this.BtnTimerSet_Click);
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(110, 120);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(34, 13);
            this.LabelTime.TabIndex = 1;
            this.LabelTime.Text = "Blank";
            // 
            // tbMins
            // 
            this.tbMins.Location = new System.Drawing.Point(296, 123);
            this.tbMins.Name = "tbMins";
            this.tbMins.Size = new System.Drawing.Size(100, 20);
            this.tbMins.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(596, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSystemTime,
            this.toolStripSeparator1,
            this.ToolStripServerTime,
            this.ToolStripServerTimeVariable,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(596, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel1.Text = "System Time:";
            // 
            // toolStripSystemTime
            // 
            this.toolStripSystemTime.Name = "toolStripSystemTime";
            this.toolStripSystemTime.Size = new System.Drawing.Size(120, 22);
            this.toolStripSystemTime.Text = "Syncing System Time";
            this.toolStripSystemTime.Click += new System.EventHandler(this.toolStripSystemTime_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripServerTime
            // 
            this.ToolStripServerTime.Name = "ToolStripServerTime";
            this.ToolStripServerTime.Size = new System.Drawing.Size(72, 22);
            this.ToolStripServerTime.Text = "Server Time:";
            // 
            // ToolStripServerTimeVariable
            // 
            this.ToolStripServerTimeVariable.Name = "ToolStripServerTimeVariable";
            this.ToolStripServerTimeVariable.Size = new System.Drawing.Size(120, 22);
            this.ToolStripServerTimeVariable.Text = "Syncing System Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.MenuExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(116, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripEvent,
            this.ToolStripCurrentEvent,
            this.toolStripSeparator2,
            this.ToolStripNextEvent,
            this.ToolStripNextCurrentEvent,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.ToolStripDailyReset});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(596, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ToolStripEvent
            // 
            this.ToolStripEvent.Name = "ToolStripEvent";
            this.ToolStripEvent.Size = new System.Drawing.Size(82, 22);
            this.ToolStripEvent.Text = "Current Event:";
            // 
            // ToolStripCurrentEvent
            // 
            this.ToolStripCurrentEvent.Name = "ToolStripCurrentEvent";
            this.ToolStripCurrentEvent.Size = new System.Drawing.Size(96, 22);
            this.ToolStripCurrentEvent.Text = "Loading Events...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripNextEvent
            // 
            this.ToolStripNextEvent.Name = "ToolStripNextEvent";
            this.ToolStripNextEvent.Size = new System.Drawing.Size(66, 22);
            this.ToolStripNextEvent.Text = "Next Event:";
            // 
            // ToolStripNextCurrentEvent
            // 
            this.ToolStripNextCurrentEvent.Name = "ToolStripNextCurrentEvent";
            this.ToolStripNextCurrentEvent.Size = new System.Drawing.Size(96, 22);
            this.ToolStripNextCurrentEvent.Text = "Loading Events...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMegaTimes);
            this.groupBox1.Controls.Add(this.cbMegaD);
            this.groupBox1.Controls.Add(this.LabelTime);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbMegaTimes
            // 
            this.tbMegaTimes.Location = new System.Drawing.Point(113, 17);
            this.tbMegaTimes.Name = "tbMegaTimes";
            this.tbMegaTimes.ReadOnly = true;
            this.tbMegaTimes.Size = new System.Drawing.Size(100, 20);
            this.tbMegaTimes.TabIndex = 1;
            // 
            // cbMegaD
            // 
            this.cbMegaD.AutoSize = true;
            this.cbMegaD.Location = new System.Drawing.Point(6, 19);
            this.cbMegaD.Name = "cbMegaD";
            this.cbMegaD.Size = new System.Drawing.Size(101, 17);
            this.cbMegaD.TabIndex = 0;
            this.cbMegaD.Text = "Mega Destoryer";
            this.cbMegaD.UseVisualStyleBackColor = true;
            this.cbMegaD.CheckedChanged += new System.EventHandler(this.cbMegaD_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 167);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 330);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel2.Text = "Daily Reset:";
            // 
            // ToolStripDailyReset
            // 
            this.ToolStripDailyReset.Name = "ToolStripDailyReset";
            this.ToolStripDailyReset.Size = new System.Drawing.Size(98, 22);
            this.ToolStripDailyReset.Text = "Calculating Reset";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 535);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbMins);
            this.Controls.Add(this.BtnTimerSet);
            this.Name = "MainForm";
            this.Text = "[Phi] World Boss Timers";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnTimerSet;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.TextBox tbMins;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripSystemTime;
        private System.Windows.Forms.Timer ServerClientTimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripLabel ToolStripServerTime;
        private System.Windows.Forms.ToolStripLabel ToolStripServerTimeVariable;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel ToolStripEvent;
        public System.Windows.Forms.ToolStripLabel ToolStripCurrentEvent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMegaTimes;
        private System.Windows.Forms.CheckBox cbMegaD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel ToolStripNextEvent;
        private System.Windows.Forms.ToolStripLabel ToolStripNextCurrentEvent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel ToolStripDailyReset;
    }
}

