using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbersOriginal = numbers;
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] command = input.Split();
                if (command[0]=="Contains")
                {
                    if (numbers.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0]=="PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (command[0]=="PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (command[0]=="GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }
                else if (command[0]=="Filter")
                {
                    if (command[1]=="<")
                    {
                        Console.WriteLine(string.Join(" ",numbers.Where(x=>x<int.Parse(command[2]))));
                    }
                    else if (command[1]==">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > int.Parse(command[2]))));

                    }
                    else if (command[1]==">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= int.Parse(command[2]))));
                    }
                    else if (command[1]=="<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= int.Parse(command[2]))));
                    }
                }
                input = Console.ReadLine();
            }
            if (numbers!=numbersOriginal)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }
}
