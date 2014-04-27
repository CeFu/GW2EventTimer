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
        string CurrentServerTime;

        public MainForm()
        {
            InitializeComponent();
            ClientServerTime();
            try
            {
                //ClientServerTime();
                SetEventTimes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Failed to Initialize Sync's - Report to Dybbuk");
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetEventTimes()
        {

        }

        private void ClientServerTime()
        {
            ServerClientTimer = new System.Windows.Forms.Timer();
            ServerClientTimer.Tick += new EventHandler(ServerClientTimer_Tick);
            ServerClientTimer.Interval = 1000;
            ServerClientTimer.Start();
        }

        private void ServerClientTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                TimeZoneInfo GWServer = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
                toolStripSystemTime.Text = DateTime.Now.ToString("HH:mm:ss");
                CurrentServerTime = TimeZoneInfo.ConvertTime(System.DateTime.Now, TimeZoneInfo.Local, GWServer).ToString("HH:mm:ss");
                ToolStripServerTimeVariable.Text = TimeZoneInfo.ConvertTime(System.DateTime.Now, TimeZoneInfo.Local, GWServer).ToString("HH:mm:ss");
                UpdateTimers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Failed to set time labels? - Report to Dybbuk");
                MessageBox.Show(ex.ToString());
            
            }
        }

        private void UpdateTimers()
        {
            string[] EventTimes = { "16:00:00", "16:15:00", "16:30:00", "17:00:00", "17:15:00", "17:30:30", "17:45:00",
                                    "18:00:00", "18:15:00", "18:30:00", "18:45:00", "19:00:00"};
            string[] values = { "16:00:00", "12.12:12:12.12345678" };

            //if (cbMegaD.Checked == true)
            //{
            //    foreach (string MD in MegaDestroyer)
            //    {
            //        TimeSpan dtimes = TimeSpan.Parse(MD);
            //        LabelTime.Text = dtimes.ToString();
            //        Thread.Sleep(5000);
            //    }
            //}

            foreach (string value in EventTimes)
            {
                    TimeSpan interval = TimeSpan.Parse(value);
                                        LabelTime.Text = interval.ToString();
            }
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

        private void cbMegaD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMegaD.Checked == false){}
            else if (cbMegaD.Checked == true)
            {
                tbMegaTimes.Text = CurrentServerTime;
                UpdateTimers();
            }
        }
    }
}
