/*
Develop a C# app that will determine whether any of several department store customers has exceeded the credit limit on a charge account.
For each customer, the following facts are available:
a) account number
b) balance at the beginning of the month
c) total of all items charged by the customer this month
d) total of all credits applied to the customer’s account this month
e) allowed credit limit.
The app should input all these facts as integers, calculate the new balance(= beginning balance + charges – credits),
display the new balance and determine whether the new balance exceeds the customer’s credit limit.
For those customers whose credit limit is exceeded, the app should display the message "Credit limit exceeded". 
Use sentinel-controlled repetition to obtain the data for each account.*/

using System;

namespace CreditLimitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string accountNumber;
            decimal startBalance, charges, credit, creditLimit;
            string quit = "1";

            while (quit != "0")
            {

                Console.WriteLine("Please enter account number: ");
                accountNumber = Console.ReadLine();
                Console.WriteLine("Please enter startin balance: ");
                startBalance = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter charges: ");
                charges = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter credit added to account: ");
                credit = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter credit limit: ");
                creditLimit = Convert.ToDecimal(Console.ReadLine());

                Account account = new Account(accountNumber, startBalance, charges, credit, creditLimit);

                Console.WriteLine($"Summary of account ${account.AccountNumber}");

                if (account.CalculateNewBalance() > account.CreditLimit)
                {
                    Console.WriteLine($"You have exceeded your credit limit: !");
                }

                Console.WriteLine($"Your current balance is ${account.CalculateNewBalance()}");
                Console.WriteLine($"Available credit is ${account.CreditLimit - account.CalculateNewBalance()}");
                Console.WriteLine("Do you want to continue? Enter 0 to quit");
                quit = Console.ReadLine();

            }

        }
    }
}
