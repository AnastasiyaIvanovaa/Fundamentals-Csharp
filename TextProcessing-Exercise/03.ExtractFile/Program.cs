using System;

namespace _3.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int firstIndex = input.LastIndexOf("\\");
            int secondIndex = input.IndexOf(".");
            Console.WriteLine($"File name: {input.Substring(firstIndex + 1, secondIndex - firstIndex - 1)}\nFile extension: {input.Substring(secondIndex + 1)}");
        }
    }
}
