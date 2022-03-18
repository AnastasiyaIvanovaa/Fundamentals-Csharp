using System;
using System.Linq;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] array = new int[input];
            int[] arrayNew = new int[input];
            int[] print = null;

            array[0] = 1;
            arrayNew[0] = 1;
            Console.WriteLine(1);
            for (int i = 1; i < input; i++)
            {
                for (int j = 1; j < input; j++)
                {

                    arrayNew[j] = array[j] + array[j - 1];

                }

                array = arrayNew.ToArray();
                print = new int[array.Length - array.Count(x => x == int.Parse("0"))];
                for (int j = 0; j < print.Length; j++)
                {
                    print[j] = array[j];
                }
                Console.WriteLine(string.Join(" ", print));
            }
        }
    }
}