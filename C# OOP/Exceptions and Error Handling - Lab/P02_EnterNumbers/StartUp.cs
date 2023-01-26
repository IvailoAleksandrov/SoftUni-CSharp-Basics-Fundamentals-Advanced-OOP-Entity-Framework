using System;
using System.Net.Http.Headers;

namespace P02_EnterNumbers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                ReadNumbers(1, 10);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message); throw;
            }
        }
        public static void ReadNumbers(int start, int end)
        {
            int prevNumber = 0;
            for (int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    prevNumber = number;
                }
                if (number < prevNumber || number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException("Number not in range");
                }
            }
        }
    }

    
}
