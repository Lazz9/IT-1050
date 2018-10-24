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
            
            System.Console.ReadKey();
        }
    }
}
