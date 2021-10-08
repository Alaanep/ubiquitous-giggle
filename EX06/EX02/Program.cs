using System;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            HolePuncher hp = new HolePuncher();
            hp.PunchHole();
            hp.PrintInfo();
            hp.PunchHole();
            hp.PrintInfo();
            hp.PunchHole();
            hp.PrintInfo();
            hp.PunchHole();
            hp.PrintInfo();
            hp.PunchHole();
            hp.PrintInfo();
            hp.PunchHole();
            hp.PrintInfo();
            hp.sharpening();
            hp.PunchHole();
            hp.PrintInfo();

            HolePuncher hp1 = new HolePuncher(4);
            hp1.PunchHole();
            hp1.PrintInfo();
            hp1.PunchHole();
            hp1.PrintInfo();
            hp1.PunchHole();
            hp1.PrintInfo();
            hp1.PunchHole();
            hp1.PrintInfo();
            hp1.PunchHole();
            hp1.PrintInfo();
            hp1.PunchHole();
            hp1.PrintInfo();
            hp1.sharpening();
            hp1.PunchHole();
            hp1.PrintInfo();
        }
    }
}
