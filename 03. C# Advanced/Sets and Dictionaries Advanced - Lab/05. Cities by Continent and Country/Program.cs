using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> locations = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                string[] tokens = Console.ReadLine().Split();
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!locations.ContainsKey(continent))
                {
                    locations[continent]= new Dictionary<string, List<string>>();
                }
                if (!locations[continent].ContainsKey(country))
                {
                    locations[continent][country] = new List<string>();
                }
                locations[continent][country].Add(city);
            }
            foreach (var continent in locations.OrderBy(x=> x.Key))
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }

        }
    }
}
