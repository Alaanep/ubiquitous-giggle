using System;
namespace EX01
{
    public class RegularIronMachine: IIronMachine
    {
        protected string _type;
        protected int _temperature;
        protected int _maxTemperature;
        protected string _program;
        protected bool _isOn;
        protected bool _isCleaned;
        protected int _usageCounter;
        protected bool _useSteam;
        protected int _steamUsage;
        

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

        //doironing with temperature parameter
        public virtual void DoIroning(int temperature)
        {
            if (_isOn ) {
                if (_usageCounter < 3) { 
                    if (SetTemperature(temperature))
                    {
                        _usageCounter++;               
                        if (_useSteam)
                        {
                            if (_temperature >= 120)
                            {
                                Console.WriteLine($"{_type} is ironing with steam with {_program} program.");
                                _steamUsage++;
                                _useSteam = false;
                            }
                            else
                            {
                                _useSteam = false;
                                Console.WriteLine($"{_type}: To use steam temprature has to be atleast 120 degrees.");
                                Console.WriteLine($"{_type} is ironing with {_program} program.");
                            }
 
                        } else
                        {
                            Console.WriteLine($"{_type} is ironing with {_program} program.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{_type} has been used {_usageCounter} times and needs cleaning");
                }
            }
            else
            {
                Console.WriteLine($"{_type} has to be turned on to do ironing");
            }
        }

        public virtual void DoIroning(string program)
        {
            if (_isOn)
            {
                if (_usageCounter < 3)
                {
                    if (SetProgram(program)) 
                    {
                        _usageCounter++;
                        if (_useSteam)
                        {
                            if (_temperature >= 120)
                            {
                                Console.WriteLine($"{_type} is ironing with steam with {_program} program.");
                                _steamUsage++;
                                _useSteam = false;
                            }
                            else
                            {
                                _useSteam = false;
                                Console.WriteLine($"{_type}: To use steam temprature has to be atleast 120 degrees.");
                                Console.WriteLine($"{_type} is ironing with {_program} program.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{_type} is ironing with {_program} program.");
                        }
                    }
                } else
                {
                    Console.WriteLine($"{_type} has been used {_usageCounter} times and needs cleaning");
                }
            } else
            {
                Console.WriteLine($"{_type} has to be turned on to do ironing");
            }
        }

        public virtual bool SetProgram(string program)
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
                return true;
            }
            else
            {
                Console.WriteLine($"We do not have a program for ironing {program}");
                return false;
            }
            
        }

        //set ironing temperature
        public virtual bool SetTemperature(int temperature)
        {
            if (temperature < 90 || temperature > _maxTemperature)
            {
                Console.WriteLine($"{_type}: Invalid temperature range for ironing");
                return false;
            }
            
            if (temperature >= 90 && temperature <= 119)
            {
                _program = "Synthetics";
                _temperature = temperature;
                return true;
            }
            else if (temperature >= 120 && temperature <= 149)
            {
                _program = "Silk";
                _temperature = temperature;
                return true;
            }
            else if (temperature >= 150 && temperature <= 199)
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
            if (_useSteam == true)
            {
                Console.WriteLine($"{_type}: Steam is already on.");
                
            } else
            {
                _useSteam = true;
                Console.WriteLine($"{_type}: Steam is on");                             
            }
        }
    }
}