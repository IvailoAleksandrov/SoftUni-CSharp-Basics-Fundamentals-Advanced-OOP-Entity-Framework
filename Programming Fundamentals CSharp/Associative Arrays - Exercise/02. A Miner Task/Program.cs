using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            Dictionary<string, int> treasury = new Dictionary<string, int>();

            while (item != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!treasury.ContainsKey(item))
                {
                    treasury.Add(item, 0);
                }

                treasury[item] += quantity;

                item= Console.ReadLine();
            }

            foreach (var treas in treasury)
            {
                Console.WriteLine($"{treas.Key} -> {treas.Value}");
            }
        }
    }
}
