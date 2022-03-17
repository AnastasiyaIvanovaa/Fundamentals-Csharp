using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputTimes = int.Parse(Console.ReadLine());
            string command = " ";
            string sms = " ";
            for (int i = 1; i <= inputTimes; i++)
            {
                command = Console.ReadLine();
                if (command.Length == 1)
                {
                    switch (command)
                    {
                        case "0":
                            sms += " ";
                            break;
                        case "2":
                            sms += "a";
                            break;
                        case "3":
                            sms += "d";
                            break;
                        case "4":
                            sms += "g";
                            break;
                        case "5":
                            sms += "j";
                            break;
                        case "6":
                            sms += "m";
                            break;
                        case "7":
                            sms += "p";
                            break;
                        case "8":
                            sms += "t";
                            break;
                        case "9":
                            sms += "w";
                            break;
                    }
                }
                else if (command.Length == 2)
                {
                    switch (command)
                    {
                        case "22":
                            sms += "b";
                            break;
                        case "33":
                            sms += "e";
                            break;
                        case "44":
                            sms += "h";
                            break;
                        case "55":
                            sms += "k";
                            break;
                        case "66":
                            sms += "n";
                            break;
                        case "77":
                            sms += "q";
                            break;
                        case "88":
                            sms += "u";
                            break;
                        case "99":
                            sms += "x";
                            break;
                    }
                }
                else if (command.Length == 3)
                {
                    switch (command)
                    {
                        case "222":
                            sms += "c";
                            break;
                        case "333":
                            sms += "f";
                            break;
                        case "444":
                            sms += "i";
                            break;
                        case "555":
                            sms += "l";
                            break;
                        case "666":
                            sms += "o";
                            break;
                        case "777":
                            sms += "r";
                            break;
                        case "888":
                            sms += "v";
                            break;
                        case "999":
                            sms += "y";
                            break;
                    }
                }
                else if (command.Length == 4)
                {
                    switch (command)
                    {

                        case "7777":
                            sms += "s";
                            break;
                        case "9999":
                            sms += "z";
                            break;
                    }
                }
            }
            Console.WriteLine(sms);
        }
    }
}
