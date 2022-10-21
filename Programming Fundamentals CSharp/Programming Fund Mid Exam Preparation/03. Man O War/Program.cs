using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "Retire")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];

                if (action == "Fire")
                {
                    int index = int.Parse(tokens[1]);
                    int damage = int.Parse(tokens[2]);

                    if (index >= 0 && index < warShip.Count)
                    {
                        warShip[index] -= damage;

                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                if (action == "Defend")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int damage = int.Parse(tokens[3]);

                    if (startIndex >= 0 && endIndex >= 0 &&
                        startIndex < pirateShip.Count && endIndex < pirateShip.Count 
                        && damage >= 0)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            
                            pirateShip[i] -= damage; // to try without n ?

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                if (action == "Repair")
                {
                    int healIndex = int.Parse(tokens[1]);
                    int heal = int.Parse(tokens[2]);

                    if (healIndex >= 0 && healIndex < pirateShip.Count && heal >= 0)
                    {
                        pirateShip[healIndex] += heal;
                        if (pirateShip[healIndex] > maxHealth)
                        {
                            pirateShip[healIndex] = maxHealth;
                        }
                    }
                }
                if (action == "Status")
                {
                    int countBroken = 0;
                    double lowHealth = maxHealth - (maxHealth * 0.8);
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (lowHealth > pirateShip[i])
                        {
                            countBroken++;
                        }
                    }
                    Console.WriteLine($"{countBroken} sections need repair.");
                }
 
                command = Console.ReadLine();
            }
            int pirateResult = 0;
            int warResult = 0;

            for (int i = 0; i < pirateShip.Count; i++)
            {
                pirateResult += pirateShip[i];
            }
            Console.WriteLine($"Pirate ship status: {pirateResult}");

            for (int i = 0; i < warShip.Count; i++)
            {
                warResult += warShip[i];
            }
            Console.WriteLine($"Warship status: {warResult}"); 
        }
    }
}
