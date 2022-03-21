using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] input = command.Split();
                if (input[0]=="Add")
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    for (int i =0; i< wagons.Count;i++)
                    {
                        int count = int.Parse(input[0]);
                        if (wagons[i]+count<=capacity)
                        {
                            wagons[i] += count;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
