using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basee = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(basee, power));
        }

        static double MathPower(double basee, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= basee;
            }
            return result;
        }
    }
}
