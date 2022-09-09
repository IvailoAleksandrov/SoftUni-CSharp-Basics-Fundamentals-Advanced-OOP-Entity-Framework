using System;

namespace _10._Car_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double present = double.Parse(Console.ReadLine());


            int countA = 0;
            int countB = 0;
            int countV = 0;
            int countG = 0;

            for (int i = 1; i <= present; i++)
            {
                string typeOfPresent = Console.ReadLine();

                switch (typeOfPresent)
                {

                    case "A":
                        countA++;
                        break;
                    case "B":
                        countB++;
                        break;
                    case "V":
                        countV++;
                        break;
                    case "G":
                        countG++;
                        break;
                }
            }
            Console.WriteLine($"{countA / present * 100:f2}%");
            Console.WriteLine($"{countB / present * 100:f2}%");
            Console.WriteLine($"{countV / present * 100:f2}%");
            Console.WriteLine($"{countG / present * 100:f2}%");
            Console.WriteLine($"{present / people * 100:f2}%");





        }
    }
}
