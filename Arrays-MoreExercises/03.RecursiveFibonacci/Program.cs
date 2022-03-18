using System;
using System.Collections.Generic;

namespace _03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fibonacci = new List<int>() { 1,1};

            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
            }

            Console.WriteLine(fibonacci[fibonacci.Count-1]);
        }
    }
}
