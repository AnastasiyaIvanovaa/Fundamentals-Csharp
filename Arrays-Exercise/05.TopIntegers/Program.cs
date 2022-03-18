using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string newArray = string.Empty;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    if (array[i] > array[j])
                    {
                        newArray += array[i] + " ";
                    }
                }
            }
            if (array[array.Length - 2] > array[array.Length - 1])
            {
                newArray += array[array.Length - 1];
            }
            Console.WriteLine(newArray);
        }
    }
}
