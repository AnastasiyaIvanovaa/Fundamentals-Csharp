using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex customer = new Regex(@"%(?<customer>[A-Z][a-z]+)%");
            Regex product = new Regex(@"<(?<product>[A-Z][a-z]+)>");
            Regex count = new Regex(@"\|(?<count>[0-9]+)\|");
            Regex price = new Regex(@"(?<price>[0-9]+\.?[0-9]{0,2})\$");
            string command = Console.ReadLine();

            double sum = 0;

            while (command != "end of shift")
            {
                string customerName = "";
                string productName = "";
                int quantity = 0;
                double currentPrice = 0;
                MatchCollection match = customer.Matches(command);
                foreach (Match item in match)
                {
                    customerName = item.Groups["customer"].Value;
                }
                MatchCollection matchOne = product.Matches(command);
                foreach (Match item in matchOne)
                {
                    productName = item.Groups["product"].Value;
                }
                MatchCollection matchTwo = count.Matches(command);
                foreach (Match item in matchTwo)
                {
                    quantity = int.Parse(item.Groups["count"].Value);
                }
                MatchCollection matchThree = price.Matches(command);
                foreach (Match item in matchThree)
                {
                    currentPrice = double.Parse(item.Groups["price"].Value);
                }
                if (productName != "" && quantity != 0 && currentPrice != 0 && customerName != "")
                {
                    Console.WriteLine($"{customerName}: {productName} - {currentPrice * quantity:f2}");
                    sum += currentPrice * quantity;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
