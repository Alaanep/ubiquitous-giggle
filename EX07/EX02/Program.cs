using System;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            Spider regularSpider = new Spider();
            DangerousSpider dSpider = new DangerousSpider();
            DeadlySpider deadlySpider = new DeadlySpider();
            deadlySpider.Bite();
            deadlySpider.Eat("fly");
            deadlySpider.SetAge(10);
            deadlySpider.SetAge(4);
            deadlySpider.SetName("Armin");
            deadlySpider.PrintInfo();
        }
    }
}
