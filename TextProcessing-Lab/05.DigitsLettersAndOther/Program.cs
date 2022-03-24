using System;

namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = "";
            string letters = "";
            string symbols = "";
            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];
                if (char.IsDigit(currentSymbol))
                {
                    digits += currentSymbol;
                }
                else if (char.IsLetter(currentSymbol))
                {
                    letters += currentSymbol;
                }
                else
                {
                    symbols += currentSymbol;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);

        }
    }
}
