using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger ValueOfTheSnowball = 0;
            for (int i = 0; i < countOfSnowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger value = BigInteger.Pow(snow / time, quality);
                if (value>ValueOfTheSnowball)
                {
                    ValueOfTheSnowball = value;
                }
            }
            Console.WriteLine();

        }
    }
}
