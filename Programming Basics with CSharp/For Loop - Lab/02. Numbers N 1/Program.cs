﻿using System;

namespace _02._Numbers_N_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; n >= 1; n--)
            {
                Console.WriteLine(n);
            }
        }
    }
}