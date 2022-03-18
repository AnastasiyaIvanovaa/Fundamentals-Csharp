using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            PrintSign(inputNumber);
        }

        static void PrintSign(int number)
        {
            if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number>0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
