using System;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    result += input[i];
                }
            }
            if (result[result.Length - 1] != input[input.Length - 1])
            {
                result += input[input.Length - 1];
            }
            Console.WriteLine(result);
        }
    }
}
