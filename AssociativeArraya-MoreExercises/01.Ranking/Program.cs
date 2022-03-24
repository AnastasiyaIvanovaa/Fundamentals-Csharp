using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string command = Console.ReadLine();
            while (command != "end of contests")
            {
                string[] input = command.Split(":");

                if (!contests.ContainsKey(input[0]))
                {
                    contests.Add(input[0], input[1]);
                }

                command = Console.ReadLine();
            }

            string checking = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> users = new Dictionary<string, Dictionary<string, double>>();

            while (checking != "end of submissions")
            {
                string[] input = checking.Split("=>");
                string contest = input[0];
                string password = input[1];
                string name = input[2];
                double points = double.Parse(input[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {

                    if (!users.ContainsKey(name))
                    {
                        users.Add(name, new Dictionary<string, double>());
                    }
                    if (!users[name].ContainsKey(contest))
                    {
                        users[name].Add(contest, 0);
                    }
                    if (users[name][contest] < points)
                    {
                        users[name][contest] = points;
                    }
                }
                checking = Console.ReadLine();
            }

            string bestCandidate = string.Empty;
            double maxPoints = 0;
            foreach (var user in users)
            {
                double sum = 0;
                foreach (var item in user.Value)
                {
                    sum += item.Value;
                }
                if (sum > maxPoints)
                {
                    maxPoints = sum;
                    bestCandidate = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}");
                foreach (var contest in user.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
