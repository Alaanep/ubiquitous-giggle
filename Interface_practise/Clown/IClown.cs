using System;
namespace Clown
{
    public interface IClown
    {
        string FunnyThingIHave { get;  }

        void Honk();

        protected static Random random = new Random();
        private static int carCapacity = 12;

        public static int CarCapacity
        {
            get { return carCapacity; }
            set
            {
                if(value > 10)
                {
                    carCapacity = value;
                }
                else
                {
                    Console.Error.WriteLine($"Warning: Car capacity {value} is to small");
                }
            }
        }

        public static string ClownCarDescription()
        {
            return $"A clown car with {random.Next(carCapacity/2, carCapacity)} clowns";
        }
    }
}
