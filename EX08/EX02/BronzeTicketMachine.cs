using System;
namespace EX02
{
    public class BronzeTicketMachine: SilverTicketMachine
    {

        protected double _discountPercent;
        protected int _discountReceiverNumber;
        protected int _numberOfTicketsSold;
        public BronzeTicketMachine(string name): base(name)
        {
            _discountPercent = 0.1;
            _discountReceiverNumber = 5;
            _numberOfTicketsSold = 0;
        }

        public override void SellTicket(int distance)
        {
            FindTicketPrice(distance);
            if (_ticketPrice != 0)
            {
                _numberOfTicketsSold++;
            }
            ApplyDiscount();
            PrintTicket();
        }

        protected void ApplyDiscount()
        {
            if (_numberOfTicketsSold == _discountReceiverNumber)
            {
                Console.WriteLine("Congrats, you got discount");
                _ticketPrice -= _ticketPrice * _discountPercent;
                _numberOfTicketsSold = 0;
            }
        }
    }
}
