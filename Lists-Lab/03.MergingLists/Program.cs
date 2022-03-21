using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstArray = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> secondArray = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> result = new List<double>();
            if (firstArray.Count>secondArray.Count)
            {
                for (int i = 0; i < secondArray.Count; i++)
                {
                    result.Add(firstArray[i]); 
                    result.Add(secondArray[i]); 
                }
                if (firstArray.Count != secondArray.Count)
                {
                    for (int i = secondArray.Count; i < firstArray.Count; i++)
                    {
                        result.Add(firstArray[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < firstArray.Count; i++)
                {
                    result.Add(firstArray[i]);
                    result.Add(secondArray[i]);
                }
                if (firstArray.Count != secondArray.Count)
                {
                    for (int i = firstArray.Count; i < secondArray.Count; i++)
                    {
                        result.Add(secondArray[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
