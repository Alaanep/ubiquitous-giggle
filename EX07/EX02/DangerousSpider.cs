using System;
namespace EX02
{
    public class DangerousSpider: Spider
    {
        public DangerousSpider()
        {
            _type = "dangerous spider";
        }

        public override void Bite()
        {
            base.Bite();
            Console.WriteLine("Seek medical help in 4-8 hours!");
        }
    }
}
