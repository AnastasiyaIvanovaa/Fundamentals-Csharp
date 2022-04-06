using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            MatchCollection match = regex.Matches(input);

            foreach (Match item in match)
            {
                Console.Write(item.Value + " ");
            }

        }
    }
}
