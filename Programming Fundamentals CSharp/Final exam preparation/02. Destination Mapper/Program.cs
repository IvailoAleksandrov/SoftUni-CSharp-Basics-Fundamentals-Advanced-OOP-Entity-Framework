using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|/)(?<name>[A-Z][A-z]{2,})\1";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            int point = 0;
            List<string> results = new List<string>();

            foreach (Match match in matches)
            {
                results.Add(match.Groups["name"].Value);
                point += match.Length - 2;
            }
            Console.WriteLine($"Destinations: {string.Join(", ", results)}");
            Console.WriteLine($"Travel Points: {point}");
        }
    }
}
