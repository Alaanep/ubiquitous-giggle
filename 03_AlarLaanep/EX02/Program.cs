using System;
using System.IO;
using System.Collections.Generic;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> readWords = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader("readFrom.txt"))
                {
                    string line;
                    //Read line by line
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        readWords.Add(line);
                    }
                };
            } catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            
            
            try { 
                using (StreamWriter writer = new StreamWriter("result.txt"))
                { 
                    //counter for item numbers
                    int counter = 1;
                    //loop over list of readWord starting from end of list
                    for (int i = readWords.Count - 1; i >= 0; i--)
                    {
                        //write item nr + list item into file
                        writer.WriteLine($"{counter}. {readWords[i]}");
                        counter++;
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
