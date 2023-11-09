using System;

namespace _01._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            int maxnumber = int.MinValue;

            while (input != "Stop")
            {
                int number = int.Parse(input);

                if (number > maxnumber)
                {
                    maxnumber = number;
                }
                input = Console.ReadLine();
            }
            if (input == "Stop")
            {
                Console.WriteLine($"{maxnumber}");
            }
        }
    }
}
