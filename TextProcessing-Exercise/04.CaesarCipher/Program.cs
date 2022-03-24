using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                int current = input[i] + 3;
                char buchstabe = (char)current;
                result += buchstabe;
            }
            Console.WriteLine(result);
        }
    }
}
