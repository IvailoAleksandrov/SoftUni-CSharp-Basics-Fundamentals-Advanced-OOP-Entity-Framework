using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string name = Console.ReadLine();

            while (name != "End")
            {
                if (name != "Paid")
                {
                    queue.Enqueue(name);
                }
                if (name == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }


                name = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
           
        }
    }
}
