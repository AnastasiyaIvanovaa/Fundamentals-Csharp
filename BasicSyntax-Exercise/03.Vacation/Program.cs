using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (group == "Students")
            {
                if (day == "Friday")
                {
                    price = count * 8.45;
                    if (count>=30)
                    {
                        price *= 0.85;
                    }
                }
               else if (day == "Saturday")
                {
                    price = count * 9.80;
                    if (count >= 30)
                    {
                        price *= 0.85;
                    }
                }
                else if (day == "Sunday")
                {
                    price = count * 10.46;
                    if (count >= 30)
                    {
                        price *= 0.85;
                    }
                }
            }
            else if (group == "Business")
            {
                if (day == "Friday")
                {
                    price = count * 10.90;
                    if (count >= 100)
                    {
                        price -=109;
                    }
                }
                else if (day == "Saturday")
                {
                    price = count * 15.60;
                    if (count >= 100)
                    {
                        price -= 156;
                    }
                }
                else if (day == "Sunday")
                {
                    price = count * 16;
                    if (count >= 100)
                    {
                        price -=160;
                    }
                }
            }
            else if (group == "Regular")
            {
                if (day == "Friday")
                {
                    price = count * 15;
                    if (count >= 10 && count <=20)
                    {
                        price *= 0.95;
                    }
                }
                else if (day == "Saturday")
                {
                    price = count * 20;
                    if (count >= 10 && count <= 20)
                    {
                        price *= 0.95;
                    }
                }
                else if (day == "Sunday")
                {
                    price = count * 22.50;
                    if (count >= 10 && count <= 20)
                    {
                        price *= 0.95;
                    }
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
