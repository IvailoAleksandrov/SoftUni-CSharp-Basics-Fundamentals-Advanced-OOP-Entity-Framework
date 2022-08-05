using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int plastic = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());    
            int workingHours = int.Parse(Console.ReadLine());
            double sumPlastic = (plastic + 2) * 1.5;
            double sumPaint = (paint + paint * 0.1) * 14.5;
            double sumThinner = thinner * 5;
            double sum = sumPlastic + sumPaint + sumThinner + 0.40;
            double sumWork = sum * 0.3 * workingHours;

            Console.WriteLine(sum + sumWork);
        }
    }
}
