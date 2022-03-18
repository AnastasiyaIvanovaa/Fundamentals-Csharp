using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string input = Console.ReadLine();
            //    int first = int.Parse(Console.ReadLine());
            //    int second = int.Parse(Console.ReadLine());
            //    int result = 0;
            //    Manipulation(input, first, second,result);
            //}

            //private static void Manipulation(string command, int a, int b,int c)
            //{
            //    if (command=="substract")
            //    {
            //        c = a - b;
            //    }
            //    else if (command=="add")
            //    {
            //        c = a + b;
            //    }
            //    else if (command == "multiply")
            //    {
            //        c = a * b;
            //    }
            //    else if (command == "divide")
            //    {
            //        c = a / b;
            //    }
            //    Console.WriteLine(c);

            string command = Console.ReadLine();
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            
            switch (command)
            {
                case "add":
                    Add(first, second);
                    break;
                default:
                    break;
            }
            
            Operations(command, first,second);
        }

        private static void Add(int a, int b)
        {
            int result = a + b;
        }

        private static void Operations(string a, int b, int c)
        {
            switch (a)
            {
                case "add":
                    Add(b, c);
                    break;
                case "substract":
                    Substract(b, c);
                default:
                    break;
            }
        }
    }
}
