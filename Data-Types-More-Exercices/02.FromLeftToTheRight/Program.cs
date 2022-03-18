using System;
using System.Numerics;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
             string[]  input= Console.ReadLine().Split();
                BigInteger[] numbers = {BigInteger.Parse(input[0]),BigInteger.Parse(input[1])};
                Array.Sort(numbers);
                numbers[1] = BigInteger.Abs(numbers[1]);
                input[1] = numbers[1].ToString();
                BigInteger sum = 0;

                foreach (var digit in input[1])
                {
                    sum += (BigInteger)char.GetNumericValue(digit);
                }
                Console.WriteLine(BigInteger.Abs(sum));

            }
        }
    }
}
