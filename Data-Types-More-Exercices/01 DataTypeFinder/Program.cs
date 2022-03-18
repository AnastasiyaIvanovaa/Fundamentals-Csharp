using System;

namespace _01_DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {

                bool isFalse = true;
                while (isFalse)
                {
                    string input = Console.ReadLine();
                    if (input == "END")
                    {
                    isFalse = false;
                        continue;
                    }
                    bool isChar = char.TryParse(input, out char character);
                    bool isInt = int.TryParse(input, out int integer);
                    bool isFloat = float.TryParse(input, out float floating);
                    bool isBool = bool.TryParse(input, out bool boolean);
                    string type = "";
                    if (isInt)
                    {
                        type = "integer";
                    }
                    else if (isChar)
                    {
                        type = "character";
                    }
                    else if (isFloat)
                    {
                        type = "floating point";
                    }
                    else if (isBool)
                    {
                        type = "boolean";
                    }
                    else
                    {
                        type = "string";
                    }
                    Console.WriteLine($"{input} is {type} type");
                }
            }
    }
}
