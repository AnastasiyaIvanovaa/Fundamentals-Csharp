using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                if (currentNumber%2==0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }
            Console.WriteLine(evenSum-oddSum);
        }
    }
}
