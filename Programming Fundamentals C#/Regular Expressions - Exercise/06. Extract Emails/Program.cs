using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"[A-Za-z0-9]+[-._\w+]*@[A-Za-z0-9]+[-._\w+]*\.\w+";

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches) { Console.WriteLine(match); }
        }
    }
}
