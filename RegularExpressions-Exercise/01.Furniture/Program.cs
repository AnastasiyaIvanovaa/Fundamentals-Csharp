using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();

            string command = Console.ReadLine();
            Regex pattern = new Regex(@">>(?<furnitureName>[A-Z][a-z]+|[A-Z]+)<<(?<price>[0-9.]+)!(?<quantity>[0-9]+)");
            double sum = 0;

            while (command != "Purchase")
            {
                MatchCollection match = pattern.Matches(command);
                foreach (Match item in match)
                {
                    string furn = item.Groups["furnitureName"].Value;
                    furniture.Add(furn);
                    double price = double.Parse(item.Groups["price"].Value);
                    int quantity = int.Parse(item.Groups["quantity"].Value);
                    sum += price * quantity;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
