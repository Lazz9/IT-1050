using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5Practice
{
    class Program
    {
        static void Main(string[] args)
        {
         
     
            Person[] people;
            people = new Person[3];
            people[0] = new Person("Baker", "Mayfield");
            people[1] = new Person("Nick", "Chubb");
            people[2] = new Person("Jarvis", "Landry");

            foreach (Person person in people)
            {
                person.PrintName();
            }


            System.Console.ReadKey();
        }
    }
}
