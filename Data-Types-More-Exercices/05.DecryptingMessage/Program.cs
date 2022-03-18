using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < count; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int number = (int)symbol+key;
                symbol = (char)number;
                result += symbol;
            }
            Console.WriteLine(result);
        }
    }
}
