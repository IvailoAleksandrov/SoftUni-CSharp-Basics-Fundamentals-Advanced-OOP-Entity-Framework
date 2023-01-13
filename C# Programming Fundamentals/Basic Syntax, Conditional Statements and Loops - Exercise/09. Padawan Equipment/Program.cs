using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            double lightsPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());   
            double beltsPrice = double.Parse(Console.ReadLine());

            double numLights = Math.Ceiling(people * 1.1);   // items needed
            double numBelts = Math.Floor(people / 6.0); // how much items will we need to remove from price calculation

            double totalPrice1 = lightsPrice * numLights; 
            double totalPrice2 = beltsPrice * (people - numBelts);
            double totalPrice3 = robePrice * people;
            double total = totalPrice1 + totalPrice2 + totalPrice3;

            if ( budjet >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - budjet:f2}lv more.");
            }

        }
    }
}
