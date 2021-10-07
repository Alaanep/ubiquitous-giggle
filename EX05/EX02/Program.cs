using System;
using System.IO;
namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFromFile("text.txt");
        }

        public static void ReadFromFile(string fileName)
        {
            try { 
            using(StreamReader reader = new StreamReader(fileName))
            {
            }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Cannot read from file: ");
                Console.WriteLine("Please check if your file exists in location: ");
                Console.WriteLine(ex.FileName);
                
                
            }
        }
    }
}
