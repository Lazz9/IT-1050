
namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.AskForData();
            p1.lastName = p1.spouse.lastName;
    
            Person p2 = new Person();
            p2.AskForData();
            p2.lastName = p2.spouse.lastName;

            System.Console.WriteLine(p1.GetFirstandLast());
            System.Console.WriteLine(p1.spouse.GetFirstandLast());
            System.Console.WriteLine(p2.GetFirstandLast());
            System.Console.WriteLine(p2.spouse.GetFirstandLast());

            System.Console.ReadKey();

          

        }
    }
}
