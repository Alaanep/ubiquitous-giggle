using System;
using System.Collections.Generic;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            RegularIronMachine rim = new RegularIronMachine();
            PremiumIronMachine pim = new PremiumIronMachine();
            LinenIronMachine lim = new LinenIronMachine();
            List<IIronMachine> irons = new List<IIronMachine>();
            irons.Add(rim);
            irons.Add(pim);
            irons.Add(lim);
            foreach(IIronMachine i in irons)
            {
                i.TurnOn();
                //i.UseSteam();
                i.DoIroning(180);
                //i.UseSteam();   
                //i.UseSteam();
                i.DoIroning(180);
               // i.UseSteam();
                i.DoIroning(180);
                //i.UseSteam();
                i.DoIroning(180);
                //i.UseSteam();
            }
        }
    }
}
