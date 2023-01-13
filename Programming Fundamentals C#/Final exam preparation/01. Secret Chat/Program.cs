using System;
using System.Linq;
using System.Text;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string massage = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] actions = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string act = actions[0];

                if (act == "InsertSpace")
                {
                    int index = int.Parse(actions[1]);
                    massage = massage.Insert(index, " ");
                    Console.WriteLine(massage);
                }
                else if (act == "Reverse")
                {
                    string sub = actions[1];
                    int startIndex = massage.IndexOf(sub);

                    if (startIndex != -1)
                    {

                        massage = massage.Remove(startIndex, sub.Length);
                        massage += string.Join("", sub.Reverse());
                        Console.WriteLine(massage);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (act == "ChangeAll")
                {
                    string sub = actions[1];
                    string replacement = actions[2];

                    massage = massage.Replace(sub, replacement);
                    Console.WriteLine(massage);
                }

                command = Console.ReadLine();

            }
            Console.WriteLine($"You have a new text message: {massage}");

        }
    }
}
