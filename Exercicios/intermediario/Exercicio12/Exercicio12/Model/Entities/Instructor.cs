using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    internal class Instructor
    {
        public string Name { get; set; }
        public HashSet<Course> Courses { get; set; }

        public Instructor(string name)
        {
            Name = name;
            Courses = new HashSet<Course>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public int TotalUniqueStudents()
        {
            HashSet<Student> studentCodes = new HashSet<Student>();
            foreach (Course course in Courses)
            {
                studentCodes.UnionWith(course.Students);
            }
            return studentCodes.Count;
        }
    }
}