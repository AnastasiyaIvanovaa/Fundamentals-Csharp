using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (first.Count > 0 && second.Count > 0)
            {
                int one = first[0];
                first.RemoveAt(0);
                int two = second[0];
                second.RemoveAt(0);
                if (one == two)
                {
                    continue;
                }
                else if (one > two)
                {
                    first.Add(one);
                    first.Add(two);
                }
                else
                {
                    second.Add(two);
                    second.Add(one);
                }
            }
            if (first.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {first.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {second.Sum()}");

            }
        }
    }
}
