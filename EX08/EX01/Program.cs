using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            DryingMachine dryingMachine = new DryingMachine();
            ColdWaterMachine coldWaterMachine = new ColdWaterMachine();
            HotWaterMachine hotWaterMachine = new HotWaterMachine();

            hotWaterMachine.AddCoin(1);
            hotWaterMachine.AddCoin(1);
            hotWaterMachine.AddCoin(1);

            hotWaterMachine.DoLaundry();
            hotWaterMachine.AddCoin(1);
            hotWaterMachine.AddCoin(1);
            hotWaterMachine.AddCoin(1);

            hotWaterMachine.DoLaundry();
            hotWaterMachine.AddCoin(1);
            hotWaterMachine.AddCoin(1);
            hotWaterMachine.AddCoin(1);

            hotWaterMachine.DoLaundry();
            hotWaterMachine.AddCoin(1);
            hotWaterMachine.AddCoin(1);
            hotWaterMachine.AddCoin(1);

            hotWaterMachine.DoLaundry();
            hotWaterMachine.AddCoin(1);
            hotWaterMachine.AddCoin(1);
            hotWaterMachine.AddCoin(1);

            hotWaterMachine.DoLaundry();
            hotWaterMachine.AddCoin(1);
            hotWaterMachine.AddCoin(1);
            hotWaterMachine.AddCoin(1);

            hotWaterMachine.DoLaundry();



        }
    }
}
