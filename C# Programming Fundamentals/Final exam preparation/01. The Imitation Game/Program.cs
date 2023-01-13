using System;
using System.Linq;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string massage = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] tokens = input.Split("|");
                string action = tokens[0];

                if (action == "Move")
                {
                    int firstN = int.Parse(tokens[1]);

                    string moveable = massage.Substring(0, firstN);
                    massage = massage.Remove(0, firstN);
                    massage = massage.Insert(massage.Length, moveable);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    string toInsert = tokens[2];
                    massage = massage.Insert(index, toInsert);
                }
                else if (action == "ChangeAll")
                {
                    string subString = tokens[1];
                    string replacement = tokens[2];
                    massage = massage.Replace(subString, replacement);
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {massage}");
        }
    }
}
