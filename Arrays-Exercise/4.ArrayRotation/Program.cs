using System;
using System.Linq;

namespace _4.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());
            
            for (int j = 0; j < rotationsCount; j++)
            {
                int firstNumber = array[0];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[array.Length - 1] = firstNumber;
            }
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
