using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            for (int i = 0; i < list.Count; i++)
            {
                int curentNumber = list[i];
                if (curentNumber < 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
                if (list.Count == 0)
                {
                    Console.WriteLine("empty");
                }
            }
            list.Reverse();
            Console.WriteLine(String.Join(" ", list));
            

            
        }
    }
}
