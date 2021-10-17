using System;
namespace EX02
{
    public class DeadlySpider: Spider
    {
        public DeadlySpider()
        {
            _type = "killer";
            _maxAge = 5;
        }

        public override void Bite()
        {
            Console.WriteLine("Game over. You have been bitten by a deadly spider!");

        }

        public override void SetName(string name)
        {
            base.SetName("Deadly" + name);
        }

    }
}
