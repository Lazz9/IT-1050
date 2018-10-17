

namespace Lab2
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Person Spouse;
        public static double SumOfAllAges = 0;


        public void AskForData()
        {
            System.Console.Write("First Name: ");
            this.firstName = System.Console.ReadLine();
            System.Console.Write("Last Name: ");
            this.lastName = System.Console.ReadLine();
            System.Console.Write("Age: ");
            this.age = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("");
            Person.SumOfAllAges += this.age;
            
        }
        public void CreateSpouse()
        {
            this.Spouse = new Person();
            this.Spouse.AskForData();
            this.Spouse.Spouse = this;

        }
        public string GetFirstandLast()
        {
            return this.lastName + ", " + this.firstName + " (" + this.age + ")";
        }
        public static double AverageAge()
        {
            double x = 0;
            x = SumOfAllAges / 4;
            return x;
        }


    }

    
    

     


    
}
