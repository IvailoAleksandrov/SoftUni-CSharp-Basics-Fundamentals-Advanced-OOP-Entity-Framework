using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "Add":
                        int addNumber = int.Parse(tokens[1]);
                        numbers.Add(addNumber);
                        break;
                    case "Remove":
                        int remove = int.Parse(tokens[1]);
                        numbers.Remove(remove);
                        break;
                    case "RemoveAt":
                        int removeAtIndex = int.Parse(tokens[1]);
                        numbers.RemoveAt(removeAtIndex);
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[2]);
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Insert(index, numberToRemove);
                        break;
                }
            }
            Console.Write(string.Join(" ", numbers));
        }
    }
}
