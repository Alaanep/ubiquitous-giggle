using System;
namespace GoFishTests
{
    public class MockRandom : System.Random
    {
        public MockRandom()
        {
        }

        public int ValueToReturn { get; set; } = 0;
        public override int Next() => ValueToReturn;
        public override int Next(int maxValue) => ValueToReturn;
        public override int Next(int minValue, int maxValue) => ValueToReturn;
    }
}
