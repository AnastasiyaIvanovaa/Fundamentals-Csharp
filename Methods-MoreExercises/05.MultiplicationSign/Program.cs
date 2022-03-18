using System;
using System.Linq;

namespace MethodsFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            MultiplicationSign(a, b, d);
        }

        private static void MultiplicationSign(int a, int b, int d)
        {
            int counter = 0;
            if (a == 0 || b == 0 || d == 0)
            {
                Console.WriteLine("zero");
                return;
            }
            if (a < 0)
            {
                counter++;
            }
            if (b < 0)
            {
                counter++;
            }
            if (d < 0)
            {
                counter++;
            }
            if (counter % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
