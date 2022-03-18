using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] array1 = new int[count];
            int[] array2 = new int[count];
            for (int i = 0; i < count; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int firstNumber = input[0];
                int secondNumber = input[1];
                if (i % 2 == 0)
                {
                    array1[i] = firstNumber;
                    array2[i] = secondNumber;
                }
                else
                {
                    array1[i] = secondNumber;
                    array2[i] = firstNumber;
                }
            }
            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ",array2));
        }
    }
}

