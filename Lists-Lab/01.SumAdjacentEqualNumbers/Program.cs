using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> adjust = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 0; i < adjust.Count; i++)
            {
                if (i==adjust.Count-1)
                {
                    continue;
                }
                if (adjust[i]==adjust[i+1])
                {
                    adjust[i] += adjust[i + 1];
                    adjust.Remove(adjust[i + 1]);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ",adjust));
        }
    }
}
