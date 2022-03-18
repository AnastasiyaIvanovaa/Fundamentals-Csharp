using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecial = false;

            for (int i = 1; i <= n; i++)
            {
                int num = i;
                while (num > 0)
                {
                    int digit = num % 10;
                    num /= 10;
                    sum += digit;
                }
                if (sum==5 || sum==7||sum==11)
                {
                    isSpecial = true;
                }
                if (isSpecial)
                {
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
                else
                {
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
                isSpecial = false;
                sum = 0;
            }
        }
    }
}
