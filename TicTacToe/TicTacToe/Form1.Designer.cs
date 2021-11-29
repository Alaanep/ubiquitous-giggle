
namespace TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playAgainstComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.XWinCount = new System.Windows.Forms.Label();
            this.DrawCount = new System.Windows.Forms.Label();
            this.OWinCount = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.playAgainstPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.resetCountsToolStripMenuItem,
            this.playAgainstComputerToolStripMenuItem,
            this.playAgainstPlayerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // resetCountsToolStripMenuItem
            // 
            this.resetCountsToolStripMenuItem.Name = "resetCountsToolStripMenuItem";
            this.resetCountsToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.resetCountsToolStripMenuItem.Text = "Reset Counts";
            this.resetCountsToolStripMenuItem.Click += new System.EventHandler(this.resetCountsToolStripMenuItem_Click);
            // 
            // playAgainstComputerToolStripMenuItem
            // 
            this.playAgainstComputerToolStripMenuItem.Name = "playAgainstComputerToolStripMenuItem";
            this.playAgainstComputerToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.playAgainstComputerToolStripMenuItem.Text = "Play Against Computer";
            this.playAgainstComputerToolStripMenuItem.Click += new System.EventHandler(this.playAgainstComputerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1.Location = new System.Drawing.Point(48, 56);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(152, 152);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.buttonClick);
            this.A1.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.A1.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A2.Location = new System.Drawing.Point(224, 56);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(152, 152);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.buttonClick);
            this.A2.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.A2.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A3.Location = new System.Drawing.Point(408, 56);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(152, 152);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.buttonClick);
            this.A3.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.A3.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2.Location = new System.Drawing.Point(224, 248);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(152, 152);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.buttonClick);
            this.B2.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.B2.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3.Location = new System.Drawing.Point(408, 248);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(152, 152);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.buttonClick);
            this.B3.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.B3.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1.Location = new System.Drawing.Point(48, 248);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(152, 152);
            this.B1.TabIndex = 6;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.buttonClick);
            this.B1.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.B1.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3.Location = new System.Drawing.Point(408, 432);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(152, 152);
            this.C3.TabIndex = 7;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.buttonClick);
            this.C3.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.C3.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2.Location = new System.Drawing.Point(224, 432);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(152, 152);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.buttonClick);
            this.C2.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.C2.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1.Location = new System.Drawing.Point(48, 432);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(152, 152);
            this.C1.TabIndex = 9;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.buttonClick);
            this.C1.MouseEnter += new System.EventHandler(this.ButtonEnter);
            this.C1.MouseLeave += new System.EventHandler(this.ButtonLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(209, 612);
            this.label2.MinimumSize = new System.Drawing.Size(179, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 41);
            this.label2.TabIndex = 11;
            this.label2.Text = "Draw";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XWinCount
            // 
            this.XWinCount.AutoSize = true;
            this.XWinCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XWinCount.Location = new System.Drawing.Point(21, 653);
            this.XWinCount.MaximumSize = new System.Drawing.Size(179, 41);
            this.XWinCount.MinimumSize = new System.Drawing.Size(179, 41);
            this.XWinCount.Name = "XWinCount";
            this.XWinCount.Size = new System.Drawing.Size(179, 41);
            this.XWinCount.TabIndex = 13;
            this.XWinCount.Text = "0";
            this.XWinCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrawCount
            // 
            this.DrawCount.AutoSize = true;
            this.DrawCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrawCount.Location = new System.Drawing.Point(209, 653);
            this.DrawCount.MaximumSize = new System.Drawing.Size(179, 41);
            this.DrawCount.MinimumSize = new System.Drawing.Size(179, 41);
            this.DrawCount.Name = "DrawCount";
            this.DrawCount.Size = new System.Drawing.Size(179, 41);
            this.DrawCount.TabIndex = 14;
            this.DrawCount.Text = "0";
            this.DrawCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OWinCount
            // 
            this.OWinCount.AutoSize = true;
            this.OWinCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OWinCount.Location = new System.Drawing.Point(408, 653);
            this.OWinCount.MaximumSize = new System.Drawing.Size(179, 41);
            this.OWinCount.MinimumSize = new System.Drawing.Size(179, 41);
            this.OWinCount.Name = "OWinCount";
            this.OWinCount.Size = new System.Drawing.Size(179, 41);
            this.OWinCount.TabIndex = 15;
            this.OWinCount.Text = "0";
            this.OWinCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(48, 619);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(150, 31);
            this.p1.TabIndex = 16;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(408, 622);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(150, 31);
            this.p2.TabIndex = 17;
            // 
            // playAgainstPlayerToolStripMenuItem
            // 
            this.playAgainstPlayerToolStripMenuItem.Name = "playAgainstPlayerToolStripMenuItem";
            this.playAgainstPlayerToolStripMenuItem.Size = new System.Drawing.Size(296, 34);
            this.playAgainstPlayerToolStripMenuItem.Text = "Play Against Player";
            this.playAgainstPlayerToolStripMenuItem.Click += new System.EventHandler(this.playAgainstPlayerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 707);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.OWinCount);
            this.Controls.Add(this.DrawCount);
            this.Controls.Add(this.XWinCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label XWinCount;
        private System.Windows.Forms.Label DrawCount;
        private System.Windows.Forms.Label OWinCount;
        private System.Windows.Forms.ToolStripMenuItem resetCountsToolStripMenuItem;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.ToolStripMenuItem playAgainstComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playAgainstPlayerToolStripMenuItem;
    }
}

