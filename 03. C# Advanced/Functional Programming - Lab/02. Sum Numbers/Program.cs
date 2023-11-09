using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> action = Print;
            List<int> numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            
            action(numbers);

        }

        public static void Print(List<int> numbers)
        {
            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }
    }
}
