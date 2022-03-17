using System;

namespace _4.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int currentMinutes = minutes + 30;
            if (currentMinutes>=60)
            {
                hours += 1;
                minutes = currentMinutes- 60;
                if (hours==24)
                {
                    hours = 0;
                }
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
