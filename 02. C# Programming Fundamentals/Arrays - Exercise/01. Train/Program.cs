﻿using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] train = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write(train[i] + " ");
                sum += train[i];
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
