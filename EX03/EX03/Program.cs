using System;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string for case replacing: ");
            string word = Console.ReadLine();
            string caseReplaced = ReplaceLetterCase(word);

            

            Console.WriteLine(caseReplaced);
        }

        public static string ReplaceLetterCase (string word)
        {
            string caseReplaced = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    caseReplaced += char.ToLower(word[i]);
                }
                else if (char.IsLower(word[i]))
                {
                    caseReplaced += char.ToUpper(word[i]);
                }

            }
            return caseReplaced;
        }




    }
}