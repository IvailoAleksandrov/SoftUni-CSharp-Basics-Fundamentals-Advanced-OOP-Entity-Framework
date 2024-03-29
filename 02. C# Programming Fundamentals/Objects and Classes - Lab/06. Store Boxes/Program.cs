﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                string[] tokens = command.Split(' ');
                
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal price = decimal.Parse(tokens[3]);

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Item = new Item(itemName, price),
                    ItemQuantity = itemQuantity,
                };
                
                boxes.Add(box);
                command = Console.ReadLine();
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(box => box.Price).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"--{box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }
    }
    class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal Price 
        { 
            get
            {
                return ItemQuantity * Item.Price;
            }
        }


    }
}
