using System;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = GetAndValidateUserInput();
            Console.WriteLine(GetMoneyInfo(amount)); 
        }

        //get and validate user input
        public static int GetAndValidateUserInput()
        {
            Console.WriteLine("Enter amount of money between 1-999: ");   
            //try to parse input
            bool correctInput = int.TryParse(Console.ReadLine(), out int amount);
            //validate and parse input
            while((!correctInput) || (amount<1) || (amount>999))
            {
                Console.WriteLine("Not valid value. Enter amount of money between 1-999: ");
                correctInput = int.TryParse(Console.ReadLine(), out amount);
            }
            return amount;
        }

        //create output string
        public static string GetMoneyInfo(int amount)
        {
            
            string euro="euro";
            string sent ="sent";
            if (amount < 100)
            {
                //only sents
                if(amount == 1)
                {
                    sent = "sent";
                } else
                {
                    sent = "senti";
                }
                return $"{amount} {sent}";
            }
            else
            {   
                if(amount/100 == 1)
                {
                    if (amount % 100 == 0)
                    {
                        euro = "euro";
                        sent = "";
                        return $"{amount / 100} {euro}";
                    }
                    else if (amount % 100 == 1)
                    {
                        euro = "euro";
                        sent = "sent";
                        return $"{amount / 100} {euro} {amount % 100} {sent}";
                    }
                    else
                    {
                        euro = "euro";
                        sent = "senti";
                        return $"{amount / 100} {euro} {amount % 100} {sent}";
                    }
                    
                }
                else if(amount%100 == 1)
                {
                    euro = "eurot";
                    sent = "sent";
                    return $"{amount / 100} {euro} {amount % 100} {sent}";
                }
                else
                {
                    euro = "eurot";
                    sent = "senti";
                    return $"{amount / 100} {euro} {amount % 100} {sent}";
                }
            }    
        }
    }
}
