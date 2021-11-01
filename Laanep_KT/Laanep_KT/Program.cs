using System;
using System.Collections.Generic;

namespace Laanep_KT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRegister> registers = new List<IRegister>();
            ProRegister proRegister = new ProRegister();
            BossRegister bossRegister = new BossRegister();
            registers.Add(proRegister);
            registers.Add(bossRegister);

            foreach(IRegister register in registers)
            {
                register.AddCash(100);
                register.AddCash(100);
                register.AddCash(100);
                register.AddCash(100);
                register.AddCash(100);
                register.AddCash(99);
                register.AddCash(99);
                register.AddCash(99);
                register.AddCash(99);
                register.AddCash(99);
                register.AddCash(99);
                register.AddCoin(40);
                register.AddCoin(40);
                register.AddCoin(40);
                register.AddCoin(40);
                register.AddCoin(40);
                register.AddCoin(40);
                register.MakeInventory();
                register.PrintTotalMoney();
            }
        }
    }
}
