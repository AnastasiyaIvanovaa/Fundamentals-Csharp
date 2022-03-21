using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split();
                Box box = new Box();
                box.Item = new Item();
                box.Item.Price = double.Parse(input[3]);
                box.ItemQuantity = int.Parse(input[2]);
                box.SerialNumber = input[0];
                box.PriceForABox = box.ItemQuantity * box.Item.Price;
                box.Item.Name = input[1];
                boxes.Add(box);
                command = Console.ReadLine();
            }
            foreach (var item in boxes.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine($"{item.SerialNumber}\n-- {item.Item.Name} - ${item.Item.Price:f2}: {item.ItemQuantity}\n-- ${item.PriceForABox:f2}");
            }
        }
    }

    class Item
    {
        public string Name;
        public double Price;
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber;
        public Item Item;
        public int ItemQuantity;
        public double PriceForABox;

    }
}
