using System;
using System.Text;

namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            int min = Math.Min(first, second);
            int max = Math.Max(first, second);
            int sum = 0;
            string input = Console.ReadLine();

            foreach (var @char in input)
            {
                if (@char > min && @char < max)
                {
                    sum += @char;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
