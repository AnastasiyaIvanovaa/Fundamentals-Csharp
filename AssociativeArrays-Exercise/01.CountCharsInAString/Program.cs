using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> symbols = new Dictionary<char, int>();
            string[] words = Console.ReadLine().Split();
            for (int i = 0; i < words.Length; i++)
            {
                string currentElement = words[i];
                for (int j = 0; j < currentElement.Length; j++)
                {
                    char currentSymbol = currentElement[j];
                    if (!symbols.ContainsKey(currentSymbol))
                    {
                        symbols.Add(currentSymbol, 0);
                    }
                    symbols[currentSymbol]++;
                }
            }
            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }
        }
    }
}
