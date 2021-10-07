/*In this exercise we will create a class with private members, constructor, properties, and calculated properties.
We then instantiate the object by passing arguments to the constructor 
and calling the properties to perform calculations and display results.

While exercising, you can use a heart-rate monitor to see that your heart rate
stays within a safe range suggested by your trainers and doctors.
According to the American Heart Association (AHA) the formula for calculating
your maximum heart rate in beats per minute is 220 minus your age in years.

Your target heart rate is a range that is 50–85% of your maximum heart rate.
Create a class called HeartRates. The class attributes should include the person’s first name,
last name, year of birth and the current year. Your class should have a constructor that receives this data as parameters.

For each attribute provide a property with set and get accessors.
The class also should include a property that calculates and returns the person’s age (in years),
a property that calculates and returns the person’s maximum heart rate and properties that
calculate and return the person’s minimum 
and maximum target heart rates. Write an app that prompts for the person’s information,
instantiates an object of class HeartRates and displays the information from
that object—including the person’s first name, last name and year of birth —
then calculates and displays the person’s age in (years), maximum heart rate and target-heart-rate range.
*/
using System;

namespace TargetHeartRateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your year of birth: ");

            int yearOfBirth;
            try {
                yearOfBirth = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                yearOfBirth = 0;
            }

            HeartRate hearRate = new HeartRate(firstName, lastName, yearOfBirth);
            Console.WriteLine($"Your name is {hearRate.FirstName} {hearRate.LastName}");
            if ((hearRate.YearOfBirth <= hearRate.CurrentYear &&  hearRate.YearOfBirth != 0))
            {
                Console.WriteLine($"Your age is {hearRate.PersonAge}");
                Console.WriteLine($"Your max safe heart rate is {hearRate.MaxHeartRate}");
                Console.WriteLine($"Your max target heart rate is {hearRate.MaxTargetHeartRate}");
                Console.WriteLine($"Your min target heart rate is {hearRate.MinTargetHeartRate}");
            } else
            {
                Console.WriteLine("Calculations could not be performed because you did not provide a valid birth year");
            }
            

            Console.ReadKey(); 

        }
    }
}
