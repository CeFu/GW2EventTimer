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
            this.LabelEventTest = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTimerSet
            // 
            this.BtnTimerSet.Location = new System.Drawing.Point(216, 296);
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
            this.LabelTime.Location = new System.Drawing.Point(297, 301);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(34, 13);
            this.LabelTime.TabIndex = 1;
            this.LabelTime.Text = "Blank";
            // 
            // tbMins
            // 
            this.tbMins.Location = new System.Drawing.Point(110, 298);
            this.tbMins.Name = "tbMins";
            this.tbMins.Size = new System.Drawing.Size(100, 20);
            this.tbMins.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
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
            this.ToolStripServerTimeVariable});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(524, 25);
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
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
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
            this.ToolStripCurrentEvent});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(524, 25);
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
            // LabelEventTest
            // 
            this.LabelEventTest.AutoSize = true;
            this.LabelEventTest.Location = new System.Drawing.Point(171, 189);
            this.LabelEventTest.Name = "LabelEventTest";
            this.LabelEventTest.Size = new System.Drawing.Size(77, 13);
            this.LabelEventTest.TabIndex = 7;
            this.LabelEventTest.Text = "Practice Event";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 535);
            this.Controls.Add(this.LabelEventTest);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbMins);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.BtnTimerSet);
            this.Name = "MainForm";
            this.Text = "[Phi] World Boss Timers";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        public System.Windows.Forms.Label LabelEventTest;
    }
}

