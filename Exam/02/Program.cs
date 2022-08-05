using System;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPlan = int.Parse(Console.ReadLine());
            int countPeople = int.Parse(Console.ReadLine());    
            int countDays = int.Parse(Console.ReadLine());

            double allHours = countPeople * countDays * 8;  // obshto chasove
            double processors = Math.Floor(allHours / 3);  // kolko izrabotvat
            double totalIzraboteni = 0;
            double money = 0;

            
            if ( processors < countPlan)
            {
              totalIzraboteni =  countPlan - processors;
                money = totalIzraboteni * 110.10;
                Console.WriteLine($"Losses: -> {money:f2} BGN");
            }
            else 
            {
                totalIzraboteni = processors - countPlan;
                money = totalIzraboteni * 110.10;
                Console.WriteLine($"Profit: -> {money:f2} BGN");
            }



        }
    }
}
