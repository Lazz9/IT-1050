using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public Instructor Teacher { get; set; }

        public Student(string studentName, Instructor theirTeacher)
        {
            this.Name = studentName;
            this.Teacher = theirTeacher;
            this.Grade = 0;
        }
        public void SetGrade(int mygrade)
        {
            this.Grade = mygrade;
        }
        public void PrintStudent()
        {
            
            System.Console.Write(this.Name + " - Grade: " + this.Grade + ", Teacher: ");
            this.Teacher.PrintTeacher();
        }
        
    }
}
