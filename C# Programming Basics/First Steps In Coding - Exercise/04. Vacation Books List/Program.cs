using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hoursTotal = pages / pagesPerHours;
            int hoursPerDay = hoursTotal / days;    
            Console.WriteLine(hoursPerDay);
        }
    }
}
