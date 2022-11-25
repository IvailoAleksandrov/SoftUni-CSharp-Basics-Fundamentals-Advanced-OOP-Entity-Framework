using System;
using System.Collections;
using System.Collections.Generic;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // "{piece}|{composer}|{key}
            Dictionary<string, List<string>> parts = new Dictionary<string, List<string>>();


            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split("|");
                string piece = info[0];
                string composer = info[1];
                string key = info[2];

                if (!parts.ContainsKey(piece))
                {
                    parts[piece] = new List<string>() { composer, key };

                }

            }
            string commands = Console.ReadLine();

            while (commands != "Stop")
            {
                string[] actions = commands.Split("|");
                string action = actions[0];
                string newPiece = actions[1];

                if (action == "Add")
                {
                    if (!parts.ContainsKey(newPiece))
                    {
                        parts.Add(newPiece, new List<string> { actions[2], actions[3] });
                        Console.WriteLine($"{newPiece} by {actions[2]} in {actions[3]} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{newPiece} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    if (parts.ContainsKey(newPiece))
                    {
                        parts.Remove(newPiece);
                        Console.WriteLine($"Successfully removed {newPiece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {newPiece} does not exist in the collection.");
                    }
                }
                else
                {
                    if (parts.ContainsKey(newPiece))
                    {
                        
                        string neww = actions[2];

                        parts[newPiece][1] = neww;
                        //string piece = actions[1];
                        //string newKey = actions[2];
                        //parts[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {newPiece} to {neww}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {newPiece} does not exist in the collection.");
                    }
                }
                commands = Console.ReadLine();
            }
            foreach (var item in parts)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
