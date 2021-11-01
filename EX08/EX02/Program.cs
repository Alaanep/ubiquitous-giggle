using System;
using System.Collections.Generic;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITicketMachine> ticketMachines = new List<ITicketMachine>();
            SilverTicketMachine silverTicketMachine = new SilverTicketMachine("Silver");
            BronzeTicketMachine bronzeTicketMachine = new BronzeTicketMachine("Bronze");
            GoldTicketMachine goldTicketMachine = new GoldTicketMachine("Gold");
            ticketMachines.Add(silverTicketMachine);
            ticketMachines.Add(bronzeTicketMachine);
            ticketMachines.Add(goldTicketMachine);

            foreach (ITicketMachine machine in ticketMachines)
            {
                for (int i = 0; i <= 20; i++)
                {
                    int distance = GetRandomDistance();
                    Console.WriteLine(distance);
                    machine.SellTicket(distance);
                }
            }
        }

        public static int GetRandomDistance()
        {
            Random random = new Random();
            return random.Next(0, 100);
        }
        
        
    }
}
