using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string modelOfTheKeg = "";
            string isBigger = "";
            double volumeBigger = 0;
            for (int i = 0; i < input; i++)
            {
                modelOfTheKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius*radius * height;
                if (volume>volumeBigger)
                {
                    volumeBigger = volume;
                    isBigger = modelOfTheKeg;
                }
            }
            Console.WriteLine(isBigger);
        }
    }
}
