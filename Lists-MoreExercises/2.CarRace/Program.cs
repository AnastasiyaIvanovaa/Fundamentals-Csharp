using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double firstTime = 0;
            double secondTime = 0;
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                if (numbers[i] == 0)
                {
                    firstTime *= 0.8;
                }
                else
                {
                    firstTime += numbers[i];
                }
            }
            for (int i = numbers.Count - 1; i > numbers.Count / 2; i--)
            {
                if (numbers[i] == 0)
                {
                    secondTime *= 0.8;
                }
                else
                {
                    secondTime += numbers[i];
                }
            }
            if (firstTime < secondTime)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(firstTime, 1)}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(secondTime, 1)}");

            }
        }
    }
}
