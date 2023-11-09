using System;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string suvenir = Console.ReadLine();

            int broi = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (country == "Argentina")
            {
                if (suvenir == "flags")
                {
                    totalPrice = broi * 3.25;
                }
                else if (suvenir == "caps")
                {
                    totalPrice = broi * 7.2;
                }
                else if (suvenir == "posters")
                {
                    totalPrice = broi * 5.1;
                }
                else if (suvenir == "stickers")
                {
                    totalPrice = broi * 1.25;
                }
            }
            else if (country == "Brazil")
            {
                if (suvenir == "flags")
                {
                    totalPrice = broi * 4.2;
                }
                else if (suvenir == "caps")
                {
                    totalPrice = broi * 8.5;
                }
                else if (suvenir == "posters")
                {
                    totalPrice = broi * 5.35;
                }
                else if (suvenir == "stickers")
                {
                    totalPrice = broi * 1.2;
                }
            }
            else if (country == "Croatia")
            {
                if (suvenir == "flags")
                {
                    totalPrice = broi * 2.75;
                }
                else if (suvenir == "caps")
                {
                    totalPrice = broi * 6.9;
                }
                else if (suvenir == "posters")
                {
                    totalPrice = broi * 4.95;
                }
                else if (suvenir == "stickers")
                {
                    totalPrice = broi * 1.1;
                }
            }
            else if (country == "Denmark")
            {
                if (suvenir == "flags")
                {
                    totalPrice = broi * 3.1;
                }
                else if (suvenir == "caps")
                {
                    totalPrice = broi * 6.5;
                }
                else if (suvenir == "posters")
                {
                    totalPrice = broi * 4.8;
                }
                else if (suvenir == "stickers")
                {
                    totalPrice = broi * 0.9;
                }
            }

            if (country != "Argentina" && country != "Brazil" && country != "Denmark" && country != "Croatia")
            {
                Console.WriteLine($"Invalid country!");
            }
            else if (suvenir != "flags" && suvenir != "caps" && suvenir != "posters" && suvenir != "stickers")
            {
                Console.WriteLine($"Invalid stock!");
            }
            else
            {
                Console.WriteLine($"Pepi bought {broi} {suvenir} of {country} for {totalPrice:f2} lv.");
            }
        }
    }
}
