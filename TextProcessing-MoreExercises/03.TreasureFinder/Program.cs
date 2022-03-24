using System;
using System.Linq;
using System.Text;

namespace _03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string found = "";
            string input = Console.ReadLine();
            while (input != "find")
            {
                StringBuilder command = new StringBuilder(input);
                while (command.Length > 0)
                {
                    for (int i = 0; i < key.Length; i++)
                    {
                        char current = (char)(command[0] - key[i]);
                        found += current.ToString();
                        command.Remove(0, 1);

                        if (command.Length == 0)
                        {
                            break;
                        }
                    }
                }
                int firstTypeIndex = found.IndexOf('&');
                int secondTypeIndex = found.LastIndexOf('&');
                int firstCoordinate = found.IndexOf('<');
                int secondCoordinate = found.IndexOf('>');
                string type = found.Substring(firstTypeIndex + 1, secondTypeIndex - firstTypeIndex - 1);
                Console.WriteLine($"Found {type} at {found.Substring(firstCoordinate + 1, secondCoordinate - firstCoordinate - 1)}");
                found = "";
                input = Console.ReadLine();
            }
        }
    }
}
