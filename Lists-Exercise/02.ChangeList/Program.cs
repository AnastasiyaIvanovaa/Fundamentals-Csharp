using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] input = command.Split();
                if (input[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i]==int.Parse(input[1]))
                        {
                            numbers.Remove(int.Parse(input[1]));
                            i -= 1;
                        }
                    }
                }
                else if (input[0]== "Insert")
                {
                    int index = int.Parse(input[2]);
                    int number = int.Parse(input[1]);
                    numbers.Insert(index, number);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
