using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destoyedPlanets = new List<string>();

            for (int i = 0; i < count; i++)
            {
                int key = 0;
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 's' || input[j] == 'S' || input[j] == 't' || input[j] == 'T' || input[j] == 'a' || input[j] == 'A' || input[j] == 'r' || input[j] == 'R')
                    {
                        key++;
                    }
                }
                string currentMessage = "";
                for (int k = 0; k < input.Length; k++)
                {
                    currentMessage += (char)(input[k] - key);
                }

                Regex planet = new Regex(@"@(?<planet>[A-Z][a-z]+)");
                Regex population = new Regex(@":[0-9]+");
                Regex attackType = new Regex(@"\![AD]\!");
                Regex soldiers = new Regex(@"->[0-9]+");

                Match planetMatch = planet.Match(currentMessage);
                Match populationMatch = population.Match(currentMessage);
                Match attackMatch = attackType.Match(currentMessage);
                Match soldiiersMatch = soldiers.Match(currentMessage);

                if (planetMatch.Success && populationMatch.Success && attackMatch.Success && soldiiersMatch.Success)
                {
                    string attack = attackMatch.Value;
                    if (attack == "!A!")
                    {
                        attackedPlanets.Add(planetMatch.Value.Substring(1, planetMatch.Value.Length - 1));
                    }
                    else
                    {
                        destoyedPlanets.Add(planetMatch.Value.Substring(1, planetMatch.Value.Length - 1));
                    }
                }
            }
            attackedPlanets.Sort();
            destoyedPlanets.Sort();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                foreach (var item in attackedPlanets)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destoyedPlanets.Count}");
            if (destoyedPlanets.Count > 0)
            {
                foreach (var item in destoyedPlanets)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
    }
}
