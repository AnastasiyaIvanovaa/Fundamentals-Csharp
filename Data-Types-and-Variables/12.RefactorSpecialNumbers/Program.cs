using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber = 0;
            bool isSpecial = false;
            for (int i = 1; i <= count; i++)
            {
                currentNumber = i;
                while (i>0)
                {
                    sum += i % 10;
                    i /= 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}",currentNumber,isSpecial);
                sum = 0;
                i = currentNumber;
            }
        }
    }
}
