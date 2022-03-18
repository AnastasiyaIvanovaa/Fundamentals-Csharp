using System;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                int totalSum = 0;
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    int endSum = 0;
                    int digit = (int)(input[j]);
                    if (digit == 65 || digit == 69 || digit == 73 || digit == 79 || digit == 85 || digit == 97 || digit == 101 || digit == 105 || digit == 111 || digit == 117)
                    {
                        endSum += (digit * input.Length);
                    }
                    else
                    {
                        endSum += (digit / input.Length);
                    }
                    totalSum += endSum;
                }
                result[i] = totalSum;
            }
            Array.Sort(result);
            Console.Write(string.Join("\n", result));
        }
    }
}

