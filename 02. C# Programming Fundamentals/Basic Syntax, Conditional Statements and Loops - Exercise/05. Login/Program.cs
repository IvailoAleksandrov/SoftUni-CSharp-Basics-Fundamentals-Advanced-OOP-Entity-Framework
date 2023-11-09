using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int wrongCount = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string input = Console.ReadLine();
            while (input != password)
            {
                wrongCount++;
                
                if (wrongCount > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }

            if (password == input)
            {
                Console.WriteLine($"User {username} logged in.");
            }


        }
    }
}
