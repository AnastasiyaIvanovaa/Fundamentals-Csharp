using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, V = 0;
            length = double.Parse(Console.ReadLine());
            width = double.Parse(Console.ReadLine());
            V = double.Parse(Console.ReadLine());
            V = (length * width * V) / 3;
            Console.Write("Length: Width: Height: ");
            Console.WriteLine($"Pyramid Volume: {V:f2}");

        }
    }
}
