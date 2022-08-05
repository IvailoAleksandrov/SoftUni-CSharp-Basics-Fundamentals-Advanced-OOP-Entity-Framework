using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // броя на групите
            int group = 0; // броя на хората в групата
            double vr1 = 0;
            double vr2 = 0;
            double vr3 = 0;
            double vr4 = 0;
            double vr5 = 0;
            double obshtohora = 0;

            for (int i = 1; i <= n; i++)
            {
                group = int.Parse(Console.ReadLine());

                if (group <= 5)
                {
                    vr1 += group;
                }
                else if (group <= 12)
                {
                    vr2 += group;
                }
                else if (group <= 25)
                {
                    vr3 += group;
                }
                else if (group <= 40)
                {
                    vr4 += group;
                }
                else
                {
                    vr5 += group;
                }

            }
            obshtohora = vr1 + vr2 + vr3 + vr4 + vr5;
            Console.WriteLine($"{(vr1 / obshtohora * 100):F2}%");
            Console.WriteLine($"{(vr2 / obshtohora * 100):F2}%");
            Console.WriteLine($"{(vr3 / obshtohora * 100):F2}%");
            Console.WriteLine($"{(vr4 / obshtohora * 100):F2}%");
            Console.WriteLine($"{(vr5 / obshtohora * 100):F2}%");
        }
    }
    }


