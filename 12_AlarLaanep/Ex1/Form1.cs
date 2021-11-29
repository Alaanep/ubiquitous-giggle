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

namespace Ex1
{
    public partial class Form1 : Form
    {
        private string filePath="";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string textBoxValue = textBox_fileName.Text;
            if (String.IsNullOrEmpty(textBoxValue))
            {
                string message = "Filling out file name is mandatory!";
                string caption = "Please fill out file name!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            } else
            {
                
                saveFile("male", textBoxValue);
                saveFile("female", textBoxValue);
            }
            
        }

        private void saveFile(string gender, string fileName)
        {
            string fullPath = Path.Combine(filePath, $"{fileName}_{gender}.txt");

            if (CheckIfFileExists(fullPath))
            {
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    for (int r = 0; r < dataGridView1.RowCount - 1; r++)
                    {
                        if ((string)dataGridView1.Rows[r].Cells[1].Value == gender)
                        {
                            for (int c = 0; c < dataGridView1.ColumnCount; c++)
                            {
                                if (dataGridView1.Rows[r].Cells[c].Value != null && c != 1)
                                {
                                    if (c == 2)
                                    {
                                        try
                                        {
                                            if ((bool)dataGridView1.Rows[r].Cells[c].Value == false)
                                            {
                                                writer.Write("- Did not like ");
                                            }
                                            else
                                            {
                                                writer.Write("- Liked ");
                                            }
                                        }
                                        catch (Exception ex)
                                        {

                                        }

                                    }
                                    else
                                    {
                                        writer.Write(dataGridView1.Rows[r].Cells[c].Value + " ");
                                    }
                                }
                                else if ((c != 1 && c == 2 && dataGridView1.Rows[r].Cells[c].Value == null))
                                {
                                    writer.Write("- Did not like ");
                                }
                            }
                            writer.WriteLine("");
                        }
                    }
                }
            }
        }

        private bool CheckIfFileExists(string fullPath)
        {
            if (File.Exists(fullPath))
            {
                DialogResult result = MessageBox.Show(fullPath + " already exists. \nOverwrite?", "Important Question", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    
                    MessageBox.Show(fullPath + " Saved!");
                    return true;

                }
                else
                {
                    MessageBox.Show("File is not saved!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show(fullPath + " Saved!");
                return true;
            }
        }

        private void button_ChooseFolder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                filePath = folderBrowserDialog1.SelectedPath;
                label_showFolder.Text = filePath;
            }
        }
    }
}
