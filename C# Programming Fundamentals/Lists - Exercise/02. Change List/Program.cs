using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commands = Console.ReadLine();

            while (commands != "end")
            {
                string[] tokens = commands.Split();

                if (tokens[0] == "Delete")
                {
                    for (int i = 0; i < ints.Count; i++)
                    {
                        int removeNumber = int.Parse(tokens[1]);
                        ints.RemoveAll(rem => rem == removeNumber);
                        break;
                    }
                }
                else if (tokens[0] == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    int inseredNumber = int.Parse(tokens[1]);
                    ints.Insert(index, inseredNumber);
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", ints));
        }
    }
}
