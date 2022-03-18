using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int openningCount = 0;
            int closingCount = 0;

            for (int i = 0; i < count; i++)
            {
                string currentSymbol = Console.ReadLine();
                if (currentSymbol == "(")
                {
                    openningCount++;

                }
                else if (currentSymbol == ")")
                {
                    closingCount++;
                    if (openningCount - closingCount != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }
            Console.WriteLine(openningCount == closingCount ? "BALANCED" : "UNBALANCED");

        }
    }
}

