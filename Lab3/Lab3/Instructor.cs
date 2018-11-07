using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Instructor
    {
        public string Name;
        public string CourseName;

        public Instructor()
        {

        }

        public Instructor(string theirName, string theirCourse)
        {
            this.Name = theirName;
            this.CourseName = theirCourse;
        }

        public void PrintTeacher()
        {
            System.Console.WriteLine(this.Name + ", Course: " + this.CourseName);
        }
        public void ChangeGrade(Student student, int theirGrade)
        {
            student.Grade = theirGrade;
            System.Console.WriteLine(this.Name + " gave " + student.Name + " a grade of: " + theirGrade);

        }
    }
}
