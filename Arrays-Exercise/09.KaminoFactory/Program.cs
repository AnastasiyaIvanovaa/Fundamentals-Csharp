using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int applicationMaxSequence = 0;
            int maxSequence = 0;
            int currentSequence = 0;
            int mostLeftIndex = int.MaxValue;
            int bestDna = 1;
            int currentDna = 0;
            int[] result = null;
            int maxSumOfOnes = 0;
            while (command!="Clone them!")
            {
                currentDna++;
                int[] numbers = command.Split("!",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int sumOfOnes = 0;
                currentSequence = 0;
                maxSequence = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0)
                    {
                        currentSequence=0;
                        continue;
                    }
                    sumOfOnes++;
                    currentSequence++;
                    if (currentSequence>maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                }
                string targetString = new string('1', maxSequence);
                int currentIndex = string.Join("", numbers).IndexOf(targetString);
                if (maxSequence>=applicationMaxSequence && currentIndex<mostLeftIndex || maxSequence==applicationMaxSequence && currentIndex==mostLeftIndex && sumOfOnes>maxSumOfOnes)
                {
                    applicationMaxSequence = maxSequence;
                    mostLeftIndex = currentIndex;
                    maxSumOfOnes = sumOfOnes;
                    bestDna = currentDna;
                    result = numbers;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestDna} with sum: {maxSumOfOnes}.");
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
