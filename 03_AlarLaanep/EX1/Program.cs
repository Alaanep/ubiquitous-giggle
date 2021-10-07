using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word to minimize: ");
            Console.WriteLine(MinimizeWord(Console.ReadLine()));
            
        }
        //returns every second letter of this word starting from [0]
        public static string MinimizeWord(string word)
        {
            string minWord="";
            if(word.Length < 2)
            {
                return "Too short word!";
            }
            for(int i = 0; i<word.Length; i+=2)
            {
                minWord += word[i];
            }
            return minWord;

        }
    }
}
