using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] people = new int[count];
            int sum = 0;
                for (int i = 0; i < count; i++)
            {
                people[i] =int.Parse( Console.ReadLine());
                sum += people[i];
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(people[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
