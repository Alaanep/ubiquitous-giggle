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
  
        private int topLimit;
        private int bottomLimit;
        private int leftLimit;
        private int rightLimit;

        int step= 50;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 400;
            flyingLabel.Text = $"Left: {flyingLabel.Left.ToString()} TOp: {flyingLabel.Top.ToString()}\n formwidth: {rightLimit} formheight: {bottomLimit}";
            rightLimit = this.ClientSize.Width - flyingLabel.Width- step-20;
            bottomLimit = this.ClientSize.Height - flyingLabel.Height - step - 20;
            leftLimit = 20;
            topLimit = 20;
            flyingLabel.Top = topLimit;
            flyingLabel.Left = leftLimit;
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveLabel();
        }

        private void MoveLabel()
        {
            if (flyingLabel.Left < rightLimit && flyingLabel.Top==topLimit)
            {
                MoveRight();
            }
            else if(flyingLabel.Top < bottomLimit && flyingLabel.Left == rightLimit)
            {
                MoveDown();
            }
            else if(flyingLabel.Left>leftLimit && flyingLabel.Top == bottomLimit)
            {
                MoveLeft();
            }
            else if(flyingLabel.Top>topLimit && flyingLabel.Left == leftLimit)
            {
                MoveUp();
            }
                
            flyingLabel.Text = $"Left: {flyingLabel.Left.ToString()} TOp: {flyingLabel.Top.ToString()}\n formwidth: {rightLimit} formheight: {bottomLimit}";

        }

        private void MoveUp()
        {
            if (flyingLabel.Top - step < topLimit)
            {
                flyingLabel.Top = topLimit;
            }
            else
            {
                flyingLabel.Top -= step;
            }
        }

        private void MoveLeft()
        {
            if (flyingLabel.Left - step < leftLimit)
            {
                flyingLabel.Left = leftLimit;
            } else
            {
                flyingLabel.Left -= step;
            }
        }

        private void MoveDown()
        {
            if(flyingLabel.Top+ step > bottomLimit)
            {
                flyingLabel.Top = bottomLimit;
            } else
            {
                flyingLabel.Top += step;
            }
        }

        private void MoveRight()
        {   
                if (flyingLabel.Left + step > rightLimit)
                {
                    flyingLabel.Left = rightLimit;
                }
                else
                {
                    flyingLabel.Left += step;
                }   
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            rightLimit = this.ClientSize.Width - flyingLabel.Width - step - 20;
            bottomLimit = this.ClientSize.Height - flyingLabel.Height - step - 20;
        }
    }
}
