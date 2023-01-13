using System;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skorost = int.Parse(Console.ReadLine());
            int gorivo = int.Parse(Console.ReadLine());

            double razstoqnie = 384400 * 2;
            double vreme = Math.Ceiling(razstoqnie / skorost);
            vreme += 3;

            double nujnoGorivo = gorivo * (razstoqnie / 100);
            
            Console.WriteLine(vreme);
            Console.WriteLine(nujnoGorivo);
        }
    }
}
