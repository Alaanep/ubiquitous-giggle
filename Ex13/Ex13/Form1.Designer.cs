
namespace Ex13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_lives = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_BallSpeed = new System.Windows.Forms.TextBox();
            this.label_RectangleSize = new System.Windows.Forms.Label();
            this.textBox_RectangleSize = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_LivesLeft = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.label_GameOver = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_MaxScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_yourscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Pink;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 541);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_lives
            // 
            this.textBox_lives.Location = new System.Drawing.Point(940, 84);
            this.textBox_lives.Name = "textBox_lives";
            this.textBox_lives.Size = new System.Drawing.Size(150, 31);
            this.textBox_lives.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(940, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the amount of lives";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(940, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose the speed of ball";
            // 
            // textBox_BallSpeed
            // 
            this.textBox_BallSpeed.Location = new System.Drawing.Point(940, 249);
            this.textBox_BallSpeed.Name = "textBox_BallSpeed";
            this.textBox_BallSpeed.Size = new System.Drawing.Size(150, 31);
            this.textBox_BallSpeed.TabIndex = 4;
            // 
            // label_RectangleSize
            // 
            this.label_RectangleSize.AutoSize = true;
            this.label_RectangleSize.Location = new System.Drawing.Point(940, 335);
            this.label_RectangleSize.Name = "label_RectangleSize";
            this.label_RectangleSize.Size = new System.Drawing.Size(235, 25);
            this.label_RectangleSize.TabIndex = 5;
            this.label_RectangleSize.Text = "Choose the size of rectangle";
            // 
            // textBox_RectangleSize
            // 
            this.textBox_RectangleSize.Location = new System.Drawing.Point(940, 391);
            this.textBox_RectangleSize.Name = "textBox_RectangleSize";
            this.textBox_RectangleSize.Size = new System.Drawing.Size(150, 31);
            this.textBox_RectangleSize.TabIndex = 6;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(940, 505);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(112, 34);
            this.button_Start.TabIndex = 7;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lives left:";
            // 
            // label_LivesLeft
            // 
            this.label_LivesLeft.AutoSize = true;
            this.label_LivesLeft.Location = new System.Drawing.Point(104, 571);
            this.label_LivesLeft.Name = "label_LivesLeft";
            this.label_LivesLeft.Size = new System.Drawing.Size(0, 25);
            this.label_LivesLeft.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Score: ";
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Location = new System.Drawing.Point(483, 571);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(22, 25);
            this.label_Score.TabIndex = 11;
            this.label_Score.Text = "0";
            // 
            // label_GameOver
            // 
            this.label_GameOver.AutoSize = true;
            this.label_GameOver.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_GameOver.ForeColor = System.Drawing.Color.Red;
            this.label_GameOver.Location = new System.Drawing.Point(32, 174);
            this.label_GameOver.Name = "label_GameOver";
            this.label_GameOver.Size = new System.Drawing.Size(812, 186);
            this.label_GameOver.TabIndex = 12;
            this.label_GameOver.Text = "Game Over!";
            this.label_GameOver.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Max Score:";
            this.label5.Visible = false;
            // 
            // label_MaxScore
            // 
            this.label_MaxScore.AutoSize = true;
            this.label_MaxScore.Location = new System.Drawing.Point(136, 397);
            this.label_MaxScore.Name = "label_MaxScore";
            this.label_MaxScore.Size = new System.Drawing.Size(0, 25);
            this.label_MaxScore.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Your Score";
            this.label6.Visible = false;
            // 
            // label_yourscore
            // 
            this.label_yourscore.AutoSize = true;
            this.label_yourscore.Location = new System.Drawing.Point(157, 460);
            this.label_yourscore.Name = "label_yourscore";
            this.label_yourscore.Size = new System.Drawing.Size(0, 25);
            this.label_yourscore.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1205, 693);
            this.Controls.Add(this.label_yourscore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_MaxScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_GameOver);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_LivesLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.textBox_RectangleSize);
            this.Controls.Add(this.label_RectangleSize);
            this.Controls.Add(this.textBox_BallSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_lives);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_lives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_BallSpeed;
        private System.Windows.Forms.Label label_RectangleSize;
        private System.Windows.Forms.TextBox textBox_RectangleSize;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_LivesLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Label label_GameOver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_MaxScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_yourscore;
    }
}

