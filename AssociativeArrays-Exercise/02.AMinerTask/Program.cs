using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> metal = new Dictionary<string, int>();
            string command = Console.ReadLine();
            
            while (command!="stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!metal.ContainsKey(command))
                {
                    metal.Add(command,0);
                }
                metal[command] += quantity;
                command = Console.ReadLine();
            }
            foreach (var item in metal)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
