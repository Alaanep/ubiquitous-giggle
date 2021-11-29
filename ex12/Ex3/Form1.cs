using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void DrawEllipse()
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj = CreateGraphics();
            graphicsObj.Clear(BackColor);
            graphicsObj = this.CreateGraphics();
            Pen pen = new Pen(System.Drawing.Color.Red, 5);
            Rectangle rectangle = new Rectangle(this.ClientSize.Width / 2 - this.ClientSize.Width / 4, this.ClientSize.Height / 2 - this.ClientSize.Height / 4, this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            graphicsObj.DrawEllipse(pen, rectangle);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
