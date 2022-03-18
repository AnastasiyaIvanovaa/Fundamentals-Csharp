using System;
using System.Linq;

namespace MethodsFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            array[0] = 1;
            array[1] = 1;
            array[2] = 2;
            Tribonacci(n, array);
        }

        private static void Tribonacci(int n, int[] array)
        {
            if (n > 3)
            {
                for (int i = 3; i < n; i++)
                {
                    array[i] = array[i - 1] + array[i - 2] + array[i - 3];
                }
            }

            Console.Write(string.Join(" ", array));
        }
    }
}
