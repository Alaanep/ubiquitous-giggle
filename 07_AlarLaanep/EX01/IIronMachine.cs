using System;
namespace EX01
{
    public interface IIronMachine
    {
        public void DeScale();
        public void DoIroning(int temperature);
        public void DoIroning(string program);
        public void UseSteam();
        public void TurnOn();
        public void TurnOff();
    }
}
