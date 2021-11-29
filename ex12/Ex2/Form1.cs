using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        public void DrawLine()
        {
            Graphics graphics = CreateGraphics();
            graphics.Clear(BackColor);
            Pen pen = new Pen(Color.Purple, 10);
            Point a = new Point(10, this.ClientSize.Height / 2);
            Point b = new Point(this.ClientSize.Width - 10, this.ClientSize.Height / 2);
            graphics.DrawLine(pen, a, b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawLine();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            DrawLine();
        }
    }
}
