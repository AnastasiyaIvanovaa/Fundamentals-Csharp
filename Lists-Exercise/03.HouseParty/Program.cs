using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] name = command.Split();
                if (name.Length == 3)
                {
                    if (!names.Contains(name[0]))
                    {
                        names.Add(name[0]);
                    }
                    else if (names.Contains(name[0]))
                    {
                        Console.WriteLine($"{name[0]} is already in the list!");
                    }
                }
                if (name.Length==4)
                {
                    if (names.Contains(name[0]))
                    {
                        names.Remove(name[0]);
                    }
                    else if(!names.Contains(name[0]))
                    {
                        Console.WriteLine($"{name[0]} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join("\n", names));
        }
    }
}


