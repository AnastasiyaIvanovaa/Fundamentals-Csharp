using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            List<string> list = new List<string>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                string[] command = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < command.Length; j++)
                {
                    list.Add(command[j]);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}