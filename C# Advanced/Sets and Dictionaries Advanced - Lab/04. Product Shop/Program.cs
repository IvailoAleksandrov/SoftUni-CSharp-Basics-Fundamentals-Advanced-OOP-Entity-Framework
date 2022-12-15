using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            while (command != "Revision")
            {
                string[] tokens = command.Split(", ");
                string shopName = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops[shopName] = new Dictionary<string, double>();
                }
                //shops[shopName][product] = price;
                shops[shopName].Add(product, price);
                command = Console.ReadLine();
            }

            foreach (var shop in shops.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
