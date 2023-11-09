using System;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем броя на козунаците, които ще бъдат оценявани
            int numOfBread = int.Parse(Console.ReadLine());

            //Създаваме 2 променливи: за името на най-добрия пекар и за точките на най-добрия пекар
            string bestBeaker = string.Empty;
            int maxPoints = 0;


            //2. Пускаме цикъл за оценяване на всеки козунак (от 1вия до последния вкл.)
            for (int i = 1; i <= numOfBread; i++)
            {
                //  => Четем името на пекаря на съответния козунак
                string beakerName = Console.ReadLine(); //Създаваме 2 променливи за името и точките на моментния пекар
                int points = 0;

                //Създаваме променлива за входа
                string input = Console.ReadLine();
                //  => Пускаме вътрешен while цикъл, който да се изпълнява до получане на командата "Stop"
                while (input != "Stop")
                {
                    //добавяме точките от конзолата към общия брой точки за конкретния козунак
                    points += int.Parse(input);

                    //четем нов вход
                    input = Console.ReadLine();
                }

                //  => отпечатваме колко точки е събрал конкретния козунак и пекар
                Console.WriteLine($"{beakerName} has {points} points.");

                //  => проверяваме дали този пекар е най-добрия до момента
                if (points > maxPoints)
                {
                    bestBeaker = beakerName;
                    maxPoints = points;

                    //Трябва да отпечатаме, че е най-добрия до момента
                    Console.WriteLine($"{bestBeaker} is the new number 1!");
                }
            }

        }
    }
}
