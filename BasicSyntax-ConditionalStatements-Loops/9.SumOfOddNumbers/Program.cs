using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 2 * n;
            int sum = 0;
            for (int i = 1; i <= count; i += 2)
            {
                sum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}