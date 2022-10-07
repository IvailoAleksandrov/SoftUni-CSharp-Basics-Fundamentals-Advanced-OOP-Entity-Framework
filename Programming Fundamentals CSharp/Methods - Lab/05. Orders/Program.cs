using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            OrderPrice(product, quantity);
        }

        static void OrderPrice(string product, int quantity)
        {
            switch (product)
            {

                case "coffee":
                    Console.WriteLine($"{1.50 * quantity}");
                    break;
                case "water":
                    Console.WriteLine($"{(1 * quantity):f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(1.4 * quantity):f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{(2 * quantity):f2}");
                    break;
            }
        }
    }
}
