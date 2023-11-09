using System;

namespace _02._Knights_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> action = Print;
            action(names);
        }

        private static void Print(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine($"Sir {name}");
            }
        }
    }
}
