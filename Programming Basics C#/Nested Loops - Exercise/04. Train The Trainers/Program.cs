using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            double finalAssessment = 0.0;
            int presentationCount = 0;

            while (name != "Finish")
            {
                double sumGrades = 0.0;
                for (int i = 0; i < juryCount; i++)
                {
                    sumGrades += double.Parse(Console.ReadLine());
                }
                double avarageGrade = sumGrades / juryCount;
                finalAssessment += sumGrades;
                Console.WriteLine($"{name} - {avarageGrade:F2}.");
                presentationCount++;
                name = Console.ReadLine();
            }
            finalAssessment /= presentationCount;
            Console.WriteLine($"Student's final assessment is {finalAssessment:F2}.");


        }
    }
}
