using System;
using Model.Entities;

namespace Exercicio12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Instructor alex = new Instructor("Alex");
            Course A = new Course("A");
            Course B = new Course("B");
            Course C = new Course("C");
            alex.AddCourse(A);
            alex.AddCourse(B);
            alex.AddCourse(C);

            foreach (Course course in alex.Courses)
            {
                Console.Write($"How many students for course {course}: ");
                int numberOfStudents = int.Parse(Console.ReadLine());
                for (int j = 0; j < numberOfStudents; j++)
                {
                    int studentCode = int.Parse(Console.ReadLine());
                    course.AddStudent(new Student(studentCode));
                }
            }
            Console.WriteLine($"Total students: {alex.TotalUniqueStudents()}");
        }
    }
}