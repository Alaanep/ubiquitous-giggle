using System;
namespace EX01
{
    public class RegularIronMachine: IIronMachine
    {
        protected string _type;
        protected int _temperature;
        protected int _maxTemperature;
        protected string _program;
        private bool _isOn;
        protected int _usageCounter;
        protected bool _useSteam;

        public RegularIronMachine()
        {
            _type = "Regular Iron Machine";
            _maxTemperature = 199; //possible highest temperature is 199
            _isOn = false;
            _usageCounter = 0; 
        }

        public void DeScale()
        {
            _usageCounter = 0;
            Console.WriteLine($"{_type} is cleaned");
        }
        
        public virtual void DoIroning(int temperature)
        {
            if (CheckIfOn()) {
                if (CheckUsage()) { 
                    if (SetTemperature(temperature))
                    {
                        _usageCounter++;               
                        if (_useSteam)
                        {
                             Console.WriteLine($"{_type} is ironing with steam with {_program} program.");
                            _useSteam = false;
                        } else
                        {
                            Console.WriteLine($"{_type} is ironing with {_program} program.");
                        }
                    }
                }   
            }
        }
        
        public virtual void DoIroning(string program)
        {
            if (CheckIfOn())
            {
                if (CheckUsage())
                {
                    if (SetProgram(program))
                    {
                        _usageCounter++;
                        if (_useSteam)
                        {
                            Console.WriteLine($"{_type} is ironing with steam with {_program} program.");
                            _useSteam = false;
                        }
                        else
                        {
                            Console.WriteLine($"{_type} is ironing with {_program} program.");
                        }
                    }
                }
            }
        }

        private bool CheckUsage()
        {
            if (_usageCounter < 3)
            {
                return true;
            }
            Console.WriteLine($"{_type} has been used {_usageCounter} times and needs cleaning");
            return false;
        }

        private bool CheckIfOn()
        {
            if (_isOn)
            {
                return true;
            }
            Console.WriteLine($"{_type} has to be turned on to use");
            return false;
        }
        //set ironing program
        protected virtual bool SetProgram(string program)
        {
            Random random = new Random();
            if (program.ToLower() == "cotton")
            {
                _temperature = random.Next(150, 199);
                _program = "Cotton";
                return true;
            }
            else if (program.ToLower() == "silk")
            {
                _temperature = random.Next(120, 149);
                _program = "Silk";
                return true;
            }
            else if (program.ToLower() == "synthetics")
            {
                _temperature = random.Next(90, 119);
                _program = "Synthetics";
                _useSteam = false;
                return true;
            }
            else
            {
                Console.WriteLine($"{_type} do not have a program for ironing {program}");
                return false;
            }
        }

        //set ironing temperature
        protected virtual bool SetTemperature(int temperature)
        {
            if (temperature < 90 || temperature > _maxTemperature)
            {
                Console.WriteLine($"{_type}: Invalid temperature range for ironing");
                return false;
            }   
            else if (temperature <= 119)
            {
                _program = "Synthetics";
                _temperature = temperature;
                _useSteam = false;
                return true;
            }
            else if (temperature <= 149)
            {
                _program = "Silk";
                _temperature = temperature;
                return true;
            }
            else if (temperature <= 199)
            {
                _program = "Cotton";
                _temperature = temperature;
                return true;
            }
            return false; 
        }

        public void TurnOff()
        {
            _isOn = false;
            Console.WriteLine($"{_type} is turned off");
        }

        public void TurnOn()
        {
            _isOn = true;
            Console.WriteLine($"{_type} is turned on");
        }

        public virtual void UseSteam()
        {
            if (CheckIfOn()) { 
                if (_useSteam == true)
                {
                    Console.WriteLine($"{_type}: Steam is already on.");
                } else
                {
                    if (_temperature >= 120)
                    {
                        _useSteam = true;
                        Console.WriteLine($"{_type}: Steam is on");
                    } else
                    {
                        Console.WriteLine($"{_type}: To use steam temprature has to be atleast 120 degrees.");
                    }                             
                }
            }
        }
    }
}