using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double factorialA = 1;
            double factorialB = 1;

            FactorialDivision(a, b, ref factorialA, ref factorialB);
            Result(factorialA, factorialB);
        }

        private static void Result(double factorialA, double factorialB)
        {
            double result = factorialA / factorialB;
            Console.WriteLine($"{result:f2}");
        }

        private static void FactorialDivision(double a, double b, ref double factorialA, ref double factorialB)
        {
            if (a>0)
            {
                for (double i = 1; i <= a; i++)
                {
                    factorialA *= i;
                }
            }
            
            if (b>0)
            {
                for (double i = 1; i <= b; i++)
                {
                    factorialB *= i;
                }
            }
        }
    }
}
