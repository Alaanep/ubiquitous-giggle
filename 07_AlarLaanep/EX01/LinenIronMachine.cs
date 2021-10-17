using System;
namespace EX01
{
    public class LinenIronMachine: RegularIronMachine
    {
        public LinenIronMachine()
        {
            _type = "Linen Iron Machine";
            _maxTemperature = 230;
        }

        public override bool SetTemperature(int temperature)
        {
            if (temperature >= 200 && temperature <= 230)
            {
                _program = "Linen";
                _temperature = temperature;
                _useSteam = true;
                return true;
            }
            return base.SetTemperature(temperature);
        }

        public override bool SetProgram(string program)
        {
            Random random = new Random();
            if (program.ToLower() == "linen")
            {
                _temperature = random.Next(200, 230);
                _program = "Linen";
                _useSteam = true;
                return true;
            }
            return base.SetProgram(program);
        }
    }
}
