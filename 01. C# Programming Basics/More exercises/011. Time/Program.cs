﻿using System;

namespace _011._Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine()) + 30;

            if(min >59)
            {
                hours++;
                min -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{min:d2}");

        }
    }
}
