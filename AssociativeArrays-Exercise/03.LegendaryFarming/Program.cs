using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string[] current = Console.ReadLine().Split();
            bool isObtained = true;
            while (isObtained)
            {

                for (int i = 1; i < current.Length; i += 2)
                {
                    string currentElement = current[i].ToLower();
                    if (currentElement == "shards" || currentElement == "motes" || currentElement == "fragments")
                    {
                        if (!materials.ContainsKey(currentElement))
                        {
                            materials.Add(currentElement, 0);
                        }
                        materials[currentElement] += int.Parse(current[i - 1]);
                    }
                    if (materials[currentElement] >= 250)
                    {
                        if (currentElement == "shards")
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            materials[currentElement] -= 250;
                            isObtained = false;
                        }
                        else if (currentElement == "fragments")
                        {
                            Console.WriteLine("Valanyr obtained!");
                            materials[currentElement] -= 250;
                            isObtained = false;
                        }
                        else if (currentElement == "motes")
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            materials[currentElement] -= 250;
                            isObtained = false;
                        }
                    }
                    else if (currentElement !="motes" && currentElement!="fragments" && currentElement!="shards")
                    {
                        if (!junk.ContainsKey(currentElement))
                        {
                            junk.Add(currentElement, 0);
                        }
                        junk[currentElement] += int.Parse(current[i - 1]);
                        current = Console.ReadLine().Split();
                    }
                }
            }
            materials.OrderBy(n => n.Value).ThenBy(n=>n.Key);
            junk.OrderBy(n => n.Key);
            foreach (var item in materials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}

