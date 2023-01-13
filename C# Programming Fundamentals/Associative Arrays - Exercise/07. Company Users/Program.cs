using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (command != "End")
            {
                string[] tokens = command.Split(" -> ");
                string name = tokens[0];    
                string ID = tokens[1];

                if (!companies.ContainsKey(name))
                {
                    companies.Add(name, new List<string>());
                }
                if (companies[name].Contains(ID))
                {
                    command = Console.ReadLine();
                    continue;
                }

                companies[name].Add(ID);

                command = Console.ReadLine();
            }

            foreach (var id in companies)
            {
                Console.WriteLine($"{id.Key}");

                foreach (var item in id.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
