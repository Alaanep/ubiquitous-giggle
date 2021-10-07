using System;

namespace kysimused
{
    class Program
    {
        static void Main(string[] args)
        {
            //answers
            string answer1 = "Tallinn";
            int answer2 = 7;
            int answer3 = 1;
            int correct = 0;

            Console.WriteLine("What is the capital of Estonia?");
            string input1 = Console.ReadLine();
            if (answer1 == input1)
            {
                correct++;
            }
            Console.WriteLine("How many days are in week?");
            string input2 = Console.ReadLine();
            if (answer2 == Convert.ToInt32(input2))
            {
                correct++;
            }
            Console.WriteLine("Which of them is a bird? Enter the number for correct answer:");
            Console.WriteLine("1. Kiwi");
            Console.WriteLine("2. Banana");
            Console.WriteLine("3. Grapefruit");
            string input3 = Console.ReadLine();
            if (answer3 == Convert.ToInt32(input3))
            {
                correct++;
            }
            if (correct == 3)
            {
                Console.WriteLine("Well Done! All answers were correct");
            }
            else if (correct < 3)
            {
                Console.WriteLine($"Better luck next time. You answered {correct} of 3 correctly");
            }
        }
    }
}
