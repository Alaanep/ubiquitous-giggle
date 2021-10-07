using System;
using System.IO;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("questions.txt"))
            {
                using (StreamWriter writer = new StreamWriter("answers.txt", true))
                {
                    string line;
                    int countAnswers = 0;
                    while((line = reader.ReadLine())!=null)
                    {
                        
                        Console.WriteLine(line);
                        writer.WriteLine(line);
                        if (countAnswers == 0)
                        {
                            writer.WriteLine($"My name is {Console.ReadLine()}");
                        } else
                        {
                            writer.WriteLine($"{countAnswers}. {Console.ReadLine()}");
                        }
                        countAnswers++;
                    }
                }
            }
        }
    }
}
