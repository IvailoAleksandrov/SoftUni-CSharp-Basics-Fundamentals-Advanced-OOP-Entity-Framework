using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            double finalPrice = size * 7.61;
            double discount = finalPrice * 0.18;
            Console.WriteLine($"The final price is: {finalPrice - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");


        }
    }
}
