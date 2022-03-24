using System;

namespace _05.HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string hOne = Console.ReadLine();
            Console.WriteLine($"<h1>\n    {hOne}\n</h1>");

            Console.WriteLine($"<article>\n    {Console.ReadLine()}\n</article>");

            string command = Console.ReadLine();

            while (command != "end of comments")
            {
                Console.WriteLine($"<div>\n    {command}\n</div>");
                command = Console.ReadLine();
            }
        }
    }
}
