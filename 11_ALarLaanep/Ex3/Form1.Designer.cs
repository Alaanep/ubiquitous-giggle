
namespace Ex3
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
            this.flyingLabel = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // flyingLabel
            // 
            this.flyingLabel.AutoSize = true;
            this.flyingLabel.Location = new System.Drawing.Point(45, 52);
            this.flyingLabel.Name = "flyingLabel";
            this.flyingLabel.Size = new System.Drawing.Size(101, 25);
            this.flyingLabel.TabIndex = 0;
            this.flyingLabel.Text = "Flying label";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(294, 304);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(250, 146);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(684, 304);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(250, 146);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 839);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.flyingLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label flyingLabel;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer timer1;
    }
}

