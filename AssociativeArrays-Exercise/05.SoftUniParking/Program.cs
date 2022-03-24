using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> username = new Dictionary<string, string>();
            

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] input = command.Split().ToArray();
                if (input[0] == "register")
                {
                    if (!username.ContainsKey(input[1]))
                    {
                        username.Add(input[1], input[2]);
                        Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (!username.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                    else
                    {
                        username.Remove(input[1]);
                        Console.WriteLine($"{input[1]} unregistered successfully");
                    }
                }
            }
            foreach (var user in username)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
