using System;
namespace EX03
{
    public class TVRemote
    {

        private int _volume;
        private bool _systemStatus;
        private string _producingCountry;
        private const int maxVolume = 15;
        private const int minVolume = 0;

        //default constructor(sets volume to 0, system status off and country to china
        public TVRemote()
        {
            _volume = 0;
            _systemStatus = true;
            _producingCountry = "China";
        }

        //constructor for setting producing country
        public TVRemote(string producingCountry)
        {
            _producingCountry = producingCountry;
        }

        //turn tv on and change _systemStatus to true
        public void TurnOn()
        {
            if (!_systemStatus)
            {
                _systemStatus = true;
                Console.WriteLine("TV is now on.");
            } else
            {
                Console.WriteLine("Tv is already on");
            }
            
        }

        //turn tv off and change _systemStatus to false
        public void TurnOff()
        {
            if (_systemStatus)
            {
                _systemStatus = false;
                Console.WriteLine("TV is now off.");
            }
            
        }

        //lower volume. decrease volume level by 3
        public void LowerVolume()
        {
            int previusVolume = _volume;
            if (_systemStatus)
            {
                if ((_volume > minVolume))
                {
                    if (_volume >= 3)
                    {
                        _volume -= 3;
                        Console.WriteLine($"Volume was {previusVolume} and is now {_volume}.");
                    } else
                    {
                        _volume = minVolume;
                        Console.WriteLine($"Volume was {previusVolume} and is now {_volume}.");
                    }
                    
                } else
                {
                    Console.WriteLine("TVs minimum volume reached");
                }    
            } 
        }

        //Raisin volume. Raise volume level by 3
        public void RaiseVolume()
        {
            int previusVolume = _volume;
            if (_systemStatus)
            {
                if ((_volume < maxVolume))
                {
                    if (maxVolume - _volume >= 3)
                    {
                        _volume += 3;
                        Console.WriteLine($"Volume was {previusVolume} and is now {_volume}.");
                    } else
                    {
                        _volume = maxVolume;
                        Console.WriteLine($"Volume was {previusVolume} and is now {_volume}.");
                    }  
                }
                else
                {
                    Console.WriteLine("TVs maximum volume reached");
                }
            }
        }
        //set volume
        public void SetVolume(int volume)
        {
            if (_systemStatus)
            {
                int previusVolume = _volume;
                if ((volume > minVolume) && (volume < maxVolume))
                {
                    _volume = volume;
                    Console.WriteLine($"Volume was {previusVolume} and is now {_volume}.");
                } else
                {
                    Console.WriteLine($"Cant set volume to {volume}.");
                }

            }
            
        }

        //print out info about tv

        
        public void PrintInfo()
        {
            string status;
            if (_systemStatus)
            {
                if (_systemStatus)
                {
                    status = "Tv is on";
                } else
                {
                    status = "Tv is off";
                }
                
                Console.WriteLine($"Volume: {_volume}, Status: {status}, Produced: {_producingCountry}");
            }
                
        }
        

    }
}
