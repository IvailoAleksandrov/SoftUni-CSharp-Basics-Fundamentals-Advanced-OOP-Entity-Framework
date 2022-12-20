using System;
using System.Linq;

namespace _03.Count_UpperCase_Words_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> uperCaseChecker = x => x[0] == x.ToUpper()[0];
            input.Where(uperCaseChecker).ToList().ForEach(x=> Console.WriteLine(x));    

         }
    }
}
