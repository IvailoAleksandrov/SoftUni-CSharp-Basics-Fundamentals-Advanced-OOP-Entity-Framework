using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //ВАЛИДНО -> [100…200] или е 0 -> печатаме нищо
            //НЕВАЛИДНО -> ПЕЧАТАМ invalid

            bool isValidNumber = (number >= 100 && number <= 200) || number == 0;
            //true -> валидно
            //false -> невалидно

            if (!isValidNumber)
            {
                Console.WriteLine("invalid");
            }


        }
    }
}
