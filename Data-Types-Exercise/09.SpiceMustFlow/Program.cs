using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int daysCount = 0;
            int spiceAmount = 0;
            while (startingYield>99)
            {
                spiceAmount += startingYield - 26;
                daysCount += 1;
                startingYield -= 10;
            }
            if (daysCount>0)
            {
                spiceAmount -= 26;
            }
            Console.WriteLine(daysCount);
            Console.WriteLine(spiceAmount);
        }
    }
}
