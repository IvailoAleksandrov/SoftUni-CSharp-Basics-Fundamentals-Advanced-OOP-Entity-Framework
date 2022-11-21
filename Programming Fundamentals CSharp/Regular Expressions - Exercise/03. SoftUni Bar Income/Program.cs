using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+.?\d+)\$";
            double totalIncome = 0;

            
            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    double totalPrice = double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["count"].Value);
                    totalIncome += totalPrice;
                    Console.WriteLine($"{match.Groups["name"].Value}: {match.Groups["product"].Value} - {totalPrice:f2}");
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
