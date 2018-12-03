using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double smallSoda = 3.50;
            double largeSoda = 5.99;
            double hotdog = 3.99;
            double popcorn = 4.50;
            double candy = 1.99;


            System.Console.WriteLine("Will you be going to the movies today? (Y/N) ");
            string response = System.Console.ReadLine();

            if (response == "Y" || response == "y")
            {
                System.Console.WriteLine("Will you be going in the evening? (Y/N) ");
                string response2 = System.Console.ReadLine();
                if (response2 == "Y" || response2 == "y")
                {
                    double child = 3.99;
                    double adult = 5.99;
                    double senior = 4.50;
                    void getInfo()
                    {
                        System.Console.WriteLine("How many children? ");
                        int children = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("How many adults? ");
                        int adults = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("How many seniors? ");
                        int seniors = int.Parse(System.Console.ReadLine());
                        total += (child * children) + (adult * adults) + (senior * seniors);
                        System.Console.WriteLine("Will you be purchasing snacks? (Y/N)");
                        string response3 = System.Console.ReadLine();

                        if (response3 == "Y" || response3 == "y")
                        {
                            void getSnack()
                            {
                                System.Console.Write("How many orders of Small Soda? ");
                                int smallSodas = int.Parse(System.Console.ReadLine());
                                System.Console.Write("How many orders of Large Soda? ");
                                int largeSodas = int.Parse(System.Console.ReadLine());
                                System.Console.Write("How many orders of Popcorn? ");
                                int popcorns = int.Parse(System.Console.ReadLine());
                                System.Console.Write("How many orders of Hotdogs? ");
                                int hotdogs = int.Parse(System.Console.ReadLine());
                                System.Console.Write("How many orders of Candy? ");
                                int candies = int.Parse(System.Console.ReadLine());
                                total += (smallSoda * smallSodas) + (largeSoda * largeSodas) + (popcorn * popcorns) + (hotdog * hotdogs) + (candy + candies);
                                if (popcorns > 0 && largeSodas > 0)
                                {
                                    total -= 2;
                                }
                                if ((children + adults + seniors) > 3)
                                {
                                    System.Console.WriteLine("Congratulations, you get a free popcorn! ");

                                }
                                if (candies >= 3)
                                {
                                    System.Console.WriteLine("Congratulations, you get a free candy! ");
                                }

                            }
                            getSnack();
                        }

                    }
                    getInfo();
                    
                }
                else if (response2 == "N" || response2 == "n")
                {
                    double child = 6.99;
                    double adult = 10.99;
                    double senior = 8.50;
                    void getInfo()
                    {
                        System.Console.WriteLine("How many children? ");
                        int children = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("How many adults? ");
                        int adults = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("How many seniors? ");
                        int seniors = int.Parse(System.Console.ReadLine());
                        total += (child * children) + (adult * adults) + (senior * seniors);
                        System.Console.WriteLine("Will you be purchasing snacks? (Y/N)");
                        string response3 = System.Console.ReadLine();

                        if (response3 == "Y" || response3 == "y")
                        {
                            void getSnack()
                            {
                                System.Console.Write("How many orders of Small Soda? ");
                                int smallSodas = int.Parse(System.Console.ReadLine());
                                System.Console.Write("How many orders of Large Soda? ");
                                int largeSodas = int.Parse(System.Console.ReadLine());
                                System.Console.Write("How many orders of Popcorn? ");
                                int popcorns = int.Parse(System.Console.ReadLine());
                                System.Console.Write("How many orders of Hotdogs? ");
                                int hotdogs = int.Parse(System.Console.ReadLine());
                                System.Console.Write("How many orders of Candy? ");
                                int candies = int.Parse(System.Console.ReadLine());
                                total += (smallSoda * smallSodas) + (largeSoda * largeSodas) + (popcorn * popcorns) + (hotdog * hotdogs) + (candy + candies);
                                if (popcorns > 0 && largeSodas > 0)
                                {
                                    total -= 2;
                                }
                                if ((children + adults + seniors) > 3)
                                {
                                    System.Console.WriteLine("Congratulations, you get a free popcorn! ");

                                }
                                if (candies >= 3)
                                {
                                    System.Console.WriteLine("Congratulations, you get a free candy! ");
                                }

                            }
                            getSnack();
                        }

                    }
                    getInfo();
                }
                else
                {
                    System.Console.WriteLine("Invalid Response");
                }
            }
            else if (response == "N" || response == "n")
            {
                System.Console.WriteLine("Enjoy the rest of your day!");
            }
            else
            {
                System.Console.WriteLine("Invalid Answer");
            }
            System.Console.WriteLine();
                    System.Console.WriteLine("Your movie total is: $" + total);
                    System.Console.ReadKey();
        }
    }
}
