using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            if(shape == "square")
            {
                double lenght = double.Parse(Console.ReadLine());
                double area = lenght * lenght;
                Console.WriteLine($"{area:F3}");
            }
            else if(shape == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine($"{area:F3}");
            }
            else if(shape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = radius * radius * Math.PI;
                Console.WriteLine($"{area:F3}");
            }
            else if(shape == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = a * h / 2;
                Console.WriteLine($"{area:F3}");
            }
        }
    }
}
