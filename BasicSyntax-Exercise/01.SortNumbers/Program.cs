using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int min = 0;
            int max = 0;
            int middle = 0;
            if (a > b && a > c)
            {
                max = a;
                if (b > c)
                {
                    middle = b;
                    min = c;
                }
                else
                {
                    middle = c;
                    min = b;
                }

            }
            else if (b > a && b > c)
            {
                max = b;
                if (a > c)
                {
                    middle = a;
                    min = c;
                }
                else
                {
                    middle = c;
                    min = a;
                }
            }
            else
            {
                max = c;
                if (a > b)
                {
                    middle = a;
                    min = b;
                }
                else
                {
                    middle = b;
                    min = a;
                }
            }
            Console.WriteLine($"{max} \n{middle} \n{min}");
        }
    }
}
