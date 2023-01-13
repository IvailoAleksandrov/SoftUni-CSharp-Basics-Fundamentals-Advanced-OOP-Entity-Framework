using System;

namespace _02._Sum_Digits_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
           
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }
            Console.WriteLine(sum);

        }
    }
}
