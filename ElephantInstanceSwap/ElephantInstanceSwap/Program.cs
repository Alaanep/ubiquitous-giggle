using System;

namespace ElephantInstanceSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lloyd = new Elephant("Lloyd", 40);
            Elephant lucinda = new Elephant("Lucinda", 33);
            

            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int userChoice))
                {
                    Console.WriteLine($"You pressed {userChoice}");
                    if (userChoice == 1)
                    {
                        Console.WriteLine("Calling lloyd.WhoAmi()");
                        lloyd.WhoAmi();
                        lloyd.HearMessage("Hi", lucinda);
                        lloyd.SpeakTo(lucinda, "hi");
                    } else if(userChoice == 2)
                    {
                        Console.WriteLine("Calling lucinda.WhoAmi()");
                        lucinda.WhoAmi();
                        lucinda.HearMessage("Hi", lloyd);
                        lucinda.SpeakTo(lloyd, "Hi");
                    } else if(userChoice == 3)
                    {
                        Elephant temp;
                        temp= lloyd;
                        lloyd = lucinda;
                        lucinda = temp;
                        Console.WriteLine("References have been swapped");
                    } else if(userChoice == 4)
                    {
                        lloyd = lucinda;
                        lloyd.WhoAmi();
                    }
                }
                else
                {
                    keepGoing = false;
                }
            }
            
        }
    }
}
