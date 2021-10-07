using System;

namespace TrueOrFalseQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[]{
        "Eggplant is vegetable.\nTrue or False?", "Eggplants are species in the nightshade family.\nTrue or False"
      };

            bool[] answers = new bool[] { true, true };
            RunQuiz(questions, answers);
        }

        static void RunQuiz(string[]questions, bool[]answers )
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);

            // Type your code below
            

            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine($"Warning, questions array is not same length as responses");
            }

            int askingIndex = 0;

            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(question);
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);
                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false' to the console");
                    input = Console.ReadLine();

                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = bool.Parse(input);
                askingIndex++;
            }

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");
                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"You got {score} out of {answers.Length} correct!");
        }

    }
}
