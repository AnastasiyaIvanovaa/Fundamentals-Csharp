using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            if (type == "int")
            {
                int firstInt = int.Parse(firstValue);
                int secondtInt = int.Parse(secondValue);
                int result = GetMax(firstInt, secondtInt);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                char result = (char)GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                if (firstValue.CompareTo(secondValue)>0)
                {
                    Console.WriteLine(firstValue);
                }
               
                else
                {
                    Console.WriteLine(secondValue);
                }

            }

        }

        static int GetMax(int firstInt, int secondInt)
        {

            if (firstInt > secondInt)
            {
                return firstInt;
            }
            return secondInt;
        }
    }
}
