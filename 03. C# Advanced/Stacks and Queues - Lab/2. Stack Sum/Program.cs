using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine().ToLower();
            Stack<int> stack = new Stack<int>(number);

            while(input != "end")
            {
                string[] commands = input.Split();
                string action = commands[0];

                if (action == "add")
                {
                    stack.Push(int.Parse(commands[1]));
                    stack.Push(int.Parse(commands[2]));

                }
                else if (action == "remove")
                {
                    if (stack.Count >= int.Parse(commands[1]))
                    {
                        for (int i = 0; i < int.Parse(commands[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                
                input = Console.ReadLine().ToLower();
            }
            int sum = 0;
            foreach (var item in stack)
            {
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");


        }
    }
}
