using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            int index = input.IndexOf(key);
            while (index>=0)
            {
                input=input.Remove(index, key.Length);
                index = input.IndexOf(key);
            }
            Console.WriteLine(input);
        }
    }
}
