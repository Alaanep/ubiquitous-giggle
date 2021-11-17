using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            var pos = this.PointToScreen(label1.Location);
            pos = pictureBox1.PointToClient(pos);
            label1.Parent = pictureBox1;
            label1.Location = pos;
            label1.BackColor = Color.Transparent;

           
            
        }

        DateTime nextChristmas = new DateTime(2021, 12, 24, 19, 00, 00, 00, DateTimeKind.Utc);
        



        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeDifference = nextChristmas - System.DateTime.UtcNow;
            label1.Text =$"Until Christmas: \n{timeDifference.Days} DAYS: {timeDifference.Hours} HOURS: {timeDifference.Minutes}MINUTES: {timeDifference.Seconds}.{timeDifference.Milliseconds}SECONDS:"; timeDifference.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
