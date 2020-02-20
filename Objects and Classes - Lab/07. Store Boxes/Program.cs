using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Program
    {
        class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
        class Box
        {
            public Box()
            {
                Item = new Item();
            }
            public int SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public double PriceForBox { get; set; }
        }
        static void Main(string[] args)
        {
            string commandLine = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            int counter = 0;

            while (commandLine != "end")
            {
                List<string> tokens = commandLine.Split().ToList();
                int serialNumber = int.Parse(tokens[0]);
                Item nameAndPrice = new Item()
                {
                    Name = tokens[1],
                    Price = double.Parse(tokens[3])
                };
                int itemQuantity = int.Parse(tokens[2]);
                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = nameAndPrice,
                    ItemQuantity = itemQuantity,
                    PriceForBox = itemQuantity * nameAndPrice.Price

                };
                boxes.Add(box);

                commandLine = Console.ReadLine();

            }
            List<Box> sortetList = boxes.OrderBy(o => o.PriceForBox).ToList();
            sortetList.Reverse();

            foreach (Box box in sortetList)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");

            }
        }
    }
}

