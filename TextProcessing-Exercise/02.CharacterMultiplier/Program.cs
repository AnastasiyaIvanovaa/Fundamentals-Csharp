using System;

namespace _2.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int minLength = 0;
            int maxLength = 0;
            string first = input[0];
            string second = input[1];
            int sum = 0;
            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += first[i] * second[i];
                }
            }
            else if (input[0].Length != input[1].Length)
            {
                minLength = Math.Min(first.Length, second.Length);
                maxLength = Math.Max(first.Length, second.Length);
                string longer = first.Length > second.Length ? first : second;
                for (int i = 0; i < minLength; i++)
                {
                    sum += first[i] * second[i];
                }
                for (int j = minLength; j < maxLength; j++)
                {
                    sum += longer[j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}