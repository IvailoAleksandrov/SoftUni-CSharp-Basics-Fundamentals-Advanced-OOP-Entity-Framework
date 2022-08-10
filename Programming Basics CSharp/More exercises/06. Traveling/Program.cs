using System;

namespace _06._Traveling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            

            while (input != "End")
            {
                double budjet = double.Parse(Console.ReadLine());
                double sum = 0;

                while (sum < budjet )
                {

                    double savedMoney = double.Parse(Console.ReadLine());
                    sum += savedMoney;
                }
                if (sum >= budjet)
                {
                    Console.WriteLine($"Going to {input}!");
                }
                input = Console.ReadLine();
                

            }



        }
    }
}
