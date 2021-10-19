using System;
namespace EX01
{
    public class LinenIronMachine: RegularIronMachine
    {
        public LinenIronMachine()
        {
            _type = "Linen Iron Machine";
            _maxTemperature = 230;//possible highest temperature 230
        }

        protected override bool SetTemperature(int temperature)
        {
            if (temperature >= 200 && temperature <= 230)
            {
                _program = "Linen";
                _temperature = temperature;
                UseSteam();
                return true;
            }
            return base.SetTemperature(temperature);
        }

        protected override bool SetProgram(string program)
        {
            Random random = new Random();
            if (program.ToLower() == "linen")
            {
                _temperature = random.Next(200, 230);
                _program = "Linen";
                UseSteam();
                return true;
            }
            return base.SetProgram(program);
        }
    }
}
