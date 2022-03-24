using System;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace _1.ValidUsernames
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] names = Console.ReadLine().Split(", ");
                bool isValid = true;

                foreach (var item in names)
                {
                    if (item.Length < 3 || item.Length > 16)
                    {
                        isValid = false;
                        continue;
                    }

                    foreach (var symbol in item)
                    {
                        if (char.IsDigit(symbol) || char.IsLetter(symbol) || symbol == '-' || symbol == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
    Console.WriteLine("Hello World!");
        }
    }
}
