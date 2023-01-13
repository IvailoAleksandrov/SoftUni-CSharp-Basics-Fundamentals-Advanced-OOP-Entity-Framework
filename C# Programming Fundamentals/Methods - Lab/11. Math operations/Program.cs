using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculations(num1, sign, num2));
        }

         static double Calculations(double num1, char sign, double num2)
        {
            double result = 0;

            switch (sign)
            {
                case '+':
                    result = num1+num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            return result;
        }
    }
}
