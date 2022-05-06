using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    internal class Course
    {
        public string Name { get; set; }
        public HashSet<Student> Students { get; set; }

        public Course(string name)
        {
            Name = name;
            Students = new HashSet<Student>();
        }

        public void AddStudent(Student student)
        {
            student.AddCourse(new Course(Name));
            Students.Add(student);
        }

        public override bool Equals(object obj)
        {
            if (obj is Course)
            {
                Course other = obj as Course;
                return Name.Equals(other.Name);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}