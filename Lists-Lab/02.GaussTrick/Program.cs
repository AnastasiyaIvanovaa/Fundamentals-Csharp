using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> gauss = Console.ReadLine().Split().Select(double.Parse).ToList();
            if (gauss.Count % 2 == 0)
            {
                for (int i = 0; i < gauss.Count; i++)
                {
                    gauss[i] += gauss[gauss.Count - 1];
                    gauss.Remove(gauss[gauss.Count - 1]);

                }
            }
            else
            {
                for (int i = 0; i < gauss.Count/2; i++)
                {
                    gauss[i] += gauss[gauss.Count - 1];
                    gauss.Remove(gauss[gauss.Count - 1]);

                }
            }
            Console.WriteLine(string.Join(" ",gauss));
        }
    }
}
