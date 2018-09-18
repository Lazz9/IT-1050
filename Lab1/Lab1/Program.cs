using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("What is your First Name? ");       // Asks user for first name
            string firstName = System.Console.ReadLine();           // User inputs first name which is assigned to firstName

            System.Console.Write("What is your Middle Initial? ");   // Asks user for middle initial
            string middleInitial = System.Console.ReadLine();       // User inputs middle initial which is assigned to middleInitial

            System.Console.Write("What is your Last Name? ");       // Asks user for last name
            string lastName = System.Console.ReadLine();            // User inputs last name which is assigned to lastName

            string fullName = firstName + " " + middleInitial + " " + lastName;        // Assigns value to fullName

            System.Console.Write("What is you height in feet? (4,5 or 6) ");     // Asks user for height in feet
            int heightFeet = int.Parse(System.Console.ReadLine());                  // user inputs height which is assigned to heightFeet

            System.Console.Write("How many added inches taller are you? ");          // asks user for added inches to their height
            double heightInches = double.Parse(System.Console.ReadLine());          // user inputs added inches to their height

            double totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;       // assigns formula to totalHeightCM

            System.Console.Write("What is your age? ");                     // asks user for age
            int age = int.Parse(System.Console.ReadLine());                 // user inputs age which is assigned to age

            System.Console.Write("Are you a citizen? (true/false) ");        // asks user if they are a citizen
            bool isCitizen = bool.Parse(System.Console.ReadLine());          // assigns user input to isCitizen
            bool canVote = isCitizen == true && age >= 18;

            System.Console.WriteLine("");
            System.Console.WriteLine("+===============================+");
            System.Console.WriteLine("Fullname: " + fullName);                  // displays full name
            System.Console.WriteLine("Height(cm) " + totalHeightCM);            // displays total height in CM
            System.Console.WriteLine("Eligible to vote? " + canVote);           // displays if the user can vote
            System.Console.WriteLine("+===============================+");
            System.Console.WriteLine("");
            System.Console.WriteLine("Press any key to continue...");

            System.Console.ReadKey();
            
        }
    }
}
