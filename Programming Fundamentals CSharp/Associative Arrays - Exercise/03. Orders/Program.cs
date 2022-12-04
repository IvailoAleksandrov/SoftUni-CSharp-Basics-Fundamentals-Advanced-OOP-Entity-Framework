using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string commands = Console.ReadLine();
            Dictionary<string, List<double>> items = new Dictionary<string, List<double>>();

            while (commands != "buy")
            {
                string[] input = commands.Split();
                string name = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!items.ContainsKey(name))
                {
                    items.Add(name, new List<double> { price, quantity });

                }
                else
                {
                    items[name][0] = price;
                    items[name][1] += quantity;
                }

                commands = Console.ReadLine();
            }
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }
        }
    }
}
