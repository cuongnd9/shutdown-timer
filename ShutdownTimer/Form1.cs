using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ShutdownTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        [DllImport("Powrprof.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint Flag, uint Reason);
        [DllImport("user32")]
        public static extern void LockWorkStation(); // For Lock
        private int totalDateTime = 0;
        public void LoadTotalDateTime()
        {
            TimeSpan timeSpan = userControl1.Date - DateTime.Now.Date;
            if(userControl1.CheckBoxTotalTime_Value==true)
            totalDateTime = userControl1.TotalHours * 3600 + userControl1.TotalMinutes * 60 + userControl1.TotalSeconds;
            else
            {
                int totalTime = userControl1.Hours * 3600 + userControl1.Minutes * 60 + userControl1.Seconds - DateTime.Now.Hour * 3600 - DateTime.Now.Minute * 60 - DateTime.Now.Second;
                if (totalTime >= 0)
                    totalDateTime = timeSpan.Seconds + totalTime;
                else
                    totalDateTime = 86400 - (userControl1.Hours * 3600 + userControl1.Minutes * 60 + userControl1.Seconds) +timeSpan.Seconds;
            }
        }
        public void LoadData()
        {
            userControl1.CheckBoxTotalTime_Value = true;
            userControl1.CheckBoxSelectedTime_Value = false;
            if(Properties.Settings.Default.Status==0)
            {
                userControl1.Date = DateTime.Now.Date;
                userControl1.Hours = DateTime.Now.Hour;
                userControl1.Minutes = DateTime.Now.Minute;
                userControl1.Seconds = DateTime.Now.Second;
                userControl1.TotalHours = 0;
                userControl1.TotalMinutes = 0;
                userControl1.TotalSeconds = 0;
                userControl1.BringToFront();
            }
            else
            {
                DateTime dateTimeCheck = new DateTime(Properties.Settings.Default.y, Properties.Settings.Default.MM, Properties.Settings.Default.d, Properties.Settings.Default.h, Properties.Settings.Default.m, Properties.Settings.Default.s);
                if (dateTimeCheck > DateTime.Now)
                {
                    userControl1.Date = new DateTime(Properties.Settings.Default.y, Properties.Settings.Default.MM, Properties.Settings.Default.d);
                    userControl1.Hours = Properties.Settings.Default.h;
                    userControl1.Minutes = Properties.Settings.Default.m;
                    userControl1.Seconds = Properties.Settings.Default.s;
                    switch (Properties.Settings.Default.TypeButton)
                    {
                        case 3: btnShutdown.color = Color.FromArgb(90, 160, 40); break;
                        case 4: btnRestart.color = Color.FromArgb(90, 160, 40); break;
                    }
                    timer1.Start();
                    userControl2.BringToFront();
                }
                else
                {
                    Properties.Settings.Default.Status = 0;
                    Properties.Settings.Default.Save();
                    userControl1.Date = DateTime.Now.Date;
                    userControl1.Hours = DateTime.Now.Hour;
                    userControl1.Minutes = DateTime.Now.Minute;
                    userControl1.Seconds = DateTime.Now.Second;
                    userControl1.TotalHours = 0;
                    userControl1.TotalMinutes = 0;
                    userControl1.TotalSeconds = 0;
                    userControl1.BringToFront();
                }
            }
            
        }
        public void LoadData1()
        {
            userControl1.Date = DateTime.Now.Date;
            userControl1.Hours = DateTime.Now.Hour;
            userControl1.Minutes = DateTime.Now.Minute;
            userControl1.Seconds = DateTime.Now.Second;
            userControl1.TotalHours = 0;
            userControl1.TotalMinutes = 0;
            userControl1.TotalSeconds = 0;
            userControl1.BringToFront();
        }
        public void UpdateData(int indexButton)
        {
            Properties.Settings.Default.TypeButton =indexButton;
            Properties.Settings.Default.Status = 1;
            Properties.Settings.Default.h = userControl1.Hours;
            Properties.Settings.Default.m = userControl1.Minutes;
            Properties.Settings.Default.s = userControl1.Seconds;
            Properties.Settings.Default.d = userControl1.Date.Day;
            Properties.Settings.Default.MM = userControl1.Date.Month;
            Properties.Settings.Default.y = userControl1.Date.Year;
            Properties.Settings.Default.Save();
        }
        public void LoadTime()
        {
            int totalTime = userControl1.TotalHours * 3600 + userControl1.TotalMinutes * 60 + userControl1.TotalSeconds + DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
            if (totalTime <= 86400)
            {
                userControl1.Hours = totalTime / 3600;
                userControl1.Minutes = (totalTime % 3600) / 60;
                userControl1.Seconds = (totalTime % 3600) % 60;
            }
            else
            {
                totalTime = totalTime - 86400;
                userControl1.Hours = totalTime / 3600;
                userControl1.Minutes = (totalTime % 3600) / 60;
                userControl1.Seconds = (totalTime % 3600) % 60;
                userControl1.Date = DateTime.Now.Date.AddDays(1);
            }

            }
            //public void LoadTotalTime()
            //{
            //    int totalTime = userControl1.Hours * 3600 + userControl1.Minutes * 60 + userControl1.Seconds - (DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second);
            //    if (totalTime > 0)
            //    {
            //        userControl1.TotalHours = totalTime / 3600;
            //        userControl1.TotalMinutes = (totalTime % 3600) / 60;
            //        userControl1.TotalSeconds = (totalTime % 3600) % 60;
            //    }
            //    else
            //    {
            //        userControl1.TotalHours = 0;
            //        userControl1.TotalMinutes = 0;
            //        userControl1.TotalSeconds = 0;
            //    }
            //}
            public void Shutdown(string command)
        {
            //Process.Start("shutdown",command);--cach nhanh nhat de tat may
            ProcessStartInfo startInfo = new ProcessStartInfo("shutdown", command);
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            Process.Start(startInfo);
        }
        public void ChangeBackColorButton(object sender)
        {
            BunifuTileButton btn = sender as BunifuTileButton;          
            foreach (Control item in panelButton.Controls)
            {
                if (item != btn)
                {
                    (item as BunifuTileButton).color = Color.FromArgb(102, 204, 51);
                }
            }
            btn.color = Color.FromArgb(90, 160, 40);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Status==0)
            {
                ChangeBackColorButton(sender);
                LoadTotalDateTime();
                string command = "-s -t " + totalDateTime;
                Shutdown(command);
                if (userControl1.TotalHours != 0 || userControl1.TotalMinutes != 0 || userControl1.TotalSeconds != 0)
                    LoadTime();
                timer1.Start();
                userControl2.BringToFront();
                UpdateData(3);
              
            }
            
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Status == 0)
            {
                ChangeBackColorButton(sender);
                LoadTotalDateTime();
                string command = "-r -t " + totalDateTime;
                Shutdown(command);
                if (userControl1.TotalHours != 0 || userControl1.TotalMinutes != 0 || userControl1.TotalSeconds != 0)
                    LoadTime();
                timer1.Start();
                userControl2.BringToFront();
                UpdateData(4);
               
            }
            
        }
        private void btnSleep_Click(object sender, EventArgs e)
        {
            
            ChangeBackColorButton(sender);
            Application.Exit();
                SetSuspendState(false, true, true);

           
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
                ChangeBackColorButton(sender);
            
            Application.Exit();
                ExitWindowsEx(0,0);

        }
        private void btnSwitchUser_Click(object sender, EventArgs e)
        {
            ChangeBackColorButton(sender);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            string command = "-a";
            Shutdown(command);
            timer1.Stop();
            LoadData();
            Properties.Settings.Default.Status = 0;
            Properties.Settings.Default.Save();
            ChangeBackColorButton(sender);
            userControl1.BringToFront();

        }
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/ndc07.it");
        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/ndc07.it");
        }
        private void userControl1_TotalHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void userControl1_TotalMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void userControl1_TotalSeconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void userControl1_Seconds_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void userControl1_Hours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void userControl1_Minutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (Properties.Settings.Default.Status == 0) timer1.Stop();
            TimeSpan timespan = userControl1.Date - DateTime.Now.Date;
            int Days = timespan.Days - 1;
            userControl2.Days = Days;

            if (userControl1.CheckBoxSelectedTime_Value)
            {
                if (Days > 0)
                {
                    userControl2.CircleDays_MaxValue = Days;
                    userControl2.Days = Days;
                    userControl2.CircleDays_MinValue = 0;
                    userControl2.CircleDays_Value = 1;
                }
                else
                {
                    userControl2.CircleDays_MaxValue = 1;
                    userControl2.Days = 0;
                    userControl2.CircleDays_MinValue = 0;
                    userControl2.CircleDays_Value = 0;
                }
            }
            else
            {
                userControl2.CircleDays_MaxValue = 1;
                userControl2.Days = 0;
                userControl2.CircleDays_MinValue = 0;
                userControl2.CircleDays_Value = 0;
            }
           
             userControl2.Text = "Waiting...    " + userControl1.Hours.ToString("00") + ":" + userControl1.Minutes.ToString("00") + ":" + userControl1.Seconds.ToString("00") + "  " + userControl1.Date.Month + "-" + userControl1.Date.Day + "-" + userControl1.Date.Year;
            int totalTime = userControl1.Hours * 3600 + userControl1.Minutes * 60 + userControl1.Seconds - (DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second);
            if (totalTime > 0)
            {
                userControl2.Hours = totalTime / 3600;
                userControl2.CircleHours_Value = totalTime / 3600;
                userControl2.Minutes = (totalTime % 3600) / 60;
                userControl2.CircleMinutes_Value = (totalTime % 3600) / 60;
                userControl2.Seconds = (totalTime % 3600) % 60;
                userControl2.CircleSeconds_Value = (totalTime % 3600) % 60;
            }
            else
            {
                if (timespan.Days > 0)
                {
                    totalTime = userControl1.Hours * 3600 + userControl1.Minutes * 60 + userControl1.Seconds + 86400 - (DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second);
                    userControl2.Hours = totalTime / 3600;
                    userControl2.CircleHours_Value = totalTime / 3600;
                    userControl2.Minutes = (totalTime % 3600) / 60;
                    userControl2.CircleMinutes_Value = (totalTime % 3600) / 60;
                    userControl2.Seconds = (totalTime % 3600) % 60;
                    userControl2.CircleSeconds_Value = (totalTime % 3600) % 60;
                }
                else
                {
                    Application.Exit();

                }
            }
        }

        private void btnSwitchUser_Click_1(object sender, EventArgs e)
        {

            ChangeBackColorButton(sender);
            Application.Exit();
            LockWorkStation();
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            userControl3.BringToFront();
        }

       
        private void userControl3_ButtonBack_Click(object sender, EventArgs e)
        {
            userControl3.SendToBack();
        }

        private void userControl3_Button_Click_1(object sender, EventArgs e)
        {
            userControl3.SendToBack();
            Process.Start("https://www.facebook.com/ndc07.it");
        }

        private void userControl1_CheckBoxSelectedTime_OnChange(object sender, EventArgs e)
        {
            if (userControl1.CheckBoxSelectedTime_Value == true)
            {
                userControl1.CheckBoxTotalTime_Value = false;
                userControl1.TotalHours = 0;
                userControl1.TotalMinutes = 0;
                userControl1.TotalSeconds = 0;
            }
            else
            {
                userControl1.CheckBoxTotalTime_Value = true;
            }
               
        }

        private void userControl1_CheckBoxTotalTime_OnChange(object sender, EventArgs e)
        {
            if (userControl1.CheckBoxTotalTime_Value == true)
            {
                userControl1.CheckBoxSelectedTime_Value = false;
                userControl1.Hours =DateTime.Now.Hour;
                userControl1.Minutes =DateTime.Now.Minute;
                userControl1.Seconds =DateTime.Now.Second;
            }
            else
                userControl1.CheckBoxSelectedTime_Value = true;
        }

       
    }
}
