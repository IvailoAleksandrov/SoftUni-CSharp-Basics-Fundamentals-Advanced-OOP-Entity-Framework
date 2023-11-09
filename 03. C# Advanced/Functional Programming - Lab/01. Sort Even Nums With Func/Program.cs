using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sort_Even_Nums_With_Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> predicate = x => x % 2 == 0;
            List<int> evenNumbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(predicate)
                .OrderBy(x => x)
                .ToList();
            Console.WriteLine(String.Join(", ", evenNumbers));
        }
    }
}
