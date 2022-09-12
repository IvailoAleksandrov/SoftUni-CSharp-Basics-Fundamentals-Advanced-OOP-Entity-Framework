using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal usd = decimal.Parse(Console.ReadLine());

            decimal usdToPound = usd * 1.31M;
            Console.WriteLine($"{usdToPound:f3}");
        }
    }
}
