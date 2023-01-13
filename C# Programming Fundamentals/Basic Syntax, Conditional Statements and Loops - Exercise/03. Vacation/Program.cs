using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = countPeople * 8.45;
                }
                else if (day == "Saturday")
                {
                    price = countPeople * 9.80;
                }
                else if (day == "Sunday")
                {
                    price = countPeople * 10.46;
                }

                if (countPeople >= 30)
                {
                    price -= price * 0.15;
                }

            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = countPeople * 10.90;
                }
                else if (day == "Saturday")
                {
                    price = countPeople * 15.60;
                }
                else if (day == "Sunday")
                {
                    price = countPeople * 16;
                }

                if (countPeople >= 100)
                {
                    price -= price / 100 * 10;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = countPeople * 15;
                }
                else if (day == "Saturday")
                {
                    price = countPeople * 20;
                }
                else if (day == "Sunday")
                {
                    price = countPeople * 22.50;
                }

                if (countPeople >= 10 && countPeople <= 20)
                {
                    price -= price * 0.05;
                }
            }
            Console.WriteLine($"Total price: {price:f2}");

        }
    }
}
