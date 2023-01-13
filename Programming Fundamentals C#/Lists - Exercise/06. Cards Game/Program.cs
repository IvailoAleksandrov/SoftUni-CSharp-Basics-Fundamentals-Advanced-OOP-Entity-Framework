using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> cards1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> cards2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            while ( cards1.Count > 0 && cards2.Count >0) // for example: 2 1 => 3 0  true false => brake the while loop and step over!
            {

                if (cards1[0] > cards2[0])
                {
                    cards1.Add(cards2[0]);
                    cards1.Add(cards1[0]);
                    cards1.RemoveAt(0);
                    cards2.RemoveAt(0);
                }
                else if (cards1[0] < cards2[0])
                {
                    cards2.Add(cards1[0]);
                    cards2.Add(cards2[0]);
                    cards2.RemoveAt(0);
                    cards1.RemoveAt(0);
                }
                else if (cards1[0] == cards2[0])
                {
                    cards1.RemoveAt(0);
                    cards2.RemoveAt(0);
                }
            }

            if (cards1.Count > cards2.Count)
            {
                sum = cards1.Sum();
            }
            else if (cards1.Count < cards2.Count)
            {
                sum = cards2.Sum();
            }


            if (cards1.Count > cards2.Count)
            {         
                Console.WriteLine($"First player wins! Sum: {sum}");
                
            }
            else if (cards1.Count < cards2.Count)
            {
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }

        }
    }
}
