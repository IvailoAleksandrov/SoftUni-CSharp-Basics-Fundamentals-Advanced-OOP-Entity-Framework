using System;
using System.Collections.Generic;

namespace _05._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentInfo = Console.ReadLine();

            List<Student> students = new List<Student>();


            while (studentInfo != "end")
            {
                string[] studInfo = studentInfo.Split();

                if (IsStudentExisting(studInfo[0], studInfo[1], students))
                {
                    Student student = students.Find(student => student.FirstName == studInfo[0] && student.LastName == studInfo[1]);
                    student.Age = int.Parse(studInfo[2]);
                    student.HomeTown = studInfo[3];
                }
                else
                {
                    Student student = new Student(studInfo[0], studInfo[1], int.Parse(studInfo[2]), studInfo[3]);
                    students.Add(student);
                }



                

                studentInfo = Console.ReadLine();
            }

            string town = Console.ReadLine();

            foreach (Student student in students) // to access the student in List
            {
                if (town == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool IsStudentExisting(string firstName, string lastName, List<Student> students) // this is a method that checks if student already exists in List of Students
        {
            foreach (Student student in students)
            {
                if (firstName == student.FirstName && lastName == student.LastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
