using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberOne = number;
            int sum = 0;
            while (number>0)
            {
                int digit = number % 10;
                int factoriel = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factoriel *= i;
                }
                number /= 10;
                sum += factoriel;
            }
            if (numberOne==sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
