using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;
            GetSum(ref number, ref sumEven, ref sumOdd);
        }

        private static void GetSum(ref int number, ref int sumEven, ref int sumOdd)
        {
            number = Math.Abs(number);
            while (number > 0)
            {

                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                else
                {
                    sumOdd += digit;
                }
                number /= 10;
            }
            Console.WriteLine(sumEven * sumOdd);
        }
    }
}
