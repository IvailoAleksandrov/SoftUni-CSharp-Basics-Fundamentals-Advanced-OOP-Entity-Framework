using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            Regex regex= new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                Match match= regex.Match(barcode);
                if (match.Success)
                {
                    string productGroup = "";
                    for (int j = 0; j < match.Value.Length; j++)
                    {
                        if (char.IsDigit(match.Value[j]))
                        {
                            productGroup += match.Value[j];
                        }
                    }
                    if (productGroup == "")
                    {
                        productGroup = "00";
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                    productGroup = "";
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }


        }
    }
}
