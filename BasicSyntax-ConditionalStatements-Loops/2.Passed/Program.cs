﻿using System;

namespace _2.Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade>=3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
