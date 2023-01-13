using System;

namespace _01._Day_of_Week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());



            if (day <= 7 && day > 0)
            {
                Console.WriteLine(weekDays[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
