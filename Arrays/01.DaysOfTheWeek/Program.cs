using System;

namespace _01.DaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            Console.WriteLine(daysOfWeek.Length);
            Console.WriteLine(daysOfWeek[0]);
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine(daysOfWeek[i]);
            }
            Console.WriteLine(daysOfWeek[day-1]);
            if (day<1 || day>7)
            {
                Console.WriteLine("Invalid day");
            }
        }
    }
}
