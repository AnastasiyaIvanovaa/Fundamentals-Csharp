using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double dolars = money * 1.31;
            Console.WriteLine($"{dolars:f3}");
        }
    }
}
