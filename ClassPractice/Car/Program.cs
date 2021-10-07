using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Oldmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Car myOtherCar = myCar;
            Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Model} {myOtherCar.Year} {myOtherCar.Color}");

            myOtherCar.Model = "98";
            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year} {myCar.Color}");

            Car myThirdCar = new Car();
        }
    }
}
