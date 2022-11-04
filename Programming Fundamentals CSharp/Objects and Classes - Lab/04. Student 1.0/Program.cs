using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Student_1._0
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
                Student student = new Student(studInfo[0], studInfo[1], int.Parse(studInfo[2]), studInfo[3]);
                students.Add(student);

                studentInfo = Console.ReadLine();
            }

            string town = Console.ReadLine();

            List<Student> filteredStudents = students.Where(s => s.HomeTown == town).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
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

