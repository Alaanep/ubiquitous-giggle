using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JsonSerializer.Serialize("ש"));
            string fileName = "eureka.txt";
            string text = "Eureka";
            string hebrewText = "כושﬨ";

            File.WriteAllText("elephant1.txt", "\uD83D\uDC18");
            File.WriteAllText("elephant2.txt", "\U0001F418");

            File.WriteAllText(fileName, hebrewText);
            byte[] eurekaBytes = File.ReadAllBytes(fileName);
            foreach(byte b in eurekaBytes)
            {
                //Console.Write("{0} ", b);
                Console.Write("{0:x2} ", b);
            }
            Console.WriteLine(Encoding.UTF8.GetString(eurekaBytes));

        }
    }
}
