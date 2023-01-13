using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> furniture = new List<string>();
            double totalPrice = 0;


            while (input != "Purchase")
            {
                string pattern = @"(?<name>[A-z]+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)";
                Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    totalPrice += price * quantity;
                    furniture.Add(name);
                }


                input = Console.ReadLine();
            
            }

            Console.WriteLine("Bought furniture:");
            if (furniture.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furniture));
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
