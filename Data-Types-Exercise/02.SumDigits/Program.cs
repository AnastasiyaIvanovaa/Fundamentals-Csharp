using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            while (a>0)
            {
                int digit = a % 10;
                a /= 10;
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
