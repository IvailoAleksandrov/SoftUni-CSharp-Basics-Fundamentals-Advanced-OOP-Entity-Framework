using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;
            if (shape == "square")
                double side = double.Parse(Console.ReadLine());
            area = side * side;




        }
    }
}
