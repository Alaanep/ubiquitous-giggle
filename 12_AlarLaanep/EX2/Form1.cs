using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {

        int topLimit = 0;
        int bottomLimit;
        int rightLimit;
        Random random = new Random();
        Point a = new Point(0, 0);
        Point b;
        int x = 0;
        int y = 0;
        bool direction = false; // false down, up true

        public Form1()
        {
            InitializeComponent();
            rightLimit = this.ClientSize.Width;
            bottomLimit = this.ClientSize.Height;
            timer1.Interval = 300;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void CreateLine()
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255),
            (byte)random.Next(0, 255)), 4);

            if (x < rightLimit)
            {
                if (y < bottomLimit && direction == false)
                {
                    if (y + 10 > bottomLimit)
                    {
                        y = bottomLimit;
                    }
                    else
                    {
                        y = y + 10;
                    }

                    b = new Point(x, y);

                    graphics.DrawLine(pen, a, b);
                    a = b;
                }
                else if (y == bottomLimit && direction == false)
                {
                    x = x + 10;
                    b = new Point(x, y);

                    graphics.DrawLine(pen, a, b);
                    a = b;
                    direction = true;

                }
                else if (y > topLimit && direction == true)
                {
                    if (y - 10 < topLimit)
                    {
                        y = topLimit;
                    }
                    else
                    {
                        y = y - 10;
                    }
                    b = new Point(x, y);

                    graphics.DrawLine(pen, a, b);
                    a = b;
                }
                else if (y == topLimit && direction == true)
                {
                    x = x + 10;
                    b = new Point(x, y);
                    graphics.DrawLine(pen, a, b);
                    a = b;
                    direction = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CreateLine();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            rightLimit = this.ClientSize.Width;
            bottomLimit = this.ClientSize.Height;
        }
    }
}
