using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5Practice
{
    class Person
    {
        public string firstName;
        public string lastName;

        public Person(string theirFirst, string theirLast)
        {
            this.firstName = theirFirst;
            this.lastName = theirLast;
        }
        public void PrintName()
        {
            System.Console.WriteLine(this.firstName + " " + this.lastName);
        }

    }
}