using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;


            for (int i = 1; i <= n; i++)
            {
                int currentNum = (i * 2) - 1;
               
                Console.WriteLine(currentNum);
                sum += currentNum;

            }
            Console.WriteLine($"Sum: {sum}");




        }
    }
}
