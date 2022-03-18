using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Result(number, power);
        }
         static void Result(double a, double b)
        {
            double result = Math.Pow(a, b);
            Console.WriteLine(result);
        }
    }
}
