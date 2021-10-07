using System;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
           
            printAnswer("ABcbBA");
            printAnswer("Kirik");
            printAnswer("a");
            
        }

        public static bool IsPalindrome(string stringToCheck)
        {
            if (stringToCheck.Length < 2)
            {
                return false;
            }
            string str = stringToCheck.ToLower();

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;

        }

        public static void printAnswer(string stringToCheck)
        {
            if (IsPalindrome(stringToCheck))
            {
                Console.WriteLine($"{stringToCheck} is palindrome");
            } else
            {
                Console.WriteLine($"{stringToCheck} is not palindrome");
            }
        }
    }

    
}
