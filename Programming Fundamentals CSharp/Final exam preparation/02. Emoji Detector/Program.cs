using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(:{2}|\*{2})(?<emojiName>[A-Z][a-z]{2,})\1";
            string digitpattern = @"\d";
            string input = Console.ReadLine();
            long coolThresholdSum = 1;
            int countAllEmojis = 0;
            List<string> coolEmojis = new List<string>();


            Regex regex = new Regex(pattern);
            Regex digitRegex = new Regex(digitpattern);

            MatchCollection matches = Regex.Matches(input,pattern);
            MatchCollection digitMatches = Regex.Matches(input,digitpattern);


            foreach (Match digit in digitMatches)
            {
                coolThresholdSum *= int.Parse(digit.Value);
            }

            foreach (Match match in matches)
            {
                string name = match.Groups["emojiName"].Value;
                int sumNameAsDigits = 0;
                countAllEmojis++;

                for (int i = 0; i < name.Length; i++)
                {
                    char currChar = name[i];
                    sumNameAsDigits += currChar;
                }

                if (sumNameAsDigits > coolThresholdSum)
                {
                    coolEmojis.Add(match.Value);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", coolEmojis));
        }
    }
}
