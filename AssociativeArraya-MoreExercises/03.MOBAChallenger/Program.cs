using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();

            while (command != "Season end")
            {
                if (command.Contains("->"))
                {
                    string[] users = command.Split(" -> ");
                    if (!players.ContainsKey(users[0]))
                    {
                        players.Add(users[0], new Dictionary<string, int>());
                        players[users[0]].Add(users[1], int.Parse(users[2]));
                    }
                    else
                    {
                        if (!players[users[0]].ContainsKey(users[1]))
                        {
                            players[users[0]].Add(users[1], int.Parse(users[2]));
                        }
                        else
                        {
                            if (players[users[0]][users[1]] < int.Parse(users[2]))
                            {
                                players[users[0]][users[1]] = int.Parse(users[2]);
                            }
                        }
                    }
                }
                else
                {
                    string[] users = command.Split();
                    if (players.ContainsKey(users[0]) && players.ContainsKey(users[2]))
                    {
                        if (players[users[0]].Keys.Intersect(players[users[2]].Keys).Any())
                        {
                            if (players[users[0]].Values.Sum() > players[users[2]].Values.Sum())
                            {
                                players.Remove(users[2]);
                            }
                            else if (players[users[0]].Values.Sum() < players[users[2]].Values.Sum())
                            {
                                players.Remove(users[0]);
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var player in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var role in player.Value.OrderByDescending(p => p.Value).ThenBy(r => r.Key))
                {
                    Console.WriteLine($"- {role.Key} <::> {role.Value}");
                }
            }
        }
    }
}
