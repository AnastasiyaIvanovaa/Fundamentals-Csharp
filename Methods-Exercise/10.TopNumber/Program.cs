using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IsDivisible(n);
        }

         static void IsDivisible(int n)
        {
            bool isValid = false;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    isValid = true;
                }
                if (isValid)
                {
                    for (int j = 1; j < n; j++)
                    {
                        int sumOfDigits = 0;
                        int currentNumber = i;
                        while (currentNumber > 0)
                        {

                            int digit = currentNumber % 10;
                            sumOfDigits += digit;
                            currentNumber /= 10;
                        }
                        if (sumOfDigits % 8 != 0)
                        {
                            isValid = false;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(i);
                    }
                    isValid = false;
                }
            }
        }
    }
}
