﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();


            foreach (var number in input)
            {
                
                if (!counts.ContainsKey(number))
                {
                    counts.Add(number, 0);
                }
                counts[number] += 1;
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
               
            }


            

        }
    }
}
