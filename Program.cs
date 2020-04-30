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
            try
            {
                char[,] ticTacToe = new char[3, 3] { { '-', '-', '-'},
                                                     { '-', '-', '-'},
                                                     { '-', '-', '-'} };



                Console.WriteLine("Welcome to Tic Tac Toe");
                PrintBoard(ticTacToe);
                while (ticTacToe[0, 0] != 'X' || ticTacToe[0, 0] != 'O' || ticTacToe[0, 1] != 'X' || ticTacToe[0, 1] != 'O' ||
                       ticTacToe[0, 2] != 'X' || ticTacToe[0, 2] != 'O' || ticTacToe[1, 0] != 'X' || ticTacToe[1, 0] != 'O' ||
                       ticTacToe[1, 1] != 'X' || ticTacToe[1, 1] != 'O' || ticTacToe[1, 2] != 'X' || ticTacToe[1, 2] != 'O' ||
                       ticTacToe[2, 0] != 'X' || ticTacToe[2, 0] != 'O' || ticTacToe[2, 1] != 'X' || ticTacToe[2, 1] != 'O' ||
                       ticTacToe[2, 2] != 'X' || ticTacToe[2, 2] != 'O')
                {
                    Console.WriteLine("Player one you are X choose your row");
                    int p1row = int.Parse(Console.ReadLine());
                    Console.WriteLine("Player one choose your column");
                    int p1column = int.Parse(Console.ReadLine());

                    if (ticTacToe[p1row, p1column] == 'X' || ticTacToe[p1row, p1column] == 'O')
                    {
                        Console.WriteLine("That spot is already taken try again!");
                        continue;
                    }
                    else
                    {
                        ticTacToe[p1row, p1column] = 'X';
                        PrintBoard(ticTacToe);
                    }

                    Console.WriteLine("Player two you are O choose your row");
                    int p2row = int.Parse(Console.ReadLine());
                    Console.WriteLine("Player two choose your column");
                    int p2column = int.Parse(Console.ReadLine());

                    if (ticTacToe[p2row, p2column] == 'X' || ticTacToe[p2row, p2column] == 'O')
                    {
                        Console.WriteLine("That spot is already taken try again!");
                        continue;
                    }
                    else
                    {
                        ticTacToe[p2row, p2column] = 'O';
                        PrintBoard(ticTacToe);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Oops something went wrong!");
            }
            
        }


        static void PrintBoard(char[,] board)
        {
           for (int row = 0; row <= board.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= board.GetUpperBound(1); col++)
                {
                    Console.Write(board[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
   
    }
}
