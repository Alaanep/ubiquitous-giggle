using System;

namespace GuysLendingMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Guys Joe = new Guys("Joe", 50);
            Guys Bob = new Guys("Bob", 100);

            while (true)
            {
                Joe.WriteMyInfo();
                Bob.WriteMyInfo();

                Console.Write("Enter a amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if(int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Joe")
                    {
                        int result = Joe.GiveCash(amount);
                        Bob.ReceiveCash(result);
                    } else if(whichGuy=="Bob")
                    {
                        int result   = Bob.GiveCash(amount);
                        Joe.ReceiveCash(result);
                    }
                    else
                    {
                        Console.WriteLine("Please enter Joe or Bob ");
                    }
                } else
                {
                    Console.WriteLine("Please enter a amount or blank line to exit");
                }
            }
        }
    }
}
