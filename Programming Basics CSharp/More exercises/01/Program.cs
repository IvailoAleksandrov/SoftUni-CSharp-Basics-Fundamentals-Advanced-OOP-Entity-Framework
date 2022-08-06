using System;

namespace _01_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int student = 0;  // брой билети студент
            int standart = 0;
            int kid = 0;
            string input = Console.ReadLine();     // име на филма до команди "Finish"

            while (input != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());  // брой свободни седалки от 1 до 100 
                string typeTicket = Console.ReadLine();  // вид на билета "student" "standard" "kid" до команда "End"
                int tickets = 0;  //   Създаме променливи за продените билети за конкретната прожекция

                while (typeTicket != "End")
                {
                    if (typeTicket == "student")
                    {
                        student++;
                    }
                    else if (typeTicket == "standard")
                    {
                        standart++;
                    }
                    else
                    {
                        kid++;
                    }
                    tickets++;
                    if (tickets == freeSeats)
                    {
                        break;
                    }

                    typeTicket = Console.ReadLine();
                }
                //  => когато излезем от вътрешния цикъл:
                //     => Изчисляваме и отпечатваме какъв % от залата е запълнена (колко от общия брой билети са закупени)
                double procent = tickets*100/freeSeats;
                Console.WriteLine($"{input} - {procent:f2}% full.");

                input = Console.ReadLine();
            }

            int totalTickets = student + standart + kid;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{student / totalTickets * 100}% student tickets.");
            Console.WriteLine($"{standart / totalTickets * 100}% student tickets.");
            Console.WriteLine($"{kid / totalTickets * 100}% student tickets.");

        }
    }
}
