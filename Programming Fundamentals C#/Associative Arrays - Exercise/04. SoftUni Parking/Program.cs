using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];
                

                if (command == "register")
                {
                    if (!dict.ContainsKey(commands[1]))
                    {
                        dict.Add(commands[1], commands[2]);
                        Console.WriteLine($"{commands[1]} registered {commands[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {commands[2]}");
                    }
                }
                if (command == "unregister")
                {
                    if (dict.ContainsKey(commands[1]))
                    {
                        dict.Remove(commands[1]);
                        Console.WriteLine($"{commands[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {commands[1]} not found");
                    } 
                }
                

            }
            foreach (var user in dict)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }


        }
    }
}
