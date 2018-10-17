
namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.AskForData();
            System.Console.WriteLine("Spouse info");
            p1.CreateSpouse();
     
            Person p2 = new Person();
            p2.AskForData();
            System.Console.WriteLine("Spouse info");
            p2.CreateSpouse();
    

            System.Console.WriteLine(p1.GetFirstandLast());
            System.Console.WriteLine(p1.Spouse.GetFirstandLast());
            System.Console.WriteLine(p2.GetFirstandLast());
            System.Console.WriteLine(p2.Spouse.GetFirstandLast());
            System.Console.WriteLine("Average Age: " + Person.AverageAge());
          

            System.Console.ReadKey();

          

        }
    }
}
