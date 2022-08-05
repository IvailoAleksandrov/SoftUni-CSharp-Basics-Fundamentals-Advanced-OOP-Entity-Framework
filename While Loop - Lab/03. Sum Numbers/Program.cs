using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumNumber = 0;

            while (sumNumber < number)
            {
                int newNum = int.Parse(Console.ReadLine());
                sumNumber += newNum;
            }
            Console.WriteLine($"{sumNumber}");
        }
    }
}
