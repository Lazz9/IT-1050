using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

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
            System.Console.WriteLine(this.Name + ", " + this.CourseName);
        }
    }
}
