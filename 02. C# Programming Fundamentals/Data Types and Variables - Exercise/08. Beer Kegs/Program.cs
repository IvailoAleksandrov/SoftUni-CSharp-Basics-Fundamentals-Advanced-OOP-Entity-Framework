﻿using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numKegs = int.Parse(Console.ReadLine());

            string theBiggestKeg = string.Empty;
            double theBiggest = double.MinValue;

            for (int i = 0; i < numKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * (Math.Pow(radius, 2)) * height;

                if (volume > theBiggest)
                {
                    theBiggest = volume;
                    theBiggestKeg = model;
                }
                
            }
            Console.WriteLine(theBiggestKeg);
        }
    }
}
