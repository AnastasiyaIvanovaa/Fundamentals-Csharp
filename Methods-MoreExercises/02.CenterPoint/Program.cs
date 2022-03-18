using System;

namespace _02.CenterPodouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double bestX = 0;
            double bestY = 0;
            double distance1 = Math.Pow(x1, 2) + Math.Pow(y1, 2); 
            double distance2 = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            if (Math.Abs(x1)== Math.Abs(y1))
            {
                Console.WriteLine(x1);
            }
            else if(Math.Abs(x2)==Ma)
            {

            }
            if (distance1<distance2)
            {
                if (x1<y1)
                {
                    Console.WriteLine($"({x1}, {y1})");
                }
                else
                {
                    Console.WriteLine($"({y1}, {x1})");
                }
            }
            else
            {
                if (x2<y2)
                {
                    Console.WriteLine($"({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({y2}, {x2})");
                }
            }
        }
    }
}
