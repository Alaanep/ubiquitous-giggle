using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
        }

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            int diameter = random.Next(0, this.ClientSize.Width / 15);

            int xPos = random.Next(0, this.ClientSize.Width - diameter);
            int yPos = random.Next(0, this.ClientSize.Height - diameter);
            Pen pen = new Pen(Color.Red, 3);
            Brush brush = new SolidBrush(Color.FromArgb(random.Next(0,255), random.Next(0,255),random.Next(0,255)));
            Rectangle rectangle = new Rectangle(xPos, yPos, diameter, diameter);
            graphics.FillEllipse(brush, rectangle);


 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
