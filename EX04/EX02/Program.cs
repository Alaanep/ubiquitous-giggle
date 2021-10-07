using System;
using System.Linq;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature: ");
            Console.WriteLine(ConvertTemp("tere"));
        }

        public static string ConvertTemp(string temp)
        {
            double converted;
            //check if length is min 2
            if (temp.Length < 2)
            {
                return $"Not a valid value for temperature!";
            } else
            {
                //get last letter
                char lastChar = temp[temp.Length - 1];
                string numbers = temp.Substring(0, temp.Length - 1);
                
                if (numbers.All(char.IsDigit))
                {
                    int tempToConvert = int.Parse(numbers);
                    //if last char is f or F: convert f-c
                    if(lastChar =='f' || lastChar == 'F')
                    {
                        
                        converted = (tempToConvert - 32.0) * 5 / 9;
                        return $"{tempToConvert}F in C is {converted}";
                        
                    }
                    else if (lastChar == 'c' || lastChar == 'C')
                    {
                        converted = tempToConvert * 9 / 5 + 32.0;
                        return $"{tempToConvert}C in F is {converted}";
                    } else
                    {
                        return $"Not a valid last char. Cant convert";
                    }
                } else
                {
                    return $"Not a valid value for temperature!";
                }
                


            }
        }
    }
}
