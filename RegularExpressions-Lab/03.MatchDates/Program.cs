using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<day>\d{2})(.)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})");
            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);
            foreach (Match item in matches)
            {
                Console.WriteLine($"Day: {item.Groups["day"]}, Month: {item.Groups["month"]}, Year: {item.Groups["year"]}");
            }

        }
    }
}
