using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            bool isIdentical = true;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                sum += arrayOne[i];
                if (arrayOne[i]!=arrayTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isIdentical = false;
                    break;
                }
            }
            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            
        }
    }
}
