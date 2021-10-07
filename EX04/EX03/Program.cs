using System;
using System.Collections.Generic;
using System.Linq;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateRegNr("540BFÄ");
            
        }

        public static void ValidateRegNr(string regNr)
        {
            //check length of regNr
            if (regNr.Length < 6 || regNr.Length > 6)
            {
                Console.WriteLine($"{regNr} is not valid. Invalid Length");
            }
            else
            {
                //get numbers part from reg nr, print and check
                string numbers = regNr.Substring(0, 3);
                string letters = regNr.Substring(3, 3);
                if ((AreRegNrsValid(numbers)) && (AreRegLettersValid(letters)))
                {
                    Console.WriteLine($"{regNr} is valid");
                } else
                {
                    Console.WriteLine($"{regNr} is not valid");
                }
            }
        }

        public static bool AreRegNrsValid(string numbers)
        {
            if (numbers.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        public static bool AreRegLettersValid(string letters)
        {
            if (!letters.All(char.IsLetter))
            {
                return false;
            }

            List<char> forbiddenCaracters = new List<char>() { 'ä', 'ö','ü','õ'} ;

            foreach(char letter in letters.ToLower())
            {
                if (forbiddenCaracters.Contains(letter))
                {
                    Console.WriteLine("Reg nr contains invalid characters");
                    return false;
                }
            }
            
            return true; //todo    
        }
    }
}
