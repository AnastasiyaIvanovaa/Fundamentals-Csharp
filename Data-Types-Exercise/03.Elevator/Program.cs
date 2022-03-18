using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int result = count / capacity;
            if (count%capacity!=0)
            {
                result += 1;
            }
            Console.WriteLine(result);
        }
    }
}
