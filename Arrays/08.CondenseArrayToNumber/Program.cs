using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[numbers.Length - 1];
            for (int i = 0; i < numbers.Length-1; i++)
            {
                condensed[i] = numbers[i] + numbers[i + 1];
            }
            while (condensed[1] != 0)
            {
                for (int i = 0; i < condensed.Length-1; i++)
                {
                    condensed[i] = condensed[i] + condensed[i + 1];
                }
            }
            Console.WriteLine(condensed);

        }
    }
}
