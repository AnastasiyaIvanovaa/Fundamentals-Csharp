using System;

namespace _11._MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double result = 0;
            string operation = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());

            result = Operations(a, b, result, operation);
        }

        private static double Operations(double a, double b, double result, string operation)
        {
            if (operation == "+")
            {
                result = a + b;
            }
            else if (operation == "-")
            {
                result = a - b;
            }
            else if (operation == "*")
            {
                result = a * b;
            }
            else if (operation == "/")
            {
                result = a / b;
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
