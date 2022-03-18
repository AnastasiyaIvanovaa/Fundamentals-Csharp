using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Arrea(width, height);
        }

        static void Arrea(double a, double b)
        {
            Console.WriteLine($"{a*b}");
        }
    }
}
