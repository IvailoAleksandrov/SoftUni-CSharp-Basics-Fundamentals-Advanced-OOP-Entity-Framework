using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\|{1}|#{1})(?<name>[A-za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            int totalCalories = 0;

            foreach (Match match in matches) 
            {
                totalCalories += int.Parse(match.Groups["calories"].Value);
            }
            Console.WriteLine(totalCalories);
            Console.WriteLine($"You have food to last you for: {totalCalories/2000} days!");

        }
    }
}
