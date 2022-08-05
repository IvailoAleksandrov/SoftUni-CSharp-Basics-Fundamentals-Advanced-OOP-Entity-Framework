using System;

namespace _04._inches_to_sm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double sm = inches * 2.54;
            Console.WriteLine(sm);
        }
    }
}
