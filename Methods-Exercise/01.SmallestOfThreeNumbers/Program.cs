using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int smallest = 0;
            smallest = FindTheSmallest(a, b, c);
        }

        private static int FindTheSmallest(int a, int b, int c)
        {
            int smallest;
            if (a < b && a < c)
            {
                smallest = a;
            }
            else if (b < a && b < c)
            {
                smallest = b;
            }
            else
            {
                smallest = c;
            }
            Console.WriteLine(smallest);
            return smallest;
        }
    }
}
