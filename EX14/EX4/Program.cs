using System;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailUtility emailUtility = new EmailUtility();
            Console.WriteLine( emailUtility.CreateEmailAddress("ma/&ri juri test.com"));
            
        }
    }
}
