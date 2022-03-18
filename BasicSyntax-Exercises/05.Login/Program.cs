using System;
using System.Linq;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string usernameReversed = "";
            int count = 0;
            for (int i = username.Length-1; i >=0; i--)
            {
                usernameReversed += username[i];
            }
            while (password!=usernameReversed)
            {
                Console.WriteLine("Incorrect password. Try again.");
                count++;
                if (count == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                password = Console.ReadLine();
            }
            if (password==usernameReversed)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
