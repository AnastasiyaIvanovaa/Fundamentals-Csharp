using System;

namespace _03.FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = Math.Abs(a - b);
            bool isEqual = false;
            if (eps<0.000001)
            {
                isEqual = true;
            }
            Console.WriteLine(isEqual);
        }
    }
}
