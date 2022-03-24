using System;
using System.Text;

namespace _7.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            int bomb = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (bomb > 0 && input[i] != '>')
                {
                    input.Remove(i, 1);
                    bomb--;
                    i--;
                }
                else
                {
                    if (input[i] == '>')
                    {
                        bomb += int.Parse(input[i + 1].ToString());
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
