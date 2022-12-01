using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            while (input != "Sail")
            {
                string[] info = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string town = info[0];
                int population = int.Parse(info[1]);
                int gold = int.Parse(info[2]);

                if (!cities.ContainsKey(town))
                {
                    cities.Add(town, new List<int> { population, gold });
                }
                else
                {
                    cities[town][0] += population;
                    cities[town][1] += gold;
                }
                input = Console.ReadLine();
            }
            string input2 = Console.ReadLine();
            while (input2 != "End")
            {
                string[] tokens = input2.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string town = tokens[1];
                
                if (action == "Plunder")
                {
                    int people = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);

                    cities[town][0] -= people;
                    cities[town][1] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");


                    if (cities[town][0] <= 0 || cities[town][1] <= 0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (action == "Prosper")
                {
                    int gold = int.Parse(tokens[2]);

                    if (int.Parse(tokens[2]) >= 0)
                    {
                        cities[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                       
                    }
                }
                input2 = Console.ReadLine();
            }

            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

            foreach (var item in cities)
            {

                Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
            }
        }
    }
}
