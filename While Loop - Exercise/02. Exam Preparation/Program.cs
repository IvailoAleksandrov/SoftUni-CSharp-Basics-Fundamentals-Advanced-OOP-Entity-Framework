using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broiNezadovolitelni = int.Parse(Console.ReadLine());  // ОК
            double countOcenki = 0;  // ok
            int countNezadovolitelni = 0; // ok
            double sumaOcenki = 0;
            string poslednaZadacha = string.Empty;     // ок
            double ocenka;    // ok
            string input = Console.ReadLine();
            
            

            while (input != "Enough")
            {
                poslednaZadacha= input;
                ocenka = double.Parse(Console.ReadLine());
                sumaOcenki += ocenka;
                countOcenki++;

                if (ocenka <= 4)
                {
                    countNezadovolitelni++;
                    if (countNezadovolitelni == broiNezadovolitelni)
                    {
                        Console.WriteLine($"You need a break, {countNezadovolitelni} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine();

            }
            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {sumaOcenki / countOcenki:f2}");
                Console.WriteLine($"Number of problems: {countOcenki}");
                Console.WriteLine($"Last problem: {poslednaZadacha}");
            }

        }
    }
}
