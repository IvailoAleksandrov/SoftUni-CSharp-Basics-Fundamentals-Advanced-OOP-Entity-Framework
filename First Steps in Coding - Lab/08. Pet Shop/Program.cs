using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int cats = int.Parse(Console.ReadLine());
            Console.WriteLine($"{dogs * 2.5 + cats * 4} lv.");
        }
    }
}
