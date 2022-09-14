using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());  //subtracting M from N until N becomes less than M

            int currentPokePower = power;
            int targetsCount = 0;


            while (currentPokePower >= distance)
            {
                currentPokePower -= distance;
                targetsCount++;

                if (currentPokePower == power*0.5 && exhaustionFactor != 0)
                {
                    currentPokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(currentPokePower);
            Console.WriteLine(targetsCount);


        }
    }
}
