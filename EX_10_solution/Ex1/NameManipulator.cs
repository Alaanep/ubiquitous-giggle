using System.Collections.Generic;

namespace Ex1
{
    public class NameManipulator
    {
        private string _name;

        public void AddName(string name)
        {
            _name = name;
        }

        public string CapitalizeName()
        {
            //return _name capitalized!
            return _name.ToUpper(); 
        }
        public int GetNameLength()
        {
            return _name.Length;
        }

        public string ReplaceVowels()
        {
            List<char> vowels = new List<char>()
            {
                'a', 'e', 'i', 'o', 'u', 'õ', 'ä', 'ö', 'ü'
            };
            string replacedWord = ""; //empty string for return value

            foreach (char c in _name) //all letters from _name
            {
                if (vowels.Contains(char.ToLower(c)))
                {
                    replacedWord += 'x'; //add x to return value
                }
                else
                {
                    replacedWord += c; //add initial character to return
                }
            }
            return replacedWord;
        }
    }
}
