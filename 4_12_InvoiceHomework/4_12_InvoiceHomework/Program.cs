//https://www.youtube.com/watch?v=z9Q0YS6qa7g

using System;

namespace _4_12_InvoiceHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string partnumber, pardDescription;
            int quantity;
            decimal price;

            Console.WriteLine("Please enter part number: ");
            partnumber = Console.ReadLine();
            Console.WriteLine("Please enter part description: ");
            pardDescription = Console.ReadLine();
            Console.WriteLine("Please enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter price: ");
            price = Convert.ToDecimal(Console.ReadLine());

            Invoice invoice = new Invoice(partnumber, pardDescription, quantity, price );

            Console.WriteLine("Your order: ");
            Console.WriteLine($"Part Number: {invoice.PartNumber} ");
            Console.WriteLine($"Part Description: {invoice.PartDescription} ");
            Console.WriteLine($"Quantity: {invoice.Quantity}");
            Console.WriteLine($"Price: {invoice.Price}");
            Console.WriteLine("Total cost {0:C}", invoice.GetInvoiceAmount());

        }
    }
}
