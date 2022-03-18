using System;

namespace _04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isPrimee = true;
            for (int isPrime = 2; isPrime < number; isPrime++)
            {
                
                for (int devider = 0; devider < number; devider++)
                {
                    if (isPrime%devider==0)
                    {
                        isPrimee = false;
                        break;
                    }
                }
            }
            Console.WriteLine("{0} -> {1}",isPrime,isPrimee);
        }
    }
}
