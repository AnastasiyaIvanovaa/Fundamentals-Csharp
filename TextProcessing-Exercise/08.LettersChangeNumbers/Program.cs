using System;

namespace _8.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double result = 0;
            while (command != "End")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < input.Length; i++)
                {
                    char first = input[i][0];
                    char second = input[i][input[i].Length - 1];
                    string substring = input[i];
                    double number = double.Parse(substring.Substring(1, substring.Length - 2));
                    if (char.IsUpper(first))
                    {
                        number /= first - 64;
                    }
                    else
                    {
                        number *= first - 96;
                    }
                    if (char.IsUpper(second))
                    {
                        number -= second - 64;
                    }
                    else
                    {
                        number += second - 96;
                    }
                    result += number;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
