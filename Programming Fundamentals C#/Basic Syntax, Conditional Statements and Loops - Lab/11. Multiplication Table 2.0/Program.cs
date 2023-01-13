using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startN = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{n} X {startN} = {n * startN}");
                startN++;
            } while (startN <= 10);


        }
    }
}
