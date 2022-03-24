using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sinonyms = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentKey = Console.ReadLine();
                string currentValue = Console.ReadLine();

                if (!sinonyms.ContainsKey(currentKey))
                {
                    sinonyms.Add(currentKey,new List<string>());
                }
                sinonyms[currentKey].Add(currentValue);
            }
            foreach (var sinonym in sinonyms)
            {
                Console.WriteLine($"{sinonym.Key} - {string.Join(", ", sinonym.Value)}");
            }
        }
    }
}
