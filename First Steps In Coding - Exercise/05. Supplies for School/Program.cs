using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());    
            int dishwasher = int.Parse(Console.ReadLine()); 
            int rate = int.Parse(Console.ReadLine());
            double pricePens = 5.8;
            double priceMarkers = 7.2;
            double priceDishw = 1.2;
            double sum = pens * pricePens + markers * priceMarkers + dishwasher * priceDishw;
            Console.WriteLine(sum - sum * rate / 100);


            

       }
    }
}
