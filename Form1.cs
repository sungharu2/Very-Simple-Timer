using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTimer
{
    public partial class Form1 : Form
    {
        private bool isMove = false;
        private Point firstPoint;
        private bool isTimerRunning = false;
        private int timer_ticks = 0;
        private int hour = 0;
        private int min = 0;
        private int sec = 0;
        private String strSec = "00";
        private String strMin = "00";
        private String strHour = "00";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void main_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            firstPoint = new Point(e.X, e.Y);
        }

        private void pnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
                Location = new Point(this.Left - (firstPoint.X - e.X), this.Top - (firstPoint.Y - e.Y));
        }

        private void pnl_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void PlayOrStop_Timer(object sender, MouseEventArgs e)
        {
            // Timer Start
            if (!isTimerRunning)
            {
                mainTimer.Start();
                pbx_StartStop.Load(@"..\..\Images\Stop.png");
                isTimerRunning = true;
            }
            // Timer Stop
            else
            {
                mainTimer.Stop();
                pbx_StartStop.Load(@"..\..\Images\Start.png");
                isTimerRunning = false;
            }
        }

        private void Pause_Timer(object sender, MouseEventArgs e)
        {
            mainTimer.Stop();
            isTimerRunning = false;
            pbx_StartStop.Load(@"..\..\Images\Start.png");
            timer_ticks = 0;
            // Set Timer 00 : 00 : 00
            lb_Timer.Text = "00 : 00 : 00";
            strSec = "00";
            strMin = "00";
            strHour = "00";
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            timer_ticks++;

            sec = timer_ticks % 60;
            strSec = sec.ToString();
            if (sec < 10) strSec = "0" + strSec;

            if (sec == 0)
            {
                min = (timer_ticks / 60) % 60;
                strMin = min.ToString();
                if (min < 10) strMin = "0" + strMin;

                if (min == 0)
                {
                    hour = timer_ticks / 3600;
                    strHour = hour.ToString();
                    if (hour < 10) strHour = "0" + strHour;

                    if (hour > 99)
                    {
                        MessageBox.Show("99시간 초과는 카운트되지 않습니다.");
                    }
                }
            }

            lb_Timer.Text = strHour + " : " + strMin + " : " + strSec;
        }

        private void pbx_Close(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
