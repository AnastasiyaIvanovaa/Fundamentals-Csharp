using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = Sum(a, b);
            Substract(c, result);

        }

        private static void Substract(int c, int result)
        {
            int endResult = result - c;
            Console.WriteLine(endResult);
        }
        

        static int Sum(int a, int b)
        {
             return a + b;
        }
        
    }
}
