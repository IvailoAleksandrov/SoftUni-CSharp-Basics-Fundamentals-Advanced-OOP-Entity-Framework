using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string name = Console.ReadLine();
            int course = 1;
            int countBreak = 0;
            double sumEvaluation = 0;
            bool hasGraduated = true;


            while (course <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                sumEvaluation += grade;

                if (grade < 4)
                {
                    countBreak++;
                    if (countBreak > 0)
                    {
                        Console.WriteLine($"{name} has been excluded at {course} grade");
                        hasGraduated = false;
                        break;
                    }
                }
                course++;
            }
            if (hasGraduated)
            {
                sumEvaluation /= 12;
                Console.WriteLine($"{name} graduated. Average grade: {sumEvaluation:F2}");
            }



        }
    }
}
