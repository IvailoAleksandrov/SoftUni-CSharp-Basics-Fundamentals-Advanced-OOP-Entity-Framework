using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> action = name => name.ToList().ForEach(x => 
            Console.WriteLine($"Sir {x}"));
            action(names);
        }
    }
}
