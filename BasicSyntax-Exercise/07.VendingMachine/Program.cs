using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (input!="Start")
            {
                double money = double.Parse(input);
                if (money==2 || money==1 || money==0.5 || money==0.2|| money==0.1)
                {
                    sum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                input = Console.ReadLine();
            }
            
            string command = Console.ReadLine();
            
            
            double price = 0;
            while (command!="End")
            {
                if (command != "Nuts" && command != "Water" && command != "Crisps" && command != "Soda" && command != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                if (command == "Nuts")
                {
                    price = 2;
                    if (sum >= price)
                    {
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Water")
                {
                    price = 0.7;
                    if (sum>=price)
                    {
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command=="Crisps")
                {
                    price = 1.5;
                    if (sum >= price)
                    {
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command=="Soda")
                {
                    price = 0.8;
                    if (sum >= price)
                    {
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command=="Coke")
                {
                    price = 1;
                    if (sum >= price)
                    {
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }

    }
}
