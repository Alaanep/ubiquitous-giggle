﻿using System;

namespace _4d6roll
{
    class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();

            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine($"Calculated ability score: {calculator.Score}");
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'q') || (keyChar == 'Q')) return;
            }
        }

        public static int ReadInt(int lastUsedValue, string prompt) {
            Console.WriteLine($"{prompt} [{lastUsedValue}]");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int value))
            {
                return value;
            } else
            {
                Console.WriteLine($"Using default value {lastUsedValue}");
                return lastUsedValue;
            }
        }
        public static double ReadDouble(double lastUsedValue, string prompt) {
            Console.WriteLine($"{prompt} [{lastUsedValue}]");
            string line = Console.ReadLine();

            if (double.TryParse(line, out double value))
            {
                return value;
            }
            else
            {
                Console.WriteLine($"Using default value {lastUsedValue}");
                return lastUsedValue;
            }
        }


    }
}