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

namespace ex1
{
    public partial class Form1 : Form
    {

        private string filePath="";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string fileName = textBox_FileName.Text;
            if (string.IsNullOrEmpty(fileName))
            {
                string message = "Filling out file name is mandatory!";
                string caption = "Please fill out file name!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                label_status.Text = "Please fill out file name!";
            } 
            //filename exists, combmine filepath and filename
            else
            {
                fileName = fileName + ".txt";
                string fullPath = Path.Combine(filePath, fileName);
                
                if (File.Exists(fullPath))
                {

                    DialogResult result = MessageBox.Show(fileName +" already exists " +"in " +filePath+"\nOverwrite?", "Important Question", MessageBoxButtons.YesNo) ;
                    if(result == DialogResult.Yes)
                    {
                        SaveFile(fullPath);
                        label_status.Text = "File Saved";

                    } else
                    {
                        label_status.Text = "Saving failed";
                    }

                } else
                {
                    SaveFile(fullPath);
                    label_status.Text = "File Saved";
                }
                
            }
            
        }

        private void SaveFile(string fileName)
        {
            using(StreamWriter writer = new StreamWriter(fileName))
            {
                //get every row from datagridview
                for(int r = 0; r<dataGridView1.RowCount; r++)
                {
                    //get every cell from every row
                    for(int c = 0; c < dataGridView1.ColumnCount; c++)
                    {
                        //if cells is not empty then write its contents
                        if (dataGridView1.Rows[r].Cells[c].Value != null)
                        {
                            writer.Write(dataGridView1.Rows[r].Cells[c].Value+ " ");
                        }
                        //checkbox is checked then write "yes", c==1 means that it is checkbox column
                        else if (c==1 && dataGridView1.Rows[r].Cells[c].Value==null)//
                        {
                            writer.Write("No");//means thats it is unchecked checkbox
                        }
                        //if cell is empty then write ""
                        else
                        {
                            writer.Write(" ");
                        }                                                
                    }
                    writer.WriteLine(); // end of row, add line break
                    

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)//user pressed ok
            {
                filePath = folderBrowserDialog1.SelectedPath;
                label_ChooseFolder.Text = filePath;
                label_ChooseFolder.Visible = true;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < dataGridView1.RowCount; r++)
            {
                //get every cell from every row
                for (int c = 0; c < dataGridView1.ColumnCount; c++)
                {
                    dataGridView1.Rows[r].Cells[c].Value = DBNull.Value;
                }
            }
            textBox_FileName.Text = string.Empty;
            folderBrowserDialog1.SelectedPath = "";
            label_ChooseFolder.Text = string.Empty;


            label_status.Text = "Values cleared";
        }
    }
}
