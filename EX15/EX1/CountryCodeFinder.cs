using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EX1
{
    public class CountryCodeFinder
    {
        public Dictionary<string, string> countryCodes = new Dictionary<string, string>();
        private string _fileName;
        public CountryCodeFinder()
        {
            _fileName = "countrycodes.txt";
            ReadFromFile();
        }

        
        public string GetCountryInfo(string input)
        {
            string phoneNr = input;
            
            phoneNr = RemovePlusSign(phoneNr);

            string countryCode = string.Empty;
            if (phoneNr.All(char.IsDigit))
            {   
                for (int i = 4; i >=0; i--)
                {
                    if(countryCodes.TryGetValue(phoneNr.Substring(0,i), out countryCode))
                    {
                        if((phoneNr.Substring(i).Length >= 5))
                        {
                            return $"{input} country is: {countryCode}.";
                        }
                        else
                        {
                            return $"{ input} is invalid phone number; minimum length is 5.";
                        }
                    }
                }
            } else
            {
                return $"{input} is invalid phone number; phone number cannot contain letters.";
            }
            return $"{ input} does not contain known country code.";
        }

        private string RemovePlusSign(string phoneNr)
        {
            if (phoneNr.StartsWith("+"))
            {
                return phoneNr.Substring(1);
            }
            else
            {
                return phoneNr;
            }
        }

        public string AddPlusSign(string phoneNr)
        {
            if (phoneNr.StartsWith("+"))
            {
                return phoneNr;
            }
            else
            {
                return "+"+phoneNr;
            }
        }


        public void ReadFromFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(_fileName))
                {
                    string line = "";
                    
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            string[] splittedLine = line.Split("+");
                            if(splittedLine.Length == 2)
                            {
                                //Console.WriteLine($"{splittedLine[0].TrimEnd()} {splittedLine[1]}");
                                countryCodes.TryAdd(splittedLine[1], splittedLine[0].TrimEnd());
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
