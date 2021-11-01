using System;
using System.Collections.Generic;

namespace EX02
{
    public class GoldTicketMachine: BronzeTicketMachine
    {
        public GoldTicketMachine(string name): base(name)
        {
            _prices = new List<int>() { 5, 7, 9 };
            _discountPercent = 0.2;
            _discountReceiverNumber = 5;
        }
    }
}
