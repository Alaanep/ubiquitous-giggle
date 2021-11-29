using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        private Point previousPoint;
        private Point currentPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Color.DarkViolet, 5);
            
            if(!previousPoint.IsEmpty)
            {
                currentPoint = new Point(e.X, e.Y);
                graphics.DrawLine(pen, previousPoint, currentPoint);
                previousPoint = currentPoint;
                
            } else
            {
                previousPoint = new Point(e.X, e.Y);
            }

            
        }

        private void DrawLine()
        {

        }
    }
}
