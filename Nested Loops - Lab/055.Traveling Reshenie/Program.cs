using System;

namespace _055.Traveling_Reshenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string whereToGo = Console.ReadLine();

                if (whereToGo == "End")
                {
                    break;
                }
                double requiredBudget = double.Parse(Console.ReadLine());
                double savings = 0;
                while (savings < requiredBudget)
                {
                    savings += double.Parse(Console.ReadLine());                  
                }

                Console.WriteLine($"Going to {whereToGo}!");



            }
        }
    }
}
