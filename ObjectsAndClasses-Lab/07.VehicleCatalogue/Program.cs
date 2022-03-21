using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Catalog> listCars = new List<Catalog>();
            List<Catalog> listTrucks = new List<Catalog>();
            while (command != "end")
            {
                string[] input = command.Split("/");
                if (input[0] == "Car")
                {
                    Catalog catalog = new Catalog();
                    catalog.Car.Brand = input[1];
                    catalog.Car.Model = input[2];
                    catalog.Car.HorsePower = input[3];
                    listCars.Add(catalog);
                }
                else if (input[0] == "Truck")
                {
                    Catalog catalog = new Catalog();
                    catalog.Truck.Brand = input[1];
                    catalog.Truck.Model = input[2];
                    catalog.Truck.Weight = input[3];
                    listTrucks.Add(catalog);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Cars:");
            foreach (var car in listCars.OrderBy(x => x.Car.Brand))
            {
                Console.WriteLine($"{car.Car.Brand}: {car.Car.Model} - {car.Car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var truck in listTrucks.OrderBy(x => x.Truck.Brand))
            {
                Console.WriteLine($"{truck.Truck.Brand}: {truck.Truck.Model} - {truck.Truck.Weight}kg");
            }
        }
    }
    class Truck
    {
        public string Brand;
        public string Model;
        public string Weight;
    }

    class Car
    {
        public string Brand;
        public string Model;
        public string HorsePower;
    }

    class Catalog
    {
        public Catalog()
        {
            Truck = new Truck();
            Car = new Car();
        }
        public Truck Truck;
        public Car Car;
    }
}