using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace GW2EventTimer
{
    public partial class MainForm : Form
    {
        int counter = 10;

        public MainForm()
        {
            InitializeComponent();
            ServerClientTime();
        }

        private void ServerClientTime()
        {
            ServerClientTimer = new System.Windows.Forms.Timer();
            ServerClientTimer.Tick += new EventHandler(ServerClientTimer_Tick);
            ServerClientTimer.Interval = 1000;
            ServerClientTimer.Start();
        }

        private void ServerClientTimer_Tick(object sender, EventArgs e)
        {
            toolStripSystemTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void BtnTimerSet_Click(object sender, EventArgs e)
        {
            TimeSpan t = TimeSpan.FromSeconds(counter);
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
            string FinalTime = string.Format("Server restarting in {0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
            LabelTime.Text = FinalTime;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = TimeSpan.FromSeconds(counter);
            counter--;
            if (counter == 0)
            {
                counter = 10;
            }

            string FinalTime = string.Format("Server restarting in {0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
            LabelTime.Text = FinalTime;
        }

        private void toolStripSystemTime_Click(object sender, EventArgs e)
        {

        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
