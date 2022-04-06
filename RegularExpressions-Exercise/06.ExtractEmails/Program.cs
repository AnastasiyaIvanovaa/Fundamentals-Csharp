using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _6.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)([A-Za-z0-9]+[-._]*[A-Za-z0-9]+)@([A-Za-z]+(([-.])[A-Za-z]+)*\.[a-z]{2,})";
            List<string> dom = new List<string>();
            string input = Console.ReadLine();

            MatchCollection match = Regex.Matches(input, pattern);

            foreach (Match item in match)
            {
                dom.Add(item.Value);
            }
            foreach (var item in dom)
            {
                Console.WriteLine(item);
            }
        }
    }
}
