using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPassesCars = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            string input = Console.ReadLine();
            int count = 0;

            while (input != "end")
            {
                if (input == "green")
                {

                    for (int i = 0; i < numberPassesCars; i++)
                    {
                        count++;
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        if (queue.Count < 1)
                        {
                            break;
                        }
                    }


                }
                if (input != "green")
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
