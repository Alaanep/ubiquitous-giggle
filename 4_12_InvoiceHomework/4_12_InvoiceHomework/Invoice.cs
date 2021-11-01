using System;
namespace _4_12_InvoiceHomework
{
    public class Invoice
    {

        private int _quantity;
        private decimal _price;
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }

        public Invoice(string partNumber, string partDescription, int quantity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value > 0)
                {
                    _quantity = value;
                }
                else
                {
                    _quantity = 1;
                }
            }
        }

        public decimal Price
        {
           get { return _price; }
           set
           { if (value > 0)
             {
                _price = value;
               }else
               {
                    _price = 1;
               }
               }
        }

        public decimal GetInvoiceAmount()
        {
            return Quantity * Price;
        }
    }
}
