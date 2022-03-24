using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> doubles = new SortedDictionary<double, int>();
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!doubles.ContainsKey(numbers[i]))
                {
                    doubles.Add(numbers[i], 0);
                }
                doubles[numbers[i]]++;
            }
            foreach (var item in doubles)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
