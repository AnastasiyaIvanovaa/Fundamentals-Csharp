using System;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] repeatWords = Console.ReadLine().Split();
            for (int i = 0; i < repeatWords.Length; i++)
            {
                for (int j = 0; j < repeatWords[i].Length; j++)
                {
                    Console.Write(repeatWords[i]);
                }
            }
        }
    }
}
