using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //"{plant}<->{rarity}
            Dictionary<string, int> plantRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string name = command[0];
                int rarity = int.Parse(command[1]);

                if (!plantRarity.ContainsKey(name))
                {
                    plantRarity.Add(name, rarity);
                    plantRating.Add(name, new List<double>());
                }
                else
                {
                    plantRarity[name] = rarity;
                }
            }
            string newCommands = Console.ReadLine();

            while (newCommands != "Exhibition")
            {
                string[] commandInfo = newCommands.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string commandName = commandInfo[0];
                string plantName = commandInfo[1];

                if (commandName == "Rate")
                {
                    double rating = double.Parse(commandInfo[2]);
                    if (plantRating.ContainsKey(plantName))
                    {
                        plantRating[plantName].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandName == "Update")
                {
                    if (plantRarity.ContainsKey(plantName))
                    {
                        plantRarity[plantName] = int.Parse(commandInfo[2]);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandName == "Reset")
                {
                    if (plantRating.ContainsKey(plantName))
                    {
                        plantRating[plantName].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                newCommands = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");

            foreach (var (name, rarity) in plantRarity)
            {
                if (plantRating[name].Count > 0)
                {
                    double average = plantRating[name].Average();
                    Console.WriteLine($"- {name}; Rarity: {rarity}; Rating: {average:f2}");
                }
                else
                {
                    Console.WriteLine($"- {name}; Rarity: {rarity}; Rating: 0.00");
                }
                
            }
        }
    }
}
