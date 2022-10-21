using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            string action = command[0];
            string item = command[1];
            
            

            while (command[0] != "Craft!")
            {
                if (command[0] == "Collect")
                {
                    if (items.Contains(command[1]))
                    {
                        command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    else if (!items.Contains(command[1]))
                    {
                        items.Add(command[1]);
                    }
                }
                else if (command[0] == "Drop")
                {
                    if (items.Contains(command[1]))
                    {
                        items.Remove(command[1]);
                    }
                    else 
                    {
                        command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                }
                else if (command[0] == "Combine Items")
                {
                    string[] splitCombine = command[1].Split(":");

                    if (items.Contains(splitCombine[0]))
                    {
                        int index = items.IndexOf(splitCombine[0]);
                        items.Insert(index+1, splitCombine[1]);
 
                    }
                    else
                    {
                        command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                }
                if (command[0] == "Renew")
                {
                    if (items.Contains(command[1]))
                    {
                       string renew = command[1];
                        items.RemoveAt(0);
                        items.Add(renew);
                    }
                    else if (!items.Contains(command[1]))
                    {
                        command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                }


                command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}