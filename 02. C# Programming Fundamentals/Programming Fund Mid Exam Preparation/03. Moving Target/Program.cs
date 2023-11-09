using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commands = Console.ReadLine();

            while (true)
            {
                if (commands == "End")
                {
                    break;
                }

                string[] input = commands.Split();
                string action = input[0];
                int index = int.Parse(input[1]);
                int range = int.Parse(input[2]);
                if (action == "Shoot")
                {
                    if (index < 0 || index > targets.Count - 1)
                    {
                        break;
                    }
                    targets[index] -= range;
                    if (targets[index] <= 0)
                    {
                        targets.RemoveAt(index);
                    }
                }
                else if (action == "Add")
                {
                    if (index < 0 || index > targets.Count - 1)
                    {
                        Console.WriteLine("Invalid placement!");
                        break;
                    }
                    targets.Insert(index, range);

                }
                else if (action == "Strike")
                {
                    if (index - range < 0 || index + range > targets.Count - 1)
                    {
                        Console.WriteLine("Strike missed!");

                        break;
                    }

                    targets.RemoveRange(index - range, range * 2 + 1);
                }
                commands = Console.ReadLine();
            }
            
           
            Console.WriteLine(string.Join("|", targets));



        }

       
    }
}
