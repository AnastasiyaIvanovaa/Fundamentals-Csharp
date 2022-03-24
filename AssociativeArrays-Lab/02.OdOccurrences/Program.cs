using System;
using System.Collections.Generic;

namespace _02.OdOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            string[] words = Console.ReadLine().Split();

            for (int i = 0; i < words.Length; i++)
            {
                string currentString = words[i].ToLower();
                if (!count.ContainsKey(currentString))
                {
                    count.Add(currentString, 0);
                }
                count[currentString] += 1;
            }

            foreach (var item in count)
            {
                if (item.Value%2!=0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
