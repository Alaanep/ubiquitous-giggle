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
        private string userName = "andrestamm";
        private string passWord = "kolmastamm";
        public Form1()
        {
            InitializeComponent();
            InitializePasswordTextbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckPassword();
        }

        private void CheckPassword()
        {
            if(userName == username.Text )
            {
                if (passWord == password.Text)
                {
                    display.Text = "Correct!";
                }
                else
                {
                    display.Text = "Wrong password!";
                }
            } else
            {
                display.Text = "Wrong username!";
            }
        }

        private void InitializePasswordTextbox()
        {
            password.Text = "";
            // The password character is an asterisk.
            password.PasswordChar = '*';
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
