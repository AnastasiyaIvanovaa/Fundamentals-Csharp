using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> individualStandings = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] command = input.Split(" -> ");
                string userName = command[0];
                string contest = command[1];
                int points = int.Parse(command[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                    contests[contest].Add(userName, points);
                }

                else
                {
                    if (contests[contest].ContainsKey(userName))
                    {
                        if (contests[contest][userName] < points)
                        {
                            contests[contest][userName] = points;
                        }
                    }
                    else
                    {
                        contests[contest].Add(userName, points);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var contest in contests)
            {
                foreach (var user in contest.Value)
                {
                    if (!individualStandings.ContainsKey(user.Key))
                    {
                        individualStandings.Add(user.Key, user.Value);
                    }
                    else
                    {
                        individualStandings[user.Key] += user.Value;
                    }
                }
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");
                int i = 1;
                foreach (var item in contest.Value.OrderByDescending(x => x.Value).ThenBy(s => s.Key))
                {
                    Console.WriteLine($"{i}. {item.Key} <::> {item.Value}");
                    i++;
                }
            }

            int j = 1;
            Console.WriteLine("Individual standings: ");

            foreach (var item in individualStandings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{j}. {item.Key} -> {item.Value}");
                j++;
            }

        }
    }
}
