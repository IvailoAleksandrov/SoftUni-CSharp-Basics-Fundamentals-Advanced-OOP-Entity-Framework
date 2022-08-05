using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            //10 <= градуси <= 18
            //18 < градуси <= 24
            //градуси >= 25

            if (time == "Morning")
            {
                if (degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else //degrees>=25
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (time == "Afternoon")
            {
                if (degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else //degrees>=25
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }

            else //time == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }

            //отпечата на конзолата на един ред: "It's {градуси} degrees, get your {облекло} and {обувки}."
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
