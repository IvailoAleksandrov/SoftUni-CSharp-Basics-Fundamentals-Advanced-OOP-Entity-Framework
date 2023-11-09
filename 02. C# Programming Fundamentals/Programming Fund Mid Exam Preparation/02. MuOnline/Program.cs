using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> game = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < game.Count; i++)
            {
                string[] tokens = game[i].Split();
                string command = tokens[0];
                int number = int.Parse(tokens[1]);

                if (command == "potion")
                {
                    int over = 0;
                    int amout = 0;
                    if (health < 100)
                    {

                        health += number;

                        if (health > 100)
                        {
                            over = health - 100;
                            amout = over - number;
                            health = 100;
                        }
                    }
                    Console.WriteLine($"You healed for {Math.Abs(amout)} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");

        }
    }
}
