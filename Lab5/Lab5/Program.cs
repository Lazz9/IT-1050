using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// I TRIED
namespace Lab5
{
    class Program
    {
        public const int SIZE = 8;
        public static string[][] grid = new string[SIZE][];

        static void Main(string[] args)
        {
            void CreateBoard()
            {
                for (int i = 0; i < SIZE; i++)
                {
                    grid[i] = new string[SIZE];


                    for (int j = 0; j < SIZE; j++)
                    {
                        grid[i][j] = (i < 2 || i > (SIZE - 3)) ? "X " : ". ";
                    }
                }
            }
            void PrintBoard()
            {
                for (int i = 0; i < SIZE; i++)
                {
                    System.Console.WriteLine();

                    if (i == 0)
                    {
                        System.Console.WriteLine("   0 1 2 3 4 5 6 7");
                        System.Console.WriteLine("   ===============");
                    }


                    for (int j = 0; j < SIZE; j++)
                    {
                        if (j == 0)
                        {
                            System.Console.Write(i + "| ");
                        }
                        System.Console.Write(grid[i][j]);
                    }
                }
                System.Console.WriteLine("\n");
            }
            void ChangeBoard()
            {
                System.Console.WriteLine("What is the X coordinate of the selected pawn? ");
                int x1 = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("What is the Y coordinate of the selected pawn? ");
                int y1 = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("What is the X coordinate of the destination? ");
                int x2 = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("What is the Y coordinate of the selected pawn? ");
                int y2 = int.Parse(System.Console.ReadLine());


                grid[x2][y2] = grid[x1][y1];
                grid[x1][y1] = "  ";

                System.Console.Clear();

                PrintBoard();
            }

            CreateBoard();
            PrintBoard();

            System.Console.WriteLine("Continue? (y/n) ");
            string move = System.Console.ReadLine();

            if (move == "y" || move == "Y")
            {
                ChangeBoard();
                System.Console.WriteLine("Continue? (y/n) ");
            }
            else
            {
                System.Console.WriteLine("Game Over");
                System.Console.ReadKey();
            }
            
            
        }
    }
}
