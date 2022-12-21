using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            Func<string, bool> predicate = name => name.Length <= length;

            IEnumerable<string> names = Console.ReadLine()
                                               .Split()
                                               .Where(predicate);
            Console.WriteLine(String.Join(Environment.NewLine, names));
        }
    }
}
