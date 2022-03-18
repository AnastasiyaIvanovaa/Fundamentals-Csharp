using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string familyName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{name}{delimiter}{familyName}");
        }
    }
}
