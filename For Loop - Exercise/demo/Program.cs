using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          int n =int.Parse(Console.ReadLine());
            double broiHora = 0;
            double obshtoHora = 0;

         double vr1 = 0;   // сума на хората 
            double vr2 = 0;
            double vr3 = 0;
            double vr4 = 0;
            double vr5 = 0;

            for (int i = 1; i <= n; i++)
            {
                broiHora = double.Parse(Console.ReadLine());
                obshtoHora += broiHora;

                if (broiHora <= 5)
                {
                    vr1 += broiHora;
                }
                else if (broiHora <= 12)
                {
                    vr2 += broiHora;
                }
                else if (broiHora <= 25)
                {
                    vr3 += broiHora;
                }
                else if (broiHora <= 40)
                {
                    vr4 += broiHora;
                }
                else
                {
                    vr5 += broiHora;
                }

            }
            vr1 = vr1 / obshtoHora * 100;
            vr2 = vr2 / obshtoHora * 100;
            vr3 = vr3 / obshtoHora * 100;
            vr4 = vr4 / obshtoHora * 100;
            vr5 = vr5 / obshtoHora * 100;

            Console.WriteLine($"{vr1:f2}%");
            Console.WriteLine($"{vr2:f2}%");
            Console.WriteLine($"{vr3:f2}%");
            Console.WriteLine($"{vr4:f2}%");
            Console.WriteLine($"{vr5:f2}%");
        }
    }
}
