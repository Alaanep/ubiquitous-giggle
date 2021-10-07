using System;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of books: ");
            int books = CaptureAndValidateUserInput(Console.ReadLine());
            if (books > 6)
            {
                Console.WriteLine("Not a valid value, max number of books is 5.");
                Console.WriteLine("Enter the number of books: ");
                books = CaptureAndValidateUserInput(Console.ReadLine());
            }
            Console.WriteLine("Enter the number of days: ");
            int days = CaptureAndValidateUserInput(Console.ReadLine());

            Console.WriteLine($"Fine is: {CalculateFine(CalculateDaysOver(days), books)}");
            if (days >= 30)
            {
                Console.WriteLine("Membership cancelled");
            }

        }

        public static int CaptureAndValidateUserInput(string input)
        {
            bool correctInput = int.TryParse(input, out int amount);
            

            while (!correctInput)
            {
                Console.WriteLine("Enter the amount as positive number value: ");
                correctInput = int.TryParse(Console.ReadLine(), out amount);
            }
            if(amount < 0)
            {
                amount = 0;
            }

            Console.WriteLine(amount);
            return amount;
        }

        //calcute how many days over
        public static int CalculateDaysOver(int daysTotal)
        {
            if(daysTotal > 21)
            {
                return daysTotal - 21;
            } else
            {
                return 0;
            }
        }

        //calculate fine
        public static double CalculateFine(int daysOver, int books)
        {
            double finePerday;
            if(daysOver<9)
            {
                finePerday = 0.5;
                return daysOver * books * finePerday;
            } else
            {
                finePerday = 0.8;
                return daysOver * books * finePerday;
            }
        }

    }
}
