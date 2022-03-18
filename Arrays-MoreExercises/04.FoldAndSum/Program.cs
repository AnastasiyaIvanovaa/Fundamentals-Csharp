using System;
using System.Linq;

namespace _04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] foldAndSum = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int count = foldAndSum.Length / 4;
            int[] result = new int[count*2];

            for (int i = 0; i < count; i++)
            {
                result[i] = foldAndSum[count-i-1];
            }
            int[] end = new int[count];
            
                for (int j = 0; j < count; j++)
                {
                    end[j] = foldAndSum[foldAndSum.Length -j-1];
                }
            
            for (int i = count; i < result.Length; i++)
            {
                result[i] = end[i-count];
            }
            for (int i = 0; i < result.Length; i++)
            {
                result[i] += foldAndSum[i + count];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
