using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Security;
using static System.Net.Mime.MediaTypeNames;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] heroInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = heroInfo[0];
                int hp = int.Parse(heroInfo[1]);
                int mana = int.Parse(heroInfo[2]);
                heroes.Add(name, new List<int> { hp, mana });
            }
            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] tokens = commands.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string name = tokens[1];

                if (action == "CastSpell")
                {
                    int mana = int.Parse(tokens[2]);
                    string spell = tokens[3];

                    if (heroes[name][1] >= mana)
                    {
                        heroes[name][1] -= mana;
                        Console.WriteLine($"{name} has successfully cast {spell} and now has {heroes[name][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spell}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(tokens[2]);
                    string attacker = tokens[3];
                    heroes[name][0] -= damage;

                    if (heroes[name][0] > 0)
                    {
                        
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name][0]} HP left!");
                    }
                    else 
                    {
                        heroes.Remove(name);
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                    }

                }
                else if (action == "Recharge")
                {
                    int recharge = int.Parse(tokens[2]);  // 40
                    int currentMana = heroes[name][1];    // 150
                    heroes[name][1] += recharge;        // 190

                    if (heroes[name][1] > 200)
                    {
                        heroes[name][1] = 200;
                    }

                    Console.WriteLine($"{name} recharged for {Math.Abs(currentMana - heroes[name][1])} MP!");
                }
                else if (action == "Heal")
                {
                    int heal = int.Parse(tokens[2]);
                    int currentHP = heroes[name][0];
                    heroes[name][0] += heal;
                    if (heroes[name][0] > 100)
                    {
                        heroes[name][0] = 100;
                    }
                    Console.WriteLine($"{name} healed for {Math.Abs(currentHP - heroes[name][0])} HP!");
                }
                commands = Console.ReadLine();
            }
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }

        }
    }
}
