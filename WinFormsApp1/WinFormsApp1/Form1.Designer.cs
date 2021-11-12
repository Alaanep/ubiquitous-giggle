
namespace WinFormsApp1
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
            this.btn_hello = new System.Windows.Forms.Button();
            this.lbl_hello = new System.Windows.Forms.Label();
            this.btn_change_color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hello
            // 
            this.btn_hello.Location = new System.Drawing.Point(409, 66);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(256, 99);
            this.btn_hello.TabIndex = 0;
            this.btn_hello.Text = "Hello Message";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Location = new System.Drawing.Point(881, 314);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(0, 25);
            this.lbl_hello.TabIndex = 1;
            // 
            // btn_change_color
            // 
            this.btn_change_color.Location = new System.Drawing.Point(756, 66);
            this.btn_change_color.Name = "btn_change_color";
            this.btn_change_color.Size = new System.Drawing.Size(251, 99);
            this.btn_change_color.TabIndex = 2;
            this.btn_change_color.Text = "Change Color";
            this.btn_change_color.UseVisualStyleBackColor = true;
            this.btn_change_color.Click += new System.EventHandler(this.btn_change_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 450);
            this.Controls.Add(this.btn_change_color);
            this.Controls.Add(this.lbl_hello);
            this.Controls.Add(this.btn_hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.Button btn_change_color;
    }
}

