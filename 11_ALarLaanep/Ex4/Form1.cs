using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        private int _minutes;
        private int _seconds;
        private string[] time;
        private TimeSpan timeleft;
       

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000; 
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            updateTimeLeft();
            timer1.Start();
            textBoxDisplay.ForeColor = Color.Black;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
           if(timeleft.TotalSeconds > 0)
           {
                timeleft = timeleft - new TimeSpan(10000000);
                textBoxDisplay.Text = timeleft.ToString("mm':'ss");
           } else
            {
                timer1.Stop();
                textBoxDisplay.ForeColor = Color.Red;
            }   
        }

        private void updateTimeLeft()
        {   
            try
            {
                time = textBoxDisplay.Text.Split(":");
                _minutes = int.Parse(time[0]);
                if (_minutes > 59)
                {
                    _minutes = 59;
                }
                _seconds = int.Parse(time[1]);
                if(_seconds > 59)
                {
                    _seconds = 59;
                }
                timeleft = new TimeSpan(0, _minutes, _seconds);
            } catch(FormatException e)
            {
                timeleft = new TimeSpan(0, 0, 0);
                textBoxDisplay.Text = "00:00";
            }
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "00:00";
            timeleft = new TimeSpan(0, 0, 0);
            textBoxDisplay.ForeColor = Color.Black;
        }
    }
}
