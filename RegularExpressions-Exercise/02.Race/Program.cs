using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> participants = new Dictionary<string, double>();
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < names.Length; i++)
            {
                participants.Add(names[i], 0);
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string currentName = "";
                double distance = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        distance += input[i];
                    }
                    if (char.IsLetter(input[i]))
                    {
                        currentName += input[i];
                    }
                }
                if (participants.ContainsKey(currentName))
                {
                    participants[currentName] += distance;
                }
                input = Console.ReadLine();
            }

            List<string> winners = new List<string>();
            foreach (var item in participants.OrderByDescending(x => x.Value).Take(3))
            {
                winners.Add(item.Key);
            }

            for (int i = 1; i <= 3; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine($"1st place: {winners[0]}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"2nd place: {winners[1]}");
                }
                else
                {
                    Console.WriteLine($"3rd place: {winners[2]}");
                }
            }
        }
    }
}
