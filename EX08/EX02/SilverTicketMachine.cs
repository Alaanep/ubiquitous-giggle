using System;
using System.Collections.Generic;

namespace EX02
{
    public class SilverTicketMachine : ITicketMachine
    {

        protected List<int> _prices;
        protected string _machineName;
        protected string _ticketZone;
        protected double _ticketPrice;

        public SilverTicketMachine(string name)
        {
            _machineName = name;
            _prices = new List<int>() { 3, 4, 5 };
        }

        public virtual void SellTicket(int distance)
        {
            FindTicketPrice(distance);
            PrintTicket();
        }

        //set ticket price and zone based on distance
        public void FindTicketPrice(int distance) {
            if(distance >= 0 && distance <= 30)
            {
                _ticketPrice = _prices[0];
                _ticketZone = "A";
            } else if(distance >30 && distance <= 60)
            {
                _ticketPrice = _prices[1];
                _ticketZone = "B";
            } else if(distance>60 && distance <= 80)
            {
                _ticketPrice = _prices[2];
                _ticketZone = "C";
            }else 
            {
                _ticketPrice = 0;
                _ticketZone = "invalid";
                    
            }   
        }
        //print out ticket zone and price
        public void PrintTicket() {
            if (_ticketPrice != 0)
            {
                Console.WriteLine($"You bought a ticket with {_machineName} for " +
                    $"zone {_ticketZone} with price {_ticketPrice}");
            }
            else
            {
                Console.WriteLine("Invalid distance, cannot sell ticket");
            }
        }



    }
}
