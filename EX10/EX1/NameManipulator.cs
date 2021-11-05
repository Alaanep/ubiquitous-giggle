using System;
using System.Collections.Generic;

namespace EX1
{
    public class NameManipulator
    {
        private string _name;
        public NameManipulator()
        {
        }

        public void AddName(string name)
        {
            _name = name;
        }

        public string CapitalizeName()
        {
            return _name.ToUpper();
        }

        public int GetNameLength()
        {
            return _name.Length;
        }
        public string ReplaceVowel()
        {
            string replacedVowels = "";
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'ä', 'õ', 'ö', 'ü', 'A', 'E', 'I', 'O', 'U', 'Ä', 'Õ', 'Ü', 'Ö' };

            for(int i =0; i<_name.Length; i++)
            {
                if (vowels.Contains(_name[i]))
                {
                    replacedVowels += "x";
                }
                else
                {
                    replacedVowels += _name[i];
                }
            }
            return replacedVowels;
        }
    }   
}
