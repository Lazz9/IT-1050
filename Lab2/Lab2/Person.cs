

namespace Lab2
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Person spouse;


        public void AskForData()
        {
            System.Console.Write("First Name: ");
            this.firstName = System.Console.ReadLine();
            System.Console.Write("Last Name: ");
            this.lastName = System.Console.ReadLine();
            System.Console.Write("Age: ");
            this.age = int.Parse(System.Console.ReadLine());
            System.Console.Write("Spouse's First Name: ");
            this.spouse.firstName = System.Console.ReadLine();
            System.Console.Write("Spouse's Age: ");
            this.spouse.age = int.Parse(System.Console.ReadLine());
        }
        public string GetFirstandLast()
        {
            return this.lastName + ", " + this.firstName + " (" + this.age + ")";
        }
       


    }

    
    

     


    
}
