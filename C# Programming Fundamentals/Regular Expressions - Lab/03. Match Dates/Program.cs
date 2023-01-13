using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            // @" \(?<date>\d{2})([\.\-\/])(
            string input = Console.ReadLine();
            MatchCollection matchCollection = Regex.Matches(input, pattern);

            foreach (Match match in matchCollection)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }

        }
    }
}
