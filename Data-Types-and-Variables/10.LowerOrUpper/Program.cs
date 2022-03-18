using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
           
            if (a>64 && a<91)
            {
                Console.WriteLine("upper-case");
            }
            else if (a>96 && a<123)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
