
using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+\b359(-| )2\1\d{3}\1\d{4}\b";
            //string pattern = @"(\+359 2 [0-9]{3} [0-9]{4})|(\+359-2-[0-9]{3}-[0-9]{4})\b";
            // @"\+359([ \-])2\1[0-9]{3}\1[0-9]{4}\b";
            string input = Console.ReadLine();

            Regex regex= new Regex(pattern);
            MatchCollection matchCollection= regex.Matches(input);
            Console.WriteLine(string.Join(", ", matchCollection));        }
    }
}
