using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            if (operation == "+" || operation == "-" || operation == "*")
            {
                int result;
                if (operation == "+")
                {
                    result = num1 + num2;
                }
                else if (operation == "-")
                {
                    result = num1 - num2;
                }
                else
                {
                    result = num1 * num2;
                }
                string evenOrOdd = "even";
                if (result % 2 != 0)
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");
            }
            else
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    double result;
                    if (operation == "/")
                    {
                        result = (double)num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result:F2}");
                    }
                    else
                    {
                        result = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {result}");
                    }
                }
            }

        }
    }
}
