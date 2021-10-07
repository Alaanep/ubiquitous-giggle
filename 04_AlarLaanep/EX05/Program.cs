using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mixedSalaries = new List<string>();
            List<string> processedSalaries = new List<string>();
            mixedSalaries = FileReader("input.txt");
            processedSalaries = ProcessSalaries(mixedSalaries);
            FileWriter(processedSalaries, "output.txt", false);
        }

        //process mixed salaries and return processed list

        public static List<string> ProcessSalaries(List<string> salaries)
        {
            List<string> processedSalaries = new List<string>();
            double total=0;

            foreach(string item in salaries)
            {
                //if salary starts with N
                if (item[0] == 'N')
                {
                    //following chars in string are numbers
                    if (item.Substring(1).All(char.IsDigit)){
                        //take the numbers part and add to processedSalaries
                        processedSalaries.Add(item.Substring(1));
                        //parse to int and add amount to total;
                        total += Convert.ToInt32(item.Substring(1).ToString());
                    }
                }
                //if salary starts with G
                else if (item[0] == 'G')
                {
                    //following chars in string are numbers
                    if (item.Substring(1).All(char.IsDigit))
                    {
                        //take the numbers part, calculate net salary and add it to processesSalaries
                        int grossSalary = Convert.ToInt32(item.Substring(1).ToString());
                        double netSalary = CalculateNetSalary(grossSalary);
                        processedSalaries.Add($"{netSalary}");
                        //parse to int and add amount to total;
                        total += netSalary;
                    }
                }
                //if invalid value
                else
                {
                    //concatenate "invalid: " and add to processedSalaries
                    processedSalaries.Add($"invalid: {item}");
                }
            }
            //add total sum of salaries to the processedsalaries
            processedSalaries.Add($"Sum is: {total}");
            return processedSalaries;
        }


        //method for writing from list into the file
        public static void FileWriter(List<string> myList, string fileName, bool append)
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

        //method for reading content of file, saves filecontent to list and returns it
        public static List<string> FileReader(string fileName)
        {
            List<string> fileContent = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        fileContent.Add(line);
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return fileContent;
        }

        //calculate netsalary from gross salary
        public static double CalculateNetSalary(int grossSalary)
        {
            return grossSalary - (grossSalary * 0.25);
        }
    }
}
