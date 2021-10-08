using System;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            TVRemote remote = new TVRemote();
            remote.TurnOn();
            remote.LowerVolume();
            remote.SetVolume(17);
            remote.LowerVolume();
            remote.LowerVolume();
            remote.PrintInfo();

        }
    }
}
