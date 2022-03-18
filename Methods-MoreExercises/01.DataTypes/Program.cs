using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            NewMethod(input);
        }

        private static void NewMethod(string input)
        {
            string command = Console.ReadLine();
            switch (input)
            {
                case "int":
                    int result = int.Parse(command) * 2;
                    Console.WriteLine(result);
                    break;
                case "real":
                    double resultOne = double.Parse(command) * 1.5;
                    Console.WriteLine($"{resultOne:f2}");
                    break;
                case "string":
                    Console.WriteLine($"${command}$");
                    break;
            }
        }
    }
}
