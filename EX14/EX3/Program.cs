using System;
using System.IO;


namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] synnid = new string[12];
            string[] surmad = new string[12];
            string[] months = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun","Jul","Aug","Sep","Oct","Nov","Dec" };

            ReadFromFile("synnid_3.txt", synnid);
            ReadFromFile("surmad_3.txt", surmad);


            for (int i = 0; i < synnid.Length; i++)
            {
                int populationGrowth =  int.Parse(synnid[i]) - int.Parse(surmad[i]);
                Console.WriteLine($"{months[i]}: {populationGrowth}");
                if (populationGrowth > 0)
                {
                    Console.WriteLine($"Population growth was positive in {months[i]}.");
                }
            }
            
            
        }

        static void ReadFromFile(string filename, string[] arr)
        {
            using(StreamReader reader = new StreamReader(filename))
            {
                int i = 0;
                string line;
                while((line=reader.ReadLine()) != null)
                {
                    arr[i] = line;
                    i++;
                }
            }
        }
    }
}
