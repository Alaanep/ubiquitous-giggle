
namespace _13_AlarLaanep
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
            this.label_livesleft = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_GameOver = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_BallSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_BallSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.label_MaxScores = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_finalscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1460, 814);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_livesleft
            // 
            this.label_livesleft.AutoSize = true;
            this.label_livesleft.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_livesleft.Location = new System.Drawing.Point(189, 829);
            this.label_livesleft.Name = "label_livesleft";
            this.label_livesleft.Size = new System.Drawing.Size(0, 54);
            this.label_livesleft.TabIndex = 1;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 829);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lives left:";
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Start.Location = new System.Drawing.Point(1511, 703);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(234, 79);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_GameOver
            // 
            this.label_GameOver.AutoSize = true;
            this.label_GameOver.Font = new System.Drawing.Font("Segoe UI", 92F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_GameOver.ForeColor = System.Drawing.Color.Crimson;
            this.label_GameOver.Location = new System.Drawing.Point(224, 264);
            this.label_GameOver.Name = "label_GameOver";
            this.label_GameOver.Size = new System.Drawing.Size(1065, 244);
            this.label_GameOver.TabIndex = 4;
            this.label_GameOver.Text = "Game Over!";
            this.label_GameOver.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1511, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Red Ball Size";
            // 
            // textBox_BallSize
            // 
            this.textBox_BallSize.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_BallSize.Location = new System.Drawing.Point(1511, 99);
            this.textBox_BallSize.Name = "textBox_BallSize";
            this.textBox_BallSize.Size = new System.Drawing.Size(234, 61);
            this.textBox_BallSize.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1511, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ball Speed";
            // 
            // textBox_BallSpeed
            // 
            this.textBox_BallSpeed.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_BallSpeed.Location = new System.Drawing.Point(1511, 316);
            this.textBox_BallSpeed.Name = "textBox_BallSpeed";
            this.textBox_BallSpeed.Size = new System.Drawing.Size(234, 61);
            this.textBox_BallSpeed.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(765, 829);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 54);
            this.label4.TabIndex = 9;
            this.label4.Text = "Score: ";
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Score.Location = new System.Drawing.Point(911, 829);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(0, 54);
            this.label_Score.TabIndex = 10;
            // 
            // label_MaxScores
            // 
            this.label_MaxScores.AutoSize = true;
            this.label_MaxScores.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_MaxScores.Location = new System.Drawing.Point(237, 544);
            this.label_MaxScores.Name = "label_MaxScores";
            this.label_MaxScores.Size = new System.Drawing.Size(130, 54);
            this.label_MaxScores.TabIndex = 11;
            this.label_MaxScores.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(572, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 54);
            this.label5.TabIndex = 12;
            this.label5.Text = "Your Score:";
            // 
            // label_finalscore
            // 
            this.label_finalscore.AutoSize = true;
            this.label_finalscore.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_finalscore.Location = new System.Drawing.Point(588, 639);
            this.label_finalscore.Name = "label_finalscore";
            this.label_finalscore.Size = new System.Drawing.Size(0, 54);
            this.label_finalscore.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1769, 968);
            this.Controls.Add(this.label_finalscore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_MaxScores);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_BallSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_BallSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_GameOver);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_livesleft);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1791, 1024);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1791, 1024);
            this.Name = "Form1";
            this.ShowIcon = false;
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
        private System.Windows.Forms.Label label_livesleft;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_GameOver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_BallSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_BallSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Label label_MaxScores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_finalscore;
    }
}

