using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGraphics
{
    public partial class Form1 : Form
    {

        private System.Drawing.Bitmap myBitmap; // Our Bitmap declaration
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj = e.Graphics;

            graphicsObj.DrawImage(myBitmap, 0, 0, myBitmap.Width, myBitmap.Height);

            graphicsObj.Dispose(); ;

            /*graphicsObj = this.CreateGraphics();
            
            Pen pen = new Pen(System.Drawing.Color.Red, 5);
            graphicsObj.DrawLine(pen, 20, 20, 200, 210);
            Rectangle rectangle = new Rectangle(20, 20, 250, 200);
            graphicsObj.DrawRectangle(pen, rectangle);
            rectangle.Inflate(10, -20);
            graphicsObj.DrawRectangle(pen, rectangle);
            graphicsObj.DrawEllipse(pen, rectangle);

            Font myFont = new System.Drawing.Font("Helvetica", 40, FontStyle.Italic);

            Brush myBrush = new SolidBrush(System.Drawing.Color.Red);

            graphicsObj.DrawString("Hello C#", myFont, myBrush, 300, 300);*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics graphicsObj;
            myBitmap = new Bitmap(this.ClientRectangle.Width,
           this.ClientRectangle.Height,
          System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            graphicsObj = Graphics.FromImage(myBitmap);

            graphicsObj.Clear(Color.White); // Set Bitmap background to white

            Pen myPen = new Pen(System.Drawing.Color.Plum, 3);
            Rectangle rectangleObj = new Rectangle(10, 10, 200, 200);
            graphicsObj.DrawEllipse(myPen, rectangleObj);
            graphicsObj.Dispose();
        }
    }
}
