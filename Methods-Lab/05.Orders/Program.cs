using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double result = 0;
            Orders(command, quantity,result);
        }

        private static void Orders(string a, int b, double c)
        {
           
            if (a=="coffee")
            {
                c= b * 1.5;
            }
            else if (a=="water")
            {
                c = b * 1;
            }
            else if(a=="coke")
            {
                c = b * 1.4;
            }
            else if (a=="snacks")
            {
                c = b * 2;
            }
            Console.WriteLine($"{c:f2}");
        }
    }
}
