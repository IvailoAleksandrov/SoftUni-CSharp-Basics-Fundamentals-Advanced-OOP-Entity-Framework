﻿using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] rounded = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                rounded[i] = (int)Math.Round(input[i],0,MidpointRounding.AwayFromZero);
                Console.WriteLine($"{input[i]} => {rounded[i]}");
            }


        }

    }
}
