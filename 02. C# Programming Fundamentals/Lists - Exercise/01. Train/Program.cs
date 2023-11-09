using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split();
                

                if (tokens.Length == 2)
                {
                    int newWagon = int.Parse(tokens[1]);
                    wagons.Add(newWagon);
                }

                if (tokens.Length == 1)
                {
                    int passangers = int.Parse(tokens[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangers <= maxCapacity)
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", wagons));




        }
    }
}
