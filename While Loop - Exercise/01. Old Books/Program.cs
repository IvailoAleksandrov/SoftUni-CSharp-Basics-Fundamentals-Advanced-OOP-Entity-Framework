using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            string input = Console.ReadLine();
            int bookCounter = 0;

            while (input != favouriteBook)
            {

                if (input == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookCounter} books.");
                        break;
                }

                bookCounter++;
                input = Console.ReadLine();
            }
            if (input == favouriteBook)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
        }
    }
}
