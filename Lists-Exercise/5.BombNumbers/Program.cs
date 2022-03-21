using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int boom = 0;
            while (list.Contains(bomb[0]))
            {
                boom = list.IndexOf(bomb[0]);
                for (int i = boom + bomb[1]; i >= boom - bomb[1]; i--)
                {
                    if (i < 0 || i > list.Count)
                    {
                        continue;
                    }
                    list.RemoveAt(i);
                }
            }
            Console.WriteLine(list.Sum());
        }
    }
}
