using System;

namespace _04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" | ");

            string result = "";

            foreach (var item in input)
            {
                string[] word = item.Split(" ");
                foreach (var element in word)
                {
                    if (element == "..")
                    {
                        result += "I";
                    }
                    else if (element == "--")
                    {
                        result += "M";
                    }
                    else if (element == ".-")
                    {
                        result += "A";
                    }
                    else if (element == "-..")
                    {
                        result += "D";
                    }
                    else if (element == ".")
                    {
                        result += "E";
                    }
                    else if (element == "-.--")
                    {
                        result += "Y";
                    }
                    else if (element == "---")
                    {
                        result += "O";
                    }
                    else if (element == "..-")
                    {
                        result += "U";
                    }
                    else if (element == ".--")
                    {
                        result += "W";
                    }
                    else if (element == ".-.")
                    {
                        result += "R";
                    }
                    else if (element == "-")
                    {
                        result += "T";
                    }
                    else if (element == "....")
                    {
                        result += "H";
                    }
                    else if (element == ".--.")
                    {
                        result += "P";
                    }
                    else if (element == ".-..")
                    {
                        result += "L";
                    }
                    else if (element == "--.")
                    {
                        result += "G";
                    }
                    else if (element == "-.")
                    {
                        result += "N";
                    }
                    else if (element == "-.-.")
                    {
                        result += "C";
                    }
                }
                result += " ";
            }
            Console.WriteLine(result);
        }
    }
}
