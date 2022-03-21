using System;
using System.Collections.Generic;

namespace _4.Student
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Students> people = new List<Students>();
            while (command != "end")
            {
                string[] data = command.Split();
                Students mensch = new Students();
                mensch.FirstName = data[0];
                mensch.LastName = data[1];
                mensch.Age = int.Parse(data[2]);
                mensch.HomeTown = data[3];
                people.Add(mensch);
                command = Console.ReadLine();
            }
            string nameOfTheCity = Console.ReadLine();
            foreach (var mensch in people)
            {
                if (mensch.HomeTown == nameOfTheCity)
                {
                    Console.WriteLine($"{mensch.FirstName} {mensch.LastName} is {mensch.Age} years old.");
                }
            }
        }
    }

    class Students
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string HomeTown;
    }
}
