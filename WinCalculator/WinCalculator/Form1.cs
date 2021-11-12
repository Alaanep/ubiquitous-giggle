using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operationPress = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text += "1";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || operationPress==true) result.Clear();
            operationPress = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + button.Text;
            } else 
                result.Text = result.Text + button.Text;
            this.ActiveControl = null;
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            this.ActiveControl = null;
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (value != 0)
            {
                equals.PerformClick();
                operationPress = true;
                operation = button.Text;
                equation.Text = value + " " + operation;
            } else
            {
                operation += button.Text;
                value = double.Parse(result.Text);
                operationPress = true;
                equation.Text = value + " " + operation;
            }
             

        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = Double.Parse(result.Text);
            operation = "";

            
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
            this.ActiveControl = null;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "=":
                    equals.PerformClick();
                    break;
                case " ":
                    equals.PerformClick();
                    break;
                case "\r":
                    equals.PerformClick();
                    break;
                default:
                    break;


            }
        }
    }
}
