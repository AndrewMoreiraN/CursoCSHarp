using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    internal class Student
    {
        public int Code { get; set; }
        public HashSet<Course> Courses { get; set; }

        public Student(int code)
        {
            Code = code;
            Courses = new HashSet<Course>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public override bool Equals(object obj)
        {
            if (obj is Student)
            {
                Student other = obj as Student;
                return Code.Equals(other.Code);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override string ToString()
        {
            return Code.ToString();
        }
    }
}