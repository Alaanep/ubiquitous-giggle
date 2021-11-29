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

namespace _13_AlarLaanep
{
    public partial class Form1 : Form
    {

        private Random random = new Random();

        //global variables picturebox for limits
        private int leftLimit;
        private int rightLimit;
        private int topLimit;
        private int bottomLimit;

        //red ball global variables
        private int ballX;
        private int ballY;
        private int ballDiameter;
        private bool horisontalDirection;
        private bool verticalDirection;
        private int ballSpeed;
        private Rectangle ballRectangle;
            
        //black rectangle global variables
        private Rectangle rectangle;
        private int rectangleX;
        private int rectangleY;
        private int rectangleHeight;
        private int rectangleSpeed;

        //global bonusball variables
        private int bonusRectangleX;
        private int bonusRectangleY;
        private Rectangle bonusRectangle;
        private bool showBonusRectangle;
        private int catchedRandomBall;

        //global variables for game
        private int lives = 3;
        private int score = 0;
        private List<int> maxScores = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initalize random ball
            ballDiameter = 60;
            ballSpeed = 50;

            //set picturebox limits;
            bottomLimit = pictureBox1.ClientSize.Height - ballDiameter;
            rightLimit = pictureBox1.ClientSize.Width - ballDiameter;
            topLimit = 0;
            leftLimit = 0;
            horisontalDirection = false;
            verticalDirection = false;

            //set timer intervals
            timer1.Interval = 100; // for main game
            timer2.Interval = 3000; // for bonus ball
            

            //initialize rectangle
            rectangleHeight = 30;
            rectangleSpeed = 7;

            //make sure rectangle and ball are not overlapping
            SetRandomRectangleAndBallCoordinates();

            //labels
            label_livesleft.Text = lives.ToString();
            label_GameOver.Visible = false;
            label_Score.Text= score.ToString();
            label_MaxScores.Visible = false;
            label_finalscore.Visible = false;
            label5.Visible = false;

            //textboxes
            textBox_BallSize.Text = ballDiameter.ToString();
            textBox_BallSpeed.Text = "1";
        }

        private void SetRandomRectangleAndBallCoordinates()
        {
            ballX = random.Next(0, pictureBox1.ClientSize.Width - ballDiameter);
            ballY = random.Next(0, pictureBox1.ClientSize.Height - ballDiameter);
            rectangleX = random.Next(0, pictureBox1.ClientSize.Width - rectangleHeight);
            rectangleY = random.Next(0, pictureBox1.ClientSize.Height - rectangleHeight);
            if ((rectangleX > ballX + ballDiameter || rectangleX + rectangleHeight < ballX) || (rectangleY > ballY + ballDiameter || rectangleY + rectangleHeight < ballY))
            {
                label_livesleft.Text = "NOT OVERLAPPING";
            }
            else
            {
                label_livesleft.Text = "overlapping";
                SetRandomRectangleAndBallCoordinates();
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Brush redBrush = new SolidBrush(Color.Red);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush randomColor = new SolidBrush(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
            ballRectangle = new Rectangle(ballX, ballY, ballDiameter, ballDiameter);
            graphics.FillEllipse(redBrush, ballRectangle);
            rectangle = new Rectangle(rectangleX, rectangleY, rectangleHeight, rectangleHeight);
            graphics.FillRectangle(blackBrush, rectangle);

            bonusRectangle = new Rectangle(bonusRectangleX, bonusRectangleY, rectangleHeight, rectangleHeight);
            if (showBonusRectangle) { 
                graphics.FillEllipse(randomColor, bonusRectangle);
            }
        }

        private void UpdateBallCoordinates()
        {
            rightLimit = pictureBox1.ClientSize.Width - ballDiameter;
            bottomLimit = pictureBox1.ClientSize.Height - ballDiameter;
            //horisontal bounce
            if (ballX < rightLimit && horisontalDirection == false)
            {
                if (ballX + ballSpeed > rightLimit)
                {
                    ballX = rightLimit;
                }
                else
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
                }
                else
                {
                    ballX -= ballSpeed;
                }
                if (ballX == leftLimit)
                {
                    

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

        private void timer1_Tick(object sender, EventArgs e)
        {   
            if(lives > 0)
            {
                UpdateBallCoordinates();
                Refresh();
                AddAndUpdateScore();
                if (rectangle.IntersectsWith(ballRectangle))
                {
                    lives--;
                    label_livesleft.Text = lives.ToString();
                    horisontalDirection = !horisontalDirection;
                    verticalDirection = !verticalDirection;
                }
                if (rectangle.IntersectsWith(bonusRectangle))
                {
                    catchedRandomBall++;
                    AddAndUpdateScore();
                    if (catchedRandomBall == 5)
                    {
                        catchedRandomBall = 0;
                        lives++;
                        label_livesleft.Text = lives.ToString();
                    }
                }

            } else
            {
                timer1.Stop();
                timer2.Stop();
                label_GameOver.Visible = true;
                maxScores = GetMaxScore();
                DisplayMaxScores();
                SaveMaxScore();
                label_finalscore.Text = score.ToString();
                label_finalscore.Visible = true;
                label5.Visible = true;

            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

                if (rectangleY - rectangleSpeed > 0)
                {
                    rectangleY -= rectangleSpeed;
                }
                else
                {
                    rectangleY = 0;
                }

            }
            else if (e.KeyCode == Keys.Down)
            {

                if (rectangleY + rectangleSpeed > pictureBox1.ClientSize.Height - rectangleHeight)
                {
                    rectangleY = pictureBox1.ClientSize.Height - rectangleHeight;
                }
                else
                {
                    rectangleY += rectangleSpeed;
                }

            }else if(e.KeyCode == Keys.Right)
            {
                if (rectangleX + rectangleSpeed > pictureBox1.ClientSize.Width - rectangleHeight)
                {
                    rectangleX = pictureBox1.ClientSize.Width - rectangleHeight;
                } else
                {
                    rectangleX += rectangleSpeed;
                }
            } else if (e.KeyCode == Keys.Left)
            {
                if (rectangleX - rectangleSpeed < 0)
                {
                    rectangleX = 0;
                } else
                {
                    rectangleX -= rectangleSpeed;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CreateBonusRectangleCoordinates();
            showBonusRectangle = !showBonusRectangle;
        }

        private void CreateBonusRectangleCoordinates()
        {
            bonusRectangleX = random.Next(0, pictureBox1.ClientSize.Width-rectangleHeight);
            bonusRectangleY = random.Next(0, pictureBox1.ClientSize.Height - rectangleHeight);
        }

        private void button_Start_Click(object sender, EventArgs e)
        {   
            if(CheckBallSpeedInput() && CheckBallSizeInput())
            {
                timer1.Start();
                timer2.Start();
                button_Start.Enabled = false;
            }       
        }

        private bool CheckBallSizeInput()
        {
            try
            {
                if (int.Parse(textBox_BallSize.Text) < 30 || int.Parse(textBox_BallSize.Text) > 200)
                {
                    MessageBox.Show("Invalid value for ball size. Ball size cant be less than 30 nor bigger than 200");
                }
                else
                {   
                    
                    ballDiameter = int.Parse(textBox_BallSize.Text);
                    if(ballX + ballDiameter > rightLimit)
                    {
                        ballX = rightLimit - ballDiameter;
                    }

                    if (ballY + ballY > bottomLimit)
                    {
                        ballY = bottomLimit - ballDiameter;
                    }
                    textBox_BallSize.Enabled = false;
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value for ball size.");
            }
            return false;
        }

        private bool CheckBallSpeedInput()
        {
            try
            {
                if (int.Parse(textBox_BallSpeed.Text) < 1 || int.Parse(textBox_BallSpeed.Text) > 100)
                {
                    MessageBox.Show("Invalid value for ball speed. Ball speed must be set between 1-100");
                }
                else
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

        //calculate and update score
        private void AddAndUpdateScore()
        {
            score = score + (ballSpeed * ballDiameter) / 150;
            label_Score.Text = score.ToString();
        }

        //GetMaxScorefrom file
        private List<int> GetMaxScore()
        {
            try
            {
                using (StreamReader reader = new StreamReader("max_scores.txt"))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            maxScores.Add(int.Parse(line));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        
                    }
                }
                maxScores.Sort((a, b) => b.CompareTo(a));
                return maxScores;
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                maxScores.Sort((a, b) => b.CompareTo(a));
                return maxScores;
            }   
        }

        private void DisplayMaxScores()
        {
            string displayString = "Top Scores: \n";
            foreach (int score in maxScores)
            {
                displayString += $"{score}\n";

            }
            label_MaxScores.Text = displayString;
            label_MaxScores.Visible = true;
        }


        private void SaveMaxScore()
        {
            Boolean maxScoreSaved = false;
            try
            {
                using (StreamWriter writer = new StreamWriter("max_scores.txt"))
                {   
                    foreach(int item in maxScores)
                    {
                        if (score > item && !maxScoreSaved)
                        {
                            writer.WriteLine(score);
                            maxScoreSaved = true;
                        } else
                        {
                            writer.WriteLine(item);
                        }
                    }
                    
                }
            } catch(Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            
        }

    }
}
