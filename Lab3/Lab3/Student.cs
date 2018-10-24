using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        private string Name;
        private int Grade = 0;
        private Instructor Teacher = new Instructor();

        public Student(string studentName, Instructor theirTeacher)
        {
            this.Name = studentName;
            this.Teacher = theirTeacher;
        }
        public int SetGrade(int mygrade)
        {
            this.Grade = mygrade;
            return this.Grade;
        }
        public void PrintStudent()
        {
            System.Console.WriteLine(this.Name + " ," + this.Grade + ", Teacher: " + this.Teacher);
        }
    }
}
