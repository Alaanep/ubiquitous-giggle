using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = x turn, false = y turn
        bool playAgainstComputer = true;
        int turnCount = 0;
        //static string player1, player2;

        public Form1()
        {
            InitializeComponent();
            p1.Text = "Player1";
            p2.Text = "COMPUTER";
        }

       /* public static void SetPlayerNames(string n1, string n2)
        {
            player1 = n1;
            player2 = n2;
        }*/

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Alar", "Tic Tac Toe about");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClick(object sender, EventArgs e)
        {   
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            } else
            {
                button.Text = "O";
            }
            turn = !turn;
            turnCount++;
            button.Enabled = false;
            CheckForWinner();


            if ((!turn)&& (playAgainstComputer))
            {
                ComputerMakesMove();
            }
            
        }

        private void ComputerMakesMove()
        {
            //priority 1  get tic tac toe
            //priority 2 block x tic tac toe
            //priority 3 go for a corner space
            //priority 4 pick open space

            Button move = null;
            move = LookForAWinOrBlock("O");//look for a win
            if (move == null)
            {
                move = LookForAWinOrBlock("X");//look for a block
                if(move == null)
                {
                    move = LookForACornerSpace();
                    if(move == null)
                    {
                        move = LookForAOpenSpace();
                    }
                }
            }
            if (move != null)
            {
                move.PerformClick();
            }
            
        }

        private Button LookForAOpenSpace()
        {
            Button b = null;
            foreach(Control control in Controls)
            {
                b = control as Button;
                if (b != null)
                {
                    if (b.Text == "")
                    {
                        return b;
                    }
                }
            }
            return null;
        }

        private Button LookForACornerSpace()
        {
            if (A1.Text == "O")
            {
                if (A3.Text == "") return A3;
                if(C3.Text == "") return C3;
                if (C1.Text == "") return C1;
            }
            if (A3.Text == "O")
            {
                if (A1.Text == "") return A1;
                if (C3.Text == "") return C3;
                if (C1.Text == "") return C1;
            }
            if (C3.Text == "O")
            {
                if (A1.Text == "") return A1;
                if (A3.Text == "") return A3;
                if (C1.Text == "") return C1;
            }
            if (C3.Text == "O")
            {
                if (A1.Text == "") return A1;
                if (A3.Text == "") return A3;
                if (C1.Text == "") return C1;
            }
            if (A1.Text == "") return A1;
            if (A3.Text == "") return A3;
            if (C1.Text == "") return C1;
            if (C3.Text == "") return C3;

            return null;
        }

        private Button LookForAWinOrBlock(string mark)
        {   

            //horisontal checks
            if((A1.Text == mark) && (A2.Text==mark) && (A3.Text == ""))
            {
                return A3;
            }
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
            {
                return A2;
            }
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
            {
                return A1;
            }

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
            {
                return B3;
            }
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
            {
                return B2;
            }
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
            {
                return B1;
            }

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
            {
                return C3;
            }
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
            {
                return C2;
            }
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
            {
                return C1;
            }

            //vertical checks
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
            {
                return C1;
            }
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
            {
                return B1;
            }
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
            {
                return A1;
            }

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
            {
                return C2;
            }
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
            {
                return B2;
            }
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
            {
                return A2;
            }

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
            {
                return C3;
            }
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
            {
                return B3;
            }
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
            {
                return A3;
            }

            //diagonal checks

            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
            {
                return C3;
            }
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
            {
                return B2;
            }
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
            {
                return A1;
            }


            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
            {
                return C1;
            }
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
            {
                return B2;
            }
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
            {
                return A3;
            }

            return null;

        }

        private void CheckForWinner()
        {
            bool IsWinner = false;
            
            //horisontal checks
            if ((A1.Text == A2.Text)&& (A2.Text == A3.Text) && (!A1.Enabled))
            {
                IsWinner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                IsWinner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                IsWinner = true;
            }
            //vertical checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                IsWinner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                IsWinner = true;
            }
            else if ((A3.Text == B3.Text) && (A3.Text == C3.Text) && (!A3.Enabled))
            {
                IsWinner = true;
            }
            //diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                IsWinner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                IsWinner = true;
            }

            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("Draw", "Bummer");
                    DrawCount.Text = (int.Parse(DrawCount.Text) + 1).ToString();
                }
            }
            if (IsWinner)
            {
                DisableButtons();
                string winner = "";
                if (turn)
                {
                    winner = p2.Text;
                    XWinCount.Text = (int.Parse(XWinCount.Text)+1).ToString();
                } else
                {
                    winner = p1.Text ;
                    OWinCount.Text = (int.Parse(OWinCount.Text) + 1).ToString();
                }
                MessageBox.Show($"{winner} is winner");
            }
        }
        private void DisableButtons()
        {
            foreach(Control c in Controls)
            {
                try { 
                Button b = (Button)c;
                b.Enabled = false;
                } catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        private void ButtonEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                if (turn)
                {
                    button.Text = "X";
                }
                else
                {
                    button.Text = "O";
                }
            }
            
        }

        private void ButtonLeave(object sender, EventArgs e)
        {   
            
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.Text = "";
            }
            
        }

        private void resetCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XWinCount.Text = "0";
            OWinCount.Text = "0";
            DrawCount.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Form2 f2 = new Form2();
            f2.ShowDialog();
            p1.Text = player1;
            p2.Text = player2;*/
        }

        private void playAgainstComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playAgainstComputer = true;
            p2.Text = "COMPUTER";
        }

        private void playAgainstPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playAgainstComputer = false;
            p2.Text = "Player2";
        }
    }
}
