using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            RepeatString(input, count);
        }
        //    Repeat(input, count);
        //}

        //private static void Repeat(string input, int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.Write(input);
        //    }
        static string RepeatString(string str, int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(str);
                return result.ToString();
            }
        }
    }
}
