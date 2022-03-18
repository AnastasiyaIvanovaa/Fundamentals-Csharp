using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int vowelsCount = 0;
            vowelsCount = VowelsCount(input, vowelsCount);
        }

        private static int VowelsCount(string input, int vowelsCount)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] == 65 || (int)input[i] == 69 || (int)input[i] == 73 || (int)input[i] == 79 || (int)input[i] == 85 || (int)input[i] == 97 || (int)input[i] == 101 || (int)input[i] == 105 || (int)input[i] == 111 || (int)input[i] == 117)
                {
                    vowelsCount++;
                }
            }
            Console.WriteLine(vowelsCount);
            return vowelsCount;
        }
    }
}
