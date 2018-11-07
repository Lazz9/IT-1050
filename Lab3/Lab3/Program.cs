using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor mike = new Instructor("Mike", "English");
            Instructor john = new Instructor("John", "Math");
            Student jane = new Student("Jane", john);
            Student joe = new Student("Joe", john);
            Student melissa = new Student("Melissa", mike);
            Student matt = new Student("Matt", mike);

            john.ChangeGrade(jane, 95);
            john.ChangeGrade(joe, 85);
            mike.ChangeGrade(melissa, 90);
            mike.ChangeGrade(matt, 92);
            System.Console.WriteLine("");
            jane.PrintStudent();
            joe.PrintStudent();
            melissa.PrintStudent();
            matt.PrintStudent();
           
            System.Console.ReadKey();
        }
    }
}
