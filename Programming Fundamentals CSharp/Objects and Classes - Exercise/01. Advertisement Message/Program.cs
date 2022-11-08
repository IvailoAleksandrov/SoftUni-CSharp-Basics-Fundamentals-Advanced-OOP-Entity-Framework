using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string phrase = phrases[random.Next(0, phrases.Length)];
                string eventt = events[random.Next(0, events.Length)];
                string author = authors[random.Next(0, authors.Length)];
                string citie = cities[random.Next(0, cities.Length)];


                Console.WriteLine($"{phrase} {eventt} {author} {citie}");
            }
            
        }
    }
}
