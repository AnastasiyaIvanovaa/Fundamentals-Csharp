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
            string text = Console.ReadLine();
            string result = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                int current = numbers[i];
                while (current > 0)
                {
                    int digit = current % 10;
                    sum += digit;
                    current /= 10;
                }
                if (sum >= text.Length)
                {
                    sum -= text.Length;
                }
                result += text.Substring(sum, 1);
                text = text.Remove(sum, 1);
            }
            Console.WriteLine(result);

        }
    }
}