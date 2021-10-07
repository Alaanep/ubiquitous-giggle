using System;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
           
                string[] list = new string[5]; list[0] = "Apple";
                list[1] = "Banana";
                list[3] = "Pineapple"; list[4] = "Melon";
                for (int i = 0; i <= 5; i++)
                {
                    try
                    {
                        Console.WriteLine($"Word {list[i]} length is {list[i].Length} ");
                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine($"Cannot not print length for null. (Index is {i})");
                    } catch(IndexOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine($"No list item with index {i}");
                    }
                {

                }

            }
            
        }
    }
}
