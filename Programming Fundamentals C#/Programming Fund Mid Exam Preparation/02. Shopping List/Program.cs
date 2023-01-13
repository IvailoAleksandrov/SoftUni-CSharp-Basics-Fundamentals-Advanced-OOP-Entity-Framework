using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine()); // 15 
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 0 0 0 0 
            int maxPeoplePerWagon = 4;

            for (int i = 0; i < lift.Length; i++)
            {
                for (int j = lift[i]; j < maxPeoplePerWagon; j++)
                {
                    lift[i]++;
                    peopleWaiting--;

                    if (peopleWaiting == 0 )
                    {
                        if (lift.Sum() < lift.Length*maxPeoplePerWagon)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }
                        Console.WriteLine(String.Join(" ",lift));
                        return;  // here are cases with empty seats, if we do not
                        // end here this means that if loop don`t become true and
                        // there are more people than seats and we print them outside for loop
                    }
                }

            }
            Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            Console.WriteLine(string.Join(' ', lift));
        }
    }
}
