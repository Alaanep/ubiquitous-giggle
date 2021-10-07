using System;
using System.Collections.Generic;
using System.IO;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> beginnings;
            List<string> results = new List<string>();           
            beginnings = FileReader("beginnings.txt");
            foreach(string item in beginnings)
            {
                results.Add(GenerateCode(item));
            }
            FileWriter(results, "results.txt", false);

        }

        public static string GenerateCode(string codeBeginning)
        {
            string code = codeBeginning;

            if (code.Length > 6)
            {
                return code.Substring(0, 6);
            }
            const int CODELENGTH = 6;
            int lettersToAdd = CODELENGTH - codeBeginning.Length;
            Random rnd = new Random();

            for(int i = 0; i< lettersToAdd;i++)
            {
                if(code.Contains("x"))
                {
                    code += '0';
                }
                else
                {
                    code += rnd.Next(0, 10);
                }   
            }

            //todo create for loop to add required amount of "0" to the end of code

            return code;
        }

        //FileReader
        public static List<string> FileReader(string filename)
        {
            List<string> beginnings = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        beginnings.Add(line);
                    }
                }
            }catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return beginnings;

        }

        //method for writing from list into the file
        static void FileWriter(List<string> myList, string fileName, bool append)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, append))
                {
                    foreach (string line in myList)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
