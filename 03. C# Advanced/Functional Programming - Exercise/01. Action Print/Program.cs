using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string[]> action = name => Console.WriteLine(string.Join(Environment.NewLine, name));
            action(names);

            //------------------- OR ALTERNATIVELY -------------------
            //Action<string> action = name => Console.WriteLine(name);
            //Console.ReadLine().Split()
            //                  .ToList()
            //                  .ForEach(action);
        }
    }
}
