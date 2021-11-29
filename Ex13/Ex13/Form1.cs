using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ex13
{
    public partial class Form1 : Form
    {
        //ball global variables
        private int ballX;
        private int ballY;
        private int ballDiameter = 20;
        private int rightLimit;
        private int bottomLimit;
        private int topLimit = 0;
        private int leftLimit = 0;
        private Boolean horisontalDirection = false; //false - moving right, true - moving left
        private Boolean verticalDirection = false; //false - moving down, true = moving up
        private int rectangleX;
        private int rectangleY;
        private int rectangleHeight = 40;
        private int rectangleWidth = 40;
        private Rectangle rectangle;
        private Rectangle ballRectangle;
        private int countLeftEdgeCollision = 0;
        private int ballSpeed = 10;
        private int lives = 3;
        private int score = 0;
        private int maxScore = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            textBox_lives.Text = lives.ToString();
            textBox_RectangleSize.Text = rectangleHeight.ToString();
            textBox_BallSpeed.Text = "3";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            bottomLimit = pictureBox1.ClientSize.Height - ballDiameter;
            rightLimit = pictureBox1.ClientSize.Width - ballDiameter;
            ballX = random.Next(0, rightLimit);
            ballY = random.Next(0, bottomLimit);
            rectangleY = pictureBox1.ClientSize.Height / 2 - rectangleHeight / 2;

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Brush brush = new SolidBrush(Color.Black);
            ballRectangle = new Rectangle(ballX, ballY, ballDiameter, ballDiameter);
            graphics.FillEllipse(brush, ballRectangle);
            rectangle = new Rectangle(rectangleX, rectangleY, rectangleWidth, rectangleHeight);
            graphics.FillRectangle(brush, rectangle);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lives > 0)
            {
                UpdateBallCoordinates();
                UpdateScore();
                if (rectangle.IntersectsWith(ballRectangle))
                {
                    horisontalDirection = false;
                    ballX += 10;
                    UpdateScore();
                }
                Refresh();
            } else
            {
                timer1.Stop();
                label_GameOver.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                maxScore = GetMaxScore();
                label_MaxScore.Text = maxScore.ToString();
                
                if (score > maxScore)
                {
                    UpdateMaxScore();
                    label_yourscore.Text = "New high score: " + score.ToString();
                } else
                {
                    label_yourscore.Text = score.ToString();
                }

            }
        }

        private void UpdateScore()
        {
            score = score +  200/rectangleHeight;
            label_Score.Text = score.ToString() ;
        }

        private void UpdateBallCoordinates()
        {
            //horisontal bounce
            if (ballX < rightLimit && horisontalDirection == false)
            {
                if (ballX + ballSpeed > rightLimit)
                {
                    ballX = rightLimit;
                } else
                {
                    ballX += ballSpeed;
                }
                if (ballX == rightLimit)
                {

                    horisontalDirection = true;
                }
            }
            else if (ballX > leftLimit && horisontalDirection == true)
            {
                if (ballX - ballSpeed < leftLimit)
                {
                    ballX = leftLimit;
                } else
                {
                    ballX -= ballSpeed;
                }
                if (ballX == leftLimit)
                {
                    lives--;
                    label_LivesLeft.Text = lives.ToString();

                    horisontalDirection = false;
                }
            }

            //vertical bounce
            if (ballY < bottomLimit && verticalDirection == false)
            {
                if (ballY + ballSpeed > bottomLimit)
                {
                    ballY = bottomLimit;
                }
                else
                {
                    ballY += ballSpeed;
                }
                if (ballY == bottomLimit)
                {
                    verticalDirection = true;
                }
            }
            else if (ballY > topLimit && verticalDirection == true)
            {
                if (ballY - ballSpeed < topLimit)
                {
                    ballY = topLimit;
                }
                else
                {
                    ballY -= ballSpeed;
                }
                if (ballY == topLimit)
                {
                    verticalDirection = false;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                if (rectangleY - 10 > 0)
                {
                    rectangleY -= 4;
                } else
                {
                    rectangleY = 0;
                }

            } else if (e.KeyCode == Keys.Down)
            {

                if (rectangleY + 10 > pictureBox1.ClientSize.Height - rectangleHeight)
                {
                    rectangleY = pictureBox1.ClientSize.Height - rectangleHeight;
                } else
                {
                    rectangleY += 4;
                }

            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if(CheckLivesInput() && CheckBallSpeedInput() && CheckRectangleHeight()){
                label_LivesLeft.Text = lives.ToString(); ;
                button_Start.Enabled = false;
                timer1.Start();
            }
            
            
        }

        private bool CheckRectangleHeight()
        {
            try
            {   
                if(int.Parse(textBox_RectangleSize.Text)<0 || int.Parse(textBox_RectangleSize.Text) > pictureBox1.ClientSize.Height)
                {
                    MessageBox.Show("Invalid value for rectangle size. Rectangle cant be negative nor bigger than "+ pictureBox1.ClientSize.Height);
                } else
                {
                    rectangleHeight = int.Parse(textBox_RectangleSize.Text);
                    textBox_RectangleSize.Enabled = false;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value for rectangle height.");
            }
            return false;
        }

        private bool CheckBallSpeedInput()
        {
            try
            {
                if (int.Parse(textBox_BallSpeed.Text) < 1 || int.Parse(textBox_BallSpeed.Text) > 5)
                {
                    MessageBox.Show("Invalid value for ball speed. Ball speed must be set between 1-5");
                } else
                {
                    ballSpeed = ballSpeed + int.Parse(textBox_BallSpeed.Text);
                    textBox_BallSpeed.Enabled = false;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value for ball speed.");
            }
            return false;
        }

        private bool CheckLivesInput()
        {
            try
            {
                if (int.Parse(textBox_lives.Text) < 0 || int.Parse(textBox_lives.Text) > 5)
                {
                    MessageBox.Show("Invalid value for lives. Lives must be set between 1-5");
                }else
                {
                    lives = int.Parse(textBox_lives.Text);
                    textBox_lives.Enabled = false;
                    return true;
                }       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value for lives.");
            }
            return false;
        }

        private int GetMaxScore()
        {
            using(StreamReader reader = new StreamReader("max_score.txt"))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    maxScore = int.Parse(line);
                    return maxScore;
                }
            }
            return 0;
        }

        private void UpdateMaxScore()
        {
            using(StreamWriter writer = new StreamWriter("max_score.txt"))
            {
                writer.WriteLine(score);
            }
        }
    }
}
