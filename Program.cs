using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ticTacToe = new string[3, 3];
            Console.WriteLine("Welcome to Tic Tac Toe");
            Console.WriteLine("Player one choose your first");

            while (ticTacToe[0, 0] == null || ticTacToe[0, 1] == null || ticTacToe[0, 2] == null ||
                   ticTacToe[1, 0] == null || ticTacToe[1, 1] == null || ticTacToe[1, 2] == null ||
                   ticTacToe[2, 0] == null || ticTacToe[2, 1] == null || ticTacToe[2, 2] == null)
            {
                Console.WriteLine("Player one you are X choose your\nspot using the corresponding numbers (1,1)");
                string player1Choice = Console.ReadLine();
                if (player1Choice == "0,0")
                {
                    if (ticTacToe[0, 0] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[0, 0] = "X";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }

                }
                else if (player1Choice == "0,1")
                {
                    if (ticTacToe[0, 1] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[0, 1] = "X";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else if (player1Choice == "0,2")
                {
                    if (ticTacToe[0, 2] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[0, 2] = "X";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else if (player1Choice == "1,0")
                {
                    if (ticTacToe[1, 0] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[1, 0] = "X";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else if (player1Choice == "1,1")
                {
                    if (ticTacToe[1, 1] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[1, 1] = "X";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else if (player1Choice == "1,2")
                {
                    if (ticTacToe[1, 2] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[1, 2] = "X";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else if (player1Choice == "2,0")
                {
                    if (ticTacToe[2, 0] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[2, 0] = "X";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else if (player1Choice == "2,1")
                {
                    if (ticTacToe[2, 1] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[2, 1] = "X";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else if (player1Choice == "2,2")
                {
                    if (ticTacToe[2, 2] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[2, 2] = "X";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid entry!");
                    break;
                }

                Console.WriteLine("Player two you are O choose your\nspot using the corresponding numbers (1,1)");
                string player2Choice = Console.ReadLine();

                if (player2Choice == "0,0")
                {
                    if (ticTacToe[0, 0] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[0, 0] = "O";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }

                }
                else if (player2Choice == "0,1")
                {
                    if (ticTacToe[0, 1] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[0, 1] = "O";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else if (player2Choice == "0,2")
                {
                    if (ticTacToe[0, 2] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[0, 2] = "O";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else if (player2Choice == "1,0")
                {
                    if (ticTacToe[1, 0] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[1, 0] = "O";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else if (player2Choice == "1,1")
                {
                    if (ticTacToe[1, 1] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[1, 1] = "O";
                        PrintBoard(ticTacToe[0, 0], ticTacToe[0, 1], ticTacToe[0, 2],
                                   ticTacToe[1, 0], ticTacToe[1, 1], ticTacToe[1, 2],
                                   ticTacToe[2, 0], ticTacToe[2, 1], ticTacToe[2, 2]);
                    }
                }

                else if (player2Choice == "1,2")
                {
                    if (ticTacToe[1, 2] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[1, 2] = "O";
                        PrintBoard(ticTacToe[0,0], ticTacToe[0,1], ticTacToe[0,2],
                                   ticTacToe[1,0], ticTacToe[1,1], ticTacToe[1,2],
                                   ticTacToe[2,0], ticTacToe[2,1], ticTacToe[2,2]);
                    }
                }

                else if (player2Choice == "2,0")
                {
                    if (ticTacToe[2, 0] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[2, 0] = "O";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else if (player2Choice == "2,1")
                {
                    if (ticTacToe[2, 1] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[2, 1] = "O";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else if (player2Choice == "2,2")
                {
                    if (ticTacToe[2, 2] != null)
                    {
                        Console.WriteLine("That spot is already taken try again!");
                    }
                    else
                    {
                        ticTacToe[2, 2] = "O";
                        Console.WriteLine("  0 1 2");
                        Console.WriteLine("0 " + ticTacToe[0, 0] + " " + ticTacToe[0, 1] + " " + ticTacToe[0, 2]);
                        Console.WriteLine("1 " + ticTacToe[1, 0] + " " + ticTacToe[1, 1] + " " + ticTacToe[1, 2]);
                        Console.WriteLine("2 " + ticTacToe[2, 0] + " " + ticTacToe[2, 1] + " " + ticTacToe[2, 2]);
                    }
                }

                else
                {
                    Console.WriteLine("That is not a valid entry");
                    break;
                }
            }
            
        }

        static void PrintBoard(string a, string b, string c, string d, string e, string f, string g, string h, string i)
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + a + " " + b + " " + c);
            Console.WriteLine("1 " + d + " " + e + " " + f);
            Console.WriteLine("2 " + g + " " + h + " " + i);
        }
   
    }
}
