﻿using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> predicate = word => char.IsUpper(word[0]);
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(predicate)
                .ToList()
                .ForEach(word => Console.WriteLine(word));
        }
    }
}
