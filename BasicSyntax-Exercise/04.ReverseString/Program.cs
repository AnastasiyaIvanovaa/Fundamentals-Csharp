using System;
using System.Linq;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //string result = "";
            //for (int i = input.Length-1;  i>=0; i--)
            //{
            //    result += input[i];
            //}
            //Console.WriteLine(result);
            //string toReverse = Console.ReadLine();
            //string end = string.Join("", toReverse.Reverse());
            //Console.WriteLine(end);

            string toReversee = Console.ReadLine();
            Console.WriteLine(string.Join("", toReversee.Reverse()));
        }
    }
}
